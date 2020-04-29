using System;
using System.Windows.Forms;

namespace LSPDPaperwork.FormControllers {
    internal class FirearmLicenseController : ControllerBase {
        internal struct Controls {
            public TextBox Name { get; set; }
            [NonData]
            public CheckBox PrevDenial { get; set; }
            public CheckBox IsFormB { get; set; }
            public DateTimePicker LastOffence { get; set; }
            [NonData]
            public DateTimePicker DateOfBirth { get; set; }
            public CheckedListBox FormA { get; set; }
            public CheckedListBox FormB { get; set; }
            [NonData]
            public Label ActiveOffence { get; set; }
            [NonData]
            public Label Underage { get; set; }
            [NonData]
            public Button NameUnderscored { get; set; }
            [NonData]
            public Button GenBkgndChk { get; set; }
            [NonData]
            public Button GenReport { get; set; }
        }

        private readonly Controls controls;
        private readonly Type bkgndReporterT;

        internal FirearmLicenseController(Controls controls, 
                                          Type reporterT,
                                          Type bkgndReporterT,
                                          IRejectionList rejList)
            : base(reporterT) {
            this.controls = controls;
            this.bkgndReporterT = bkgndReporterT;

            foreach (var rej in rejList.FormA)
                controls.FormA.Items.Add(rej);
            foreach (var rej in rejList.FormB)
                controls.FormB.Items.Add(rej);

            controls.GenReport.MouseUp += GenReportMouseUp;
            controls.GenBkgndChk.Click += GenBkgndCheckClick;
            controls.NameUnderscored.Click += NameUnderscoredClick;
            controls.LastOffence.ValueChanged += LastOffenceDateChanged;
            controls.DateOfBirth.ValueChanged += DateOfBirthChanged;
            controls.FormA.ItemCheck += FormAItemChecked;
            controls.FormB.ItemCheck += FormBItemChecked;
            controls.PrevDenial.CheckedChanged += PrevDenialChanged;
        }

        private void NameUnderscoredClick(object sender, EventArgs e) {
            Clipboard.SetText(controls.Name.Text.Replace(' ', '_'));
        }

        private void PrevDenialChanged(object sender, EventArgs e) {
            controls.GenReport.Enabled = controls.PrevDenial.Checked;
        }

        private void LastOffenceDateChanged(object sender, EventArgs e) {
            var lastOffence = controls.LastOffence.Value;
            controls.ActiveOffence.Visible = lastOffence.AddMonths(3) > DateTime.UtcNow;
        }

        private void DateOfBirthChanged(object sender, EventArgs e) {
            var dob = controls.DateOfBirth.Value;
            controls.Underage.Visible = dob.AddYears(21) > DateTime.UtcNow;
        }

        private void FormAItemChecked(object sender, ItemCheckEventArgs e) {
            controls.FormB.Enabled = false;
        }

        private void FormBItemChecked(object sender, ItemCheckEventArgs e) {
            controls.FormA.Enabled = false;
            controls.IsFormB.Checked = true;
        }

        private void GenReportMouseUp(object _, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ResetInputs(typeof(Controls), controls);
                foreach (int i in controls.FormA.CheckedIndices)
                    controls.FormA.SetItemChecked(i, false);
                foreach (int i in controls.FormB.CheckedIndices)
                    controls.FormB.SetItemChecked(i, false);
                controls.FormA.Enabled = true;
                controls.FormB.Enabled = true;
                controls.ActiveOffence.Visible = false;
                controls.Underage.Visible = false;
                controls.GenBkgndChk.Enabled = false;
            } else {
                GenerateReport(typeof(Controls), controls);
                controls.GenBkgndChk.Enabled = true;
            }
        }

        private void GenBkgndCheckClick(object _, EventArgs e) {
            var data = new { name = controls.Name };
            GenerateReport(data.GetType(), data, bkgndReporterT);
        }
    }
}
