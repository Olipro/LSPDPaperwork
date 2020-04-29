using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LSPDPaperwork.FormControllers {
    internal class DutyReportController : ControllerBase {
        internal struct Controls {
            public DateTimePicker Start { get; set; }
            public DateTimePicker End { get; set; }
            public Control Arrests { get; set; }
            public Control Citations { get; set; }
            [SingleString]
            public TextBox Notes { get; set; }
            [NonData]
            public Control BtnGenDutyReport { get; set; }
        }

        private readonly Controls controls;
        private readonly Func<IReporter> reporter;
        private readonly string replyURL;

        public DutyReportController(Controls controls,
                                    Func<IReporter> reporter,
                                    Type reporterT,
                                    string replyURL = null)
            : base(reporterT) {
            this.controls = controls;
            this.reporter = reporter;
            this.replyURL = replyURL;

            controls.Notes.Text = reporter().GetPrefill();

            controls.BtnGenDutyReport.MouseUp += GenDutyReportMouseUp;
        }

        private void GenDutyReportMouseUp(object _, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ResetInputs(typeof(Controls), controls);
                controls.Notes.Text = reporter().GetPrefill();
            } else {
                GenerateReport(typeof(Controls), controls);
                if (replyURL != null)
                    Process.Start(replyURL);
            }
        }
    }
}
