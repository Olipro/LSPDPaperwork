using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace LSPDPaperwork.FormControllers {
    class ImpoundReportController : ControllerBase {
        public struct Controls {
            public TextBox SuspName { get; set; }
            public TextBox SuspPhone { get; set; }
            public Control LicensePlate { get; set; }
            public TextBox VehicleModel { get; set; }
            public Control VehicleColor { get; set; }
            public Control VehicleDetails { get; set; }
            public DateTimePicker ImpoundTime { get; set; }
            public Control Location { get; set; }
            [SingleString]
            public TextBox Reason { get; set; }
            [SingleString]
            public TextBox Officers { get; set; }
            public Control Screenshot { get; set; }
            [NonData]
            public Control TimestampConverter { get; set; }
            [NonData]
            public Control BtnGenImpoundReport { get; set; }
        }

        private readonly Controls controls;
        private readonly Func<IReporter> reporter;
        private readonly string replyURL;

        public ImpoundReportController(Controls controls,
                                       ISuspectManager suspMgr,
                                       Func<IReporter> reporter,
                                       Type reporterT,
                                       string replyURL = null)
            : base(suspMgr, controls.SuspName, controls.SuspPhone, reporterT) {
            this.controls = controls;
            this.reporter = reporter;
            this.replyURL = replyURL;

            controls.Officers.Text = reporter().GetPrefill();

            controls.VehicleModel.AutoCompleteCustomSource = new VehicleList().Vehicles;

            controls.BtnGenImpoundReport.MouseUp += GenImpoundReportMouseUp;
            controls.TimestampConverter.TextChanged += TimestampTextChanged;
        }

        private void GenImpoundReportMouseUp(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                ResetInputs(typeof(Controls), controls);
                controls.Officers.Text = reporter().GetPrefill();
            } else {
                controls.SuspName.Text = enUS.TextInfo.ToTitleCase(controls.SuspName.Text);
                controls.Officers.Text = enUS.TextInfo.ToTitleCase(controls.Officers.Text);
                controls.LicensePlate.Text = controls.LicensePlate.Text.ToUpper(enUS);
                GenerateReport(typeof(Controls), controls);
                if (replyURL != null)
                    _ = Process.Start(replyURL);
            }
        }

        private void TimestampTextChanged(object _, EventArgs __) {
            var tsConv = controls.TimestampConverter.Text;
            if (tsConv.Length == 0)
                return;
            var time = new DateTime(1970, 1, 1, 0, 0, 0).ToUniversalTime().AddSeconds(Convert.ToUInt64(tsConv, enUS));
            controls.ImpoundTime.Value = time;
        }

        protected override void URIReceived(string data) {
            controls.Screenshot.Text = data;
        }
    }
}
