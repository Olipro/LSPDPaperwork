using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace LSPDPaperwork.FormControllers {
    public abstract class ControllerBase {
        public const string IMGSERVICES = "ImgServices.txt";
        protected static URLMatcher ImgServices { get; } = new URLMatcher(IMGSERVICES);
        protected static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");

        private readonly TextBox suspName;
        private readonly TextBox suspPhone;
        private readonly Type reporterT;
        protected ISuspectManager SuspMgr { get; }

        [AttributeUsage(AttributeTargets.Property)]
        internal class NonDataAttribute : System.Attribute { }

        [AttributeUsage(AttributeTargets.Property)]
        internal class SingleStringAttribute : Attribute { }

        protected ControllerBase(Type reporterT) {
            this.reporterT = reporterT;
        }

        protected ControllerBase(ISuspectManager suspMgr, TextBox suspName, TextBox suspPhone, Type reporterT) {
            Contract.Requires(suspMgr != null);
            Contract.Requires(suspName != null);
            Contract.Requires(suspPhone != null);
            this.suspName = suspName;
            this.suspPhone = suspPhone;
            this.reporterT = reporterT;
            SuspMgr = suspMgr;

            suspName.TextChanged += NameTextChanged;
            suspName.AutoCompleteCustomSource = suspMgr.SuspNames;

            suspPhone.TextChanged += PhoneTextChanged;
            suspPhone.AutoCompleteCustomSource = suspMgr.SuspPhnes;
            suspPhone.KeyPress += NumericHandler;

            ClipboardMonitor.ShortTextEvent += ClipboardTextEvent;
        }

        private void ClipboardTextEvent(string data) {
            if (ImgServices.HasMatchFor(data))
                URIReceived(data);
        }

        protected virtual void URIReceived(string data) { }

        protected void GenerateReport(Type ctrlsType, object ctrls) => GenerateReport(ctrlsType, ctrls, reporterT);

        protected void GenerateReport(Type ctrlsType, object ctrls, Type reporterT) {
            Contract.Requires(ctrlsType != null);
            Contract.Requires(reporterT != null);
            var args = new List<object>();
            foreach (var prop in ctrlsType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                if (prop.GetCustomAttribute(typeof(NonDataAttribute)) == null) {
                    var justStr = prop.GetCustomAttribute(typeof(SingleStringAttribute)) != null;
                    switch (prop.GetValue(ctrls)) {
                        case TextBoxBase t:
                            args.Add(t.Multiline && !justStr ? t.Lines as object : t.Text);
                            break;
                        case CheckBox c:
                            args.Add(c.Checked);
                            break;
                        case CheckedListBox c:
                            if (c.Enabled && c.CheckedItems.Count > 0)
                                args.Add(c.CheckedItems.Cast<object>());
                            break;
                        case DateTimePicker d:
                            args.Add(d.Value);
                            break;
                        case NumericUpDown n:
                            args.Add(n.Value);
                            break;
                    }
                }
            foreach (var ctor in reporterT.GetConstructors())
                if (ctor.GetParameters().Length == args.Count) {
                    var inst = ctor.Invoke(args.ToArray()) as IReporter;
                    Clipboard.SetText(inst.GetReport());
                    break;
                }
            if (SuspMgr != null)
                SuspMgr.AddSuspect(new Suspect(suspName.Text, suspPhone.Text));
        }
        protected static void ResetInputs(Type ctrlsType, object ctrls) {
            Contract.Requires(ctrlsType != null);
            foreach (var m in ctrlsType.GetProperties(BindingFlags.Instance | BindingFlags.Public))
                switch (m.GetValue(ctrls, null)) {
                    case TextBoxBase t:
                        t.Clear();
                        break;
                    case DateTimePicker d:
                        d.Value = DateTime.UtcNow;
                        break;
                    case CheckBox c:
                        c.Checked = false;
                        break;
                }
        }

        protected static void NumericHandler(object s, KeyPressEventArgs e) {
            Contract.Requires(e != null);
            e.Handled = (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b';
        }

        private void PhoneTextChanged(object _, EventArgs __) {
            if (suspName.TextLength != 0)
                return;
            var susp = SuspMgr.FindFromPhone(suspPhone.Text);
            if (susp != null)
                suspName.Text = susp.Name;
        }

        private void NameTextChanged(object sender, EventArgs e) {
            if (suspPhone.TextLength != 0)
                return;
            var susp = SuspMgr.FindFromName(suspName.Text);
            if (susp != null)
                suspPhone.Text = susp.Phone;
        }
    }
}
