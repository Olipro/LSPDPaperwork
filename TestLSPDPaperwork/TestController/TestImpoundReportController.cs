using LSPDPaperwork;
using LSPDPaperwork.FormControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Windows.Forms;
using static LSPDPaperwork.FormControllers.ImpoundReportController;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestImpoundReportController {
        [TestClass]
        public class TestImpoundReleaseReportController {
            private Controls ctrls;
            private Mock<ISuspectManager> mockSuspMgr;
            private Mock<IReporter> mockReporter;
            private readonly FakeButton btnGenReport = new FakeButton();

            [TestInitialize]
            public void TestInitialize() {
                ctrls = new Controls {
                    SuspName = new TextBox(),
                    SuspPhone = new TextBox(),
                    LicensePlate = new TextBox(),
                    VehicleModel = new TextBox(),
                    VehicleColor = new TextBox(),
                    VehicleDetails = new TextBox(),
                    ImpoundTime = new DateTimePicker(),
                    Location = new TextBox(),
                    Reason = new TextBox(),
                    Officers = new TextBox(),
                    Screenshot = new TextBox(),
                    TimestampConverter = new TextBox(),
                    BtnGenImpoundReport = btnGenReport,
                };
                ctrls.Reason.Multiline = true;
                ctrls.Officers.Multiline = true;
                mockSuspMgr = new Mock<ISuspectManager>();
                mockReporter = new Mock<IReporter>();
            }

            [TestCleanup]
            public void TestCleanup() {
                FakeReporter.ctorCalls.Clear();
            }

            [TestMethod]
            public void ImpoundReportIsCorrectlyGeneratedAndReset() {
                mockReporter.Setup(f => f.GetPrefill()).Returns("prefill");
                var ctrlr = new ImpoundReportController(ctrls, mockSuspMgr.Object, () => mockReporter.Object, typeof(FakeReporter));
                mockReporter.VerifyAll();
                var now = DateTime.Now;
                ctrls.SuspName.Text = "some crim";
                ctrls.SuspPhone.Text = "3434343";
                ctrls.LicensePlate.Text = "asdgf";
                ctrls.VehicleModel.Text = "Bifta";
                ctrls.VehicleColor.Text = "Blue";
                ctrls.VehicleDetails.Text = "stuff";
                ctrls.ImpoundTime.Value = now;
                ctrls.Location.Text = "loc";
                ctrls.Reason.Text = "rsn";
                ctrls.Officers.Text = "john smith";
                ctrls.Screenshot.Text = "scrn";
                btnGenReport.SimulateMouseUp(MouseButtons.Left);
                Assert.AreEqual(1, FakeReporter.ctorCalls.Count);
                var args = FakeReporter.ctorCalls[0];
                var i = 0;
                Assert.AreEqual("Some Crim", args[i++] as string);
                Assert.AreEqual("3434343", args[i++] as string);
                Assert.AreEqual("ASDGF", args[i++] as string);
                Assert.AreEqual("Bifta", args[i++] as string);
                Assert.AreEqual("Blue", args[i++] as string);
                Assert.AreEqual("stuff", args[i++] as string);
                Assert.AreEqual(now, (DateTime)args[i++]);
                Assert.AreEqual("loc", args[i++] as string);
                Assert.AreEqual("rsn", args[i++] as string);
                Assert.AreEqual("John Smith", args[i++] as string);
                Assert.AreEqual("scrn", args[i++] as string);

                mockReporter.Setup(f => f.GetPrefill()).Returns("prefill");
                btnGenReport.SimulateMouseUp(MouseButtons.Right);
                mockReporter.VerifyAll();
                Assert.AreEqual("prefill", ctrls.Officers.Text);
            }

            [TestMethod]
            public void ImpoundReportTimestampIsCorrectlyConverted() {
                var ctrlr = new ImpoundReportController(ctrls, mockSuspMgr.Object, () => mockReporter.Object, typeof(FakeReporter));
                var now = new DateTime(2020, 8, 23, 7, 15, 24);
                var secs = now - new DateTime(1970, 1, 1, 0, 0, 0, 0).ToUniversalTime();
                ctrls.TimestampConverter.Text = ((long)secs.TotalSeconds).ToString();
                Assert.AreEqual(now, ctrls.ImpoundTime.Value);
                ctrls.TimestampConverter.Text = "";
                Assert.AreEqual(now, ctrls.ImpoundTime.Value);
            }
        }
    }
}
