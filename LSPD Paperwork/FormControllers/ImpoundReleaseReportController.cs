using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LSPDPaperwork.FormControllers {
    class ImpoundReleaseReportController : ControllerBase {
        public struct Controls {
            public TextBox SuspName { get; set; }
            public TextBox SuspPhone { get; set; }
            public Control LicensePlate { get; set; }
            public TextBox VehicleModel { get; set; }
            public Control VehicleColor { get; set; }
            public DateTimePicker ImpoundDate { get; set; }
            public Control ImpOfficer { get; set; }
            public Control ReleaseFee { get; set; }
            [NonData]
            public Control BtnGenReleaseReport { get; set; }
        }

        private readonly Controls controls;
        private readonly string replyURL;

        public ImpoundReleaseReportController(Controls controls,
                                              ISuspectManager suspMgr,
                                              Type reporterT,
                                              string replyURL = null)
            : base(suspMgr, controls.SuspName, controls.SuspPhone, reporterT) {
            this.controls = controls;
            this.replyURL = replyURL;

            controls.VehicleModel.AutoCompleteCustomSource = new VehicleList().Vehicles;

            controls.BtnGenReleaseReport.MouseUp += GenReleaseReportMouseUp;
            controls.ReleaseFee.KeyPress += NumericHandler;
        }

        private void GenReleaseReportMouseUp(object _, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right)
                ResetInputs(typeof(Controls), controls);
            else {
                if (controls.ReleaseFee.Text.Length == 0)
                    controls.ReleaseFee.Text = "0";
                GenerateReport(typeof(Controls), controls);
                if (replyURL != null)
                    _ = Process.Start(replyURL);
            }
        }
    }
}
