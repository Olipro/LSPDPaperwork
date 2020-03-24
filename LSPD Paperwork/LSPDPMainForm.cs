using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace LSPD_Paperwork
{
    public partial class LSPDPMainForm : Form
    {
        private static readonly string CRIMES_FILE = "Crimes.txt";
        private static readonly string VEHICLES_FILE = "Vehicles.txt";

        private CrimeList crimeList = new CrimeList(File.OpenRead(CRIMES_FILE));
        private Dictionary<object, string> btnDict = new Dictionary<object, string>();
        public LSPDPMainForm()
        {
            InitializeComponent();
            var vehicleList = new VehicleList(File.OpenRead(VEHICLES_FILE));
            txtVehModel.AutoCompleteCustomSource = vehicleList.Vehicles();
            txtRelModel.AutoCompleteCustomSource = vehicleList.Vehicles();

            foreach (var crime in crimeList.Crimes())
                chkCrimes.Items.Add(crime);
            txtSuggestCharge.AutoCompleteCustomSource = crimeList.CrimesAutoCompletion();

            btnDict.Add(btnAttempted, "Attempted ");
            btnDict.Add(btnAccessory, "Accessory to ");
            btnDict.Add(btnAggravated, "Aggravated ");
            btnDict.Add(btnGovEmployee, " Against a Government Employee");
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
                    ((DateTimePicker)ctrl).Value = DateTime.Now;
                }
            }
        }

        private void ReportToClipboard(IReporter reporter)
        {
            Clipboard.SetText(reporter.GetReport());
        }

        private void btnGenImpoundReport_Click(object sender, EventArgs e)
        {
            txtOfficersInvolved.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtOfficersInvolved.Text);
            txtLicensePlate.Text = txtLicensePlate.Text.ToUpper();
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
        }
        private void btnGenReleaseReport_Click(object sender, EventArgs e)
        {
            txtRelOfficer.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtRelOfficer.Text);
            txtRelLicense.Text = txtRelLicense.Text.ToUpper();
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
        }

        private void btnGenArrestReport_Click(object sender, EventArgs e)
        {
            txtArrestingOfficers.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(txtArrestingOfficers.Text);
            ReportToClipboard(new ArrestReporter(txtSuspect.Text,
                                                txtSuspPhone.Text,
                                                chkLicensesRevoked.Checked,
                                                txtArrestingOfficers.Lines,
                                                txtMugshot.Text,
                                                chkCrimes.CheckedItems.Cast<Crime>(),
                                                txtNarrative.Text));
        }

        private void btnGenDutyReport_Click(object sender, EventArgs e)
        {
            ReportToClipboard(new DutyReporter(dtWatchStart.Value, dtWatchEnd.Value, numArrests.Value, numCitations.Value, txtNotes.Text));
        }

        private void btnGenImpoundReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ResetInputs(tabImpoundReport.Controls[0].Controls);
            else
                btnGenImpoundReport_Click(sender, e);
        }

        private void btnGenReleaseReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                ResetInputs(tabImpoundRelease.Controls[0].Controls);
            else
                btnGenReleaseReport_Click(sender, e);
        }

        private void btnGenArrestReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ResetInputs(tabArrestReport.Controls[0].Controls);
                ResetCrimes();
            }
            else
                btnGenArrestReport_Click(sender, e);
        }

        private void btnGenDutyReport_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ResetInputs(tabDutyReport.Controls[0].Controls);
            }
            else
                btnGenDutyReport_Click(sender, e);
        }

        private void txtTimestamp_TextChanged(object sender, EventArgs e)
        {
            if (txtTimestamp.Text.Length == 0)
                return;
            var time = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime().AddSeconds(Convert.ToUInt64(txtTimestamp.Text));
            dtImpoundTime.Value = time;
        }

        private void txtRelFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == '\b');
        }

        private void txtSuggestCharge_KeyUp(object sender, KeyEventArgs e)
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
            if ((append && crime.Suffix().Contains(extra)) || (!append && crime.Prefix().Contains(extra)))
                return;
            if (append)
                crime.AddSuffix(extra);
            else
                crime.AddPrefix(extra);
            chkCrimes.Items[idx] = crime;
        }

        private void btnChargeModifier_Click(object sender, EventArgs e)
        {
            string str;
            btnDict.TryGetValue(sender, out str);
            ModifyCharge(str, str[0] == ' ');
        }

        private void txtSuspPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b';
        }
    }
}
