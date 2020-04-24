using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using static LSPDPaperwork.NativeMethods;

namespace LSPDPaperwork
{
    public partial class LSPDPMainForm : Form
    {
        private const string IMG_SERVICES = "ImgServices.txt";
        private const int WM_CLIPBOARDUPDATE = 0x031D;
        private static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");

        private readonly CrimeList crimeList = new CrimeList();
        private readonly SuspectManager suspMgr = new SuspectManager();
        private readonly Dictionary<object, string> btnDict = new Dictionary<object, string>();
        private readonly URLMatcher imgServices = new URLMatcher(IMG_SERVICES);
        private volatile bool writingClipboard = false;
        public LSPDPMainForm()
        {
            InitializeComponent();

            AddClipboardFormatListener(this.Handle);

            txtNotes.Text = new DutyReporter().GetPrefill();
            txtArrestingOfficers.Text = new ArrestReporter().GetPrefill();
            txtOfficersInvolved.Text = new ImpoundReporter().GetPrefill();

            var vehicleList = new VehicleList();
            txtVehModel.AutoCompleteCustomSource = vehicleList.Vehicles();
            txtRelModel.AutoCompleteCustomSource = vehicleList.Vehicles();

            foreach (var crime in crimeList.Crimes())
                chkCrimes.Items.Add(crime);
            txtSuggestCharge.AutoCompleteCustomSource = crimeList.CrimesAutoCompletion();

            btnDict.Add(btnAttempted, "Attempted ");
            btnDict.Add(btnAccessory, "Accessory to ");
            btnDict.Add(btnAggravated, "Aggravated ");
            btnDict.Add(btnGovEmployee, " Against a Government Employee");

            txtSuspect.AutoCompleteCustomSource = suspMgr.SuspNames;
            txtVehOwner.AutoCompleteCustomSource = suspMgr.SuspNames;
            txtRelVehOwner.AutoCompleteCustomSource = suspMgr.SuspNames;
            txtSuspPhone.AutoCompleteCustomSource = suspMgr.SuspPhnes;
            txtPhoneNumber.AutoCompleteCustomSource = suspMgr.SuspPhnes;
            txtRelPhoneNum.AutoCompleteCustomSource = suspMgr.SuspPhnes;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (writingClipboard || m.Msg != WM_CLIPBOARDUPDATE || !Clipboard.ContainsText())
                return;
            if (GlobalSize(GetClipboardData(CB_TEXT)).ToUInt64() > 200)
                return;
            var text = Clipboard.GetText();
            if (!imgServices.HasMatchFor(text))
                return;
            if (tabControl1.SelectedTab == tabArrestReport)
                txtMugshot.Text = text;
            else if (tabControl1.SelectedTab == tabImpoundReport)
                txtScreenshot.Text = text;
        }

        private void ResetCrimes()
        {
            foreach (var crime in crimeList.Crimes())
                crime.Reset();
            chkCrimes.Refresh();
            foreach (var i in chkCrimes.CheckedIndices)
                chkCrimes.SetItemChecked((int)i, false);
        }

        private void ResetInputs(Control.ControlCollection controls)
        {
            foreach (var ctrl in controls)
            {
                if (ctrl is TextBox || ctrl is MaskedTextBox)
                {
                    ((TextBoxBase)ctrl).Clear();
                }
                else if (ctrl is DateTimePicker)
                {
                    ((DateTimePicker)ctrl).Value = DateTime.UtcNow;
                }
            }
        }

        private void ReportToClipboard(IReporter reporter)
        {
            writingClipboard = true;
            Clipboard.SetText(reporter.GetReport());
            writingClipboard = false;
        }

        private void BtnGenImpoundReport_Click(object sender, EventArgs e)
        {
            txtOfficersInvolved.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtOfficersInvolved.Text);
            txtLicensePlate.Text = txtLicensePlate.Text.ToUpper(CultureInfo.GetCultureInfo("en-US"));
            ReportToClipboard(new ImpoundReporter(txtVehOwner.Text,
                                                  txtPhoneNumber.Text,
                                                  txtLicensePlate.Text,
                                                  txtVehModel.Text,
                                                  txtVehColour.Text,
                                                  txtVehDetails.Text,
                                                  dtImpoundTime.Value,
                                                  txtImpoundLocation.Text,
                                                  txtReason.Text,
                                                  txtOfficersInvolved.Text,
                                                  txtScreenshot.Text));
            suspMgr.AddSuspect(new Suspect(txtVehOwner.Text, txtPhoneNumber.Text));
        }
        private void BtnGenReleaseReport_Click(object sender, EventArgs e)
        {
            txtRelOfficer.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtRelOfficer.Text);
            txtRelLicense.Text = txtRelLicense.Text.ToUpper(enUS);
            if (txtRelFee.Text.Length == 0)
                txtRelFee.Text = "0";
            ReportToClipboard(new ImpoundReleaseReporter(txtRelVehOwner.Text,
                                                         txtRelPhoneNum.Text,
                                                         txtRelLicense.Text,
                                                         txtRelModel.Text,
                                                         txtRelColour.Text,
                                                         txtRelDate.Value,
                                                         txtRelOfficer.Text,
                                                         txtRelFee.Text));
            suspMgr.AddSuspect(new Suspect(txtRelVehOwner.Text, txtRelPhoneNum.Text));
        }

        private void BtnGenArrestReport_Click(object sender, EventArgs e)
        {
            txtArrestingOfficers.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtArrestingOfficers.Text);
            ReportToClipboard(new ArrestReporter(txtSuspect.Text,
                                                txtSuspPhone.Text,
                                                chkLicensesRevoked.Checked,
                                                txtArrestingOfficers.Lines,
                                                txtMugshot.Text,
                                                chkCrimes.CheckedItems.Cast<Crime>(),
                                                txtNarrative.Text));
            suspMgr.AddSuspect(new Suspect(txtSuspect.Text, txtSuspPhone.Text));
        }

        private void BtnGenDutyReport_Click(object sender, EventArgs e)
        {
            ReportToClipboard(new DutyReporter(dtWatchStart.Value, dtWatchEnd.Value, numArrests.Value, numCitations.Value, txtNotes.Text));
        }

        private void BtnGenImpoundReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ResetInputs(tabImpoundReport.Controls[0].Controls);
                txtOfficersInvolved.Text = new ImpoundReporter().GetPrefill();
            }
            else
                BtnGenImpoundReport_Click(sender, e);
        }

        private void BtnGenReleaseReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ResetInputs(tabImpoundRelease.Controls[0].Controls);
            else
                BtnGenReleaseReport_Click(sender, e);
        }

        private void BtnGenArrestReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ResetInputs(tabArrestReport.Controls[0].Controls);
                ResetCrimes();
                txtArrestingOfficers.Text = new ArrestReporter().GetPrefill();
            }
            else
                BtnGenArrestReport_Click(sender, e);
        }

        private void BtnGenDutyReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ResetInputs(tabDutyReport.Controls[0].Controls);
                txtNotes.Text = new DutyReporter().GetPrefill();
            }
            else
                BtnGenDutyReport_Click(sender, e);
        }

        private void TxtTimestamp_TextChanged(object sender, EventArgs e)
        {
            if (txtTimestamp.Text.Length == 0)
                return;
            var time = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime().AddSeconds(Convert.ToUInt64(txtTimestamp.Text, enUS));
            dtImpoundTime.Value = time;
        }

        private void TxtRelFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void TxtSuggestCharge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return && e.KeyCode != Keys.Enter)
                return;
            var i = 0;
            foreach (Crime item in chkCrimes.Items)
            {
                if (item.Equals(txtSuggestCharge.Text))
                {
                    chkCrimes.SetItemChecked(i, true);
                    chkCrimes.SelectedIndex = i;
                    return;
                }
                ++i;
            }
        }

        private void ModifyCharge(string extra, bool append = false)
        {
            if (chkCrimes.SelectedIndex == -1)
                return;
            var idx = chkCrimes.SelectedIndex;
            var crime = (Crime)chkCrimes.Items[idx];
            Action<string> func;
            if (append)
            {
                if (crime.Suffix().Contains(extra))
                    func = crime.DelSuffix;
                else
                    func = crime.AddSuffix;
            } else
            {
                if (crime.Prefix().Contains(extra))
                    func = crime.DelPrefix;
                else
                    func = crime.AddPrefix;
            }
            func(extra);
            chkCrimes.Items[idx] = crime;
        }

        private void BtnChargeModifier_Click(object sender, EventArgs e)
        {
            btnDict.TryGetValue(sender, out string str);
            ModifyCharge(str, str[0] == ' ');
        }

        private void TxtSuspPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b';
        }

        private void Suspect_TextChanged(object sender, EventArgs e)
        {
            var txtBox = (TextBox)sender;
            var phone = (TextBox)txtBox.Parent.GetNextControl(txtBox, true);
            if (phone.TextLength != 0)
                return;
            var susp = suspMgr.FindFromName(txtBox.Text);
            if (susp != null)
                phone.Text = susp.Phone;
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            var txtBox = (TextBox)sender;
            var name = (TextBox)txtBox.Parent.GetNextControl(txtBox, false);
            if (name.TextLength != 0)
                return;
            var susp = suspMgr.FindFromPhone(txtBox.Text);
            if (susp != null)
                name.Text = susp.Name;
        }
    }
}
