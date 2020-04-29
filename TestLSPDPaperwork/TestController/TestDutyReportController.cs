using LSPDPaperwork;
using LSPDPaperwork.FormControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Windows.Forms;

using static LSPDPaperwork.FormControllers.DutyReportController;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestDutyReportController {
        Controls ctrls;
        Mock<IReporter> mockReporter;
        readonly FakeButton btnGenDutyReport = new FakeButton();

        [TestInitialize]
        public void TestInitialize() {
            ctrls = new Controls {
                Start = new DateTimePicker(),
                End = new DateTimePicker(),
                Arrests = new NumericUpDown(),
                Citations = new NumericUpDown(),
                Notes = new TextBox(),
                BtnGenDutyReport = btnGenDutyReport,
            };
            ctrls.Notes.Multiline = true;
            mockReporter = new Mock<IReporter>();
        }

        [TestCleanup]
        public void TestCleanup() {
            FakeReporter.ctorCalls.Clear();
        }

        [TestMethod]
        public void DutyReportIsCorrectlyGeneratedAndReset() {
            mockReporter.Setup(f => f.GetPrefill()).Returns("test");
            var now = DateTime.Now;
            ctrls.Start.Value = now;
            ctrls.End.Value = now.AddMinutes(90);
            ctrls.Arrests.Text = "2";
            ctrls.Citations.Text = "4";
            var ctrlr = new DutyReportController(ctrls, () => mockReporter.Object, typeof(FakeReporter));
            ctrls.Notes.Text = "some notes";
            btnGenDutyReport.SimulateMouseUp(MouseButtons.Left);
            Assert.AreEqual(1, FakeReporter.ctorCalls.Count);
            var args = FakeReporter.ctorCalls[0];
            var i = 0;
            Assert.AreEqual(now, (DateTime)args[i++]);
            Assert.AreEqual(now.AddMinutes(90), (DateTime)args[i++]);
            Assert.AreEqual(2, (decimal)args[i++]);
            Assert.AreEqual(4, (decimal)args[i++]);
            Assert.AreEqual("some notes", args[i++] as string);
            btnGenDutyReport.SimulateMouseUp(MouseButtons.Right);
            Assert.AreEqual("test", ctrls.Notes.Text);
            mockReporter.Verify(f => f.GetPrefill());
        }
    }
}
