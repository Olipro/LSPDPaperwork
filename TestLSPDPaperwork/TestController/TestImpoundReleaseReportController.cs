using System;
using System.Windows.Forms;
using LSPDPaperwork;
using LSPDPaperwork.FormControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using static LSPDPaperwork.FormControllers.ImpoundReleaseReportController;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestImpoundReleaseReportController {
        Controls ctrls;
        readonly Mock<ISuspectManager> mockSuspMgr = new Mock<ISuspectManager>();
        readonly FakeButton btnGenReport = new FakeButton();

        [TestInitialize]
        public void TestInitialize() {
            ctrls = new Controls {
                SuspName = new TextBox(),
                SuspPhone = new TextBox(),
                LicensePlate = new TextBox(),
                VehicleModel = new TextBox(),
                VehicleColor = new TextBox(),
                ImpoundDate = new DateTimePicker(),
                ImpOfficer = new TextBox(),
                ReleaseFee = new TextBox(),
                BtnGenReleaseReport = btnGenReport,
            };
        }

        [TestCleanup]
        public void TestCleanup() {
            FakeReporter.ctorCalls.Clear();
        }

        [TestMethod]
        public void ImpoundReleaseReporterCorrectlyGeneratesAndResetsReport() {
            _ = new ImpoundReleaseReportController(ctrls, mockSuspMgr.Object, typeof(FakeReporter));
            ctrls.SuspName.Text = "SN";
            ctrls.SuspPhone.Text = "6666666";
            ctrls.LicensePlate.Text = "ASDF"; 
            ctrls.VehicleModel.Text = "Bifta";
            ctrls.VehicleColor.Text = "Red";
            ctrls.ImpoundDate.Value = new DateTime(2010, 12, 23);
            ctrls.ImpOfficer.Text = "officer";
            ctrls.ReleaseFee.Text = "123";
            btnGenReport.SimulateMouseUp(MouseButtons.Left);
            Assert.AreEqual(1, FakeReporter.ctorCalls.Count);
            var i = 0;
            var args = FakeReporter.ctorCalls[0];
            Assert.AreEqual("SN", args[i++] as string);
            Assert.AreEqual("6666666", args[i++] as string);
            Assert.AreEqual("ASDF", args[i++] as string);
            Assert.AreEqual("Bifta", args[i++] as string);
            Assert.AreEqual("Red", args[i++] as string);
            Assert.AreEqual(new DateTime(2010, 12, 23), (DateTime)args[i++]);
            Assert.AreEqual("officer", args[i++] as string);
            Assert.AreEqual("123", args[i++] as string);

            btnGenReport.SimulateMouseUp(MouseButtons.Right);
            Assert.AreEqual("", ctrls.SuspName.Text);
            Assert.AreEqual("", ctrls.SuspPhone.Text);
            Assert.AreEqual("", ctrls.LicensePlate.Text);
            Assert.AreEqual("", ctrls.ReleaseFee.Text);

            btnGenReport.SimulateMouseUp(MouseButtons.Left);
            Assert.AreEqual("0", FakeReporter.ctorCalls[1][7] as string);
        }
    }
}
