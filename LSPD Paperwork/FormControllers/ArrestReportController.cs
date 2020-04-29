using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LSPDPaperwork.FormControllers {
    internal class ArrestReportController : ControllerBase {
        internal struct Controls {
            public TextBox SuspName { get; set; }
            public TextBox SuspPhone { get; set; }
            public CheckBox LicensesRevoked { get; set; }
            public Control ArrestingOfficers { get; set; }
            public Control Mugshot { get; set; }
            public CheckedListBox ChkCrimes { get; set; }
            [SingleString]
            public Control Narrative { get; set; }
            [NonData]
            public Control BtnGovEmployee { get; set; }
            [NonData]
            public Control BtnAttempted { get; set; }
            [NonData]
            public Control BtnAccessory { get; set; }
            [NonData]
            public Control BtnAggravated { get; set; }
            [NonData]
            public TextBox SuggestCharge { get; set; }
            [NonData]
            public Control BtnGenArrestReport { get; set; }
        }
        private readonly Controls controls;
        private readonly Dictionary<object, string> btnDict = new Dictionary<object, string>();
        private readonly ICrimeList crimeList;
        private readonly Func<IReporter> reporter;
        private readonly string replyURL;

        internal ArrestReportController(Controls controls,
                                        ISuspectManager suspMgr,
                                        Func<IReporter> reporter,
                                        Type reporterT,
                                        ICrimeList crimeList,
                                        string replyURL = null)
            : base(suspMgr, controls.SuspName, controls.SuspPhone, reporterT) {
            this.reporter = reporter;
            this.controls = controls;
            this.replyURL = replyURL;
            btnDict.Add(controls.BtnAttempted, "Attempted ");
            btnDict.Add(controls.BtnAccessory, "Accessory to ");
            btnDict.Add(controls.BtnAggravated, "Aggravated ");
            btnDict.Add(controls.BtnGovEmployee, " Against a Government Employee");

            controls.ArrestingOfficers.Text = reporter().GetPrefill();

            controls.SuspName.AutoCompleteCustomSource = suspMgr.SuspNames;
            controls.SuspPhone.AutoCompleteCustomSource = suspMgr.SuspPhnes;

            this.crimeList = crimeList;
            foreach (var crime in crimeList.Crimes)
                controls.ChkCrimes.Items.Add(crime);
            controls.SuggestCharge.AutoCompleteCustomSource = crimeList.CrimesAutoCompletion;

            controls.BtnAccessory.Click += ChargeModifierClicked;
            controls.BtnAggravated.Click += ChargeModifierClicked;
            controls.BtnAttempted.Click += ChargeModifierClicked;
            controls.BtnGovEmployee.Click += ChargeModifierClicked;
            controls.SuggestCharge.KeyUp += SuggestChargeKeyUp;
            controls.BtnGenArrestReport.MouseUp += GenArrestReportMouseUp;
        }

        private void ResetCrimes() {
            foreach (var crime in crimeList.Crimes)
                crime.Reset();
            controls.ChkCrimes.Refresh();
            foreach (int i in controls.ChkCrimes.CheckedIndices)
                controls.ChkCrimes.SetItemChecked(i, false);
        }

        private void ModifyCharge(string extra, bool append = false) {
            var chkCrimes = controls.ChkCrimes;
            if (chkCrimes.SelectedIndex == -1)
                return;
            var idx = chkCrimes.SelectedIndex;
            var crime = chkCrimes.Items[idx] as ICrime;
            Action<string> func;
            if (append) {
                if (crime.Suffix.Contains(extra))
                    func = crime.DelSuffix;
                else
                    func = crime.AddSuffix;
            } else {
                if (crime.Prefix.Contains(extra))
                    func = crime.DelPrefix;
                else
                    func = crime.AddPrefix;
            }
            func(extra);
            chkCrimes.Items[idx] = crime;
        }

        private void ChargeModifierClicked(object sender, EventArgs _) {
            btnDict.TryGetValue(sender, out string str);
            ModifyCharge(str, str[0] == ' ');
        }

        private void SuggestChargeKeyUp(object _, KeyEventArgs e) {
            if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Enter)
                return;
            var i = 0;
            var chkCrimes = controls.ChkCrimes;
            foreach (ICrime item in chkCrimes.Items) {
                if (item.Equals(controls.SuggestCharge.Text)) {
                    chkCrimes.SetItemChecked(i, true);
                    chkCrimes.SelectedIndex = i;
                    return;
                }
                ++i;
            }
        }

        private void GenArrestReportMouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ResetInputs(typeof(Controls), controls);
                ResetCrimes();
                controls.ArrestingOfficers.Text = reporter().GetPrefill();
            } else {
                controls.ArrestingOfficers.Text = enUS.TextInfo.ToTitleCase(controls.ArrestingOfficers.Text);
                controls.SuspName.Text = enUS.TextInfo.ToTitleCase(controls.SuspName.Text);
                GenerateReport(typeof(Controls), controls);
                if (replyURL != null)
                    _ = Process.Start(replyURL);
            }
        }

        protected override void URIReceived(string data) {
            controls.Mugshot.Text = data;
        }
    }
}
