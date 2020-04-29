using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using LSPDPaperwork;
using LSPDPaperwork.FormControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using static LSPDPaperwork.FormControllers.FirearmLicenseController;
using System;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestFirearmLicenseController {
        private Controls ctrls;
        private Mock<IRejectionList> mockRejList;
        private readonly FakeButton genReport = new FakeButton();

        [TestInitialize]
        public void TestInitialize() {
            ctrls = new Controls {
                Name = new TextBox(),
                PrevDenial = new CheckBox(),
                IsFormB = new CheckBox(),
                LastOffence = new DateTimePicker(),
                DateOfBirth = new DateTimePicker(),
                FormA = new CheckedListBox(),
                FormB = new CheckedListBox(),
                ActiveOffence = new Label(),
                Underage = new Label(),
                NameUnderscored = new Button(),
                GenBkgndChk = new Button(),
                GenReport = genReport,
            };
            mockRejList = new Mock<IRejectionList>();
            ctrls.ActiveOffence.Visible = false;
            ctrls.Underage.Visible = false;
            ctrls.GenReport.Enabled = false;
            ctrls.GenBkgndChk.Enabled = false;
        }

        [TestCleanup]
        public void TestCleanup() {
            FakeReporter.ctorCalls.Clear();
        }

        [TestMethod]
        public void FirearmLicenseControllerCorrectlyGeneratesReport() {
            var formA = new HashSet<IRejection>();
            var formB = new HashSet<IRejection>();
            var tstRej = new Rejection("Code1", "Desc1", "Reason1", RejectionState.REAPPLY);
            formA.Add(tstRej);
            formA.Add(new Rejection("Code2", "Desc2", "Reason2", RejectionState.AMENDIT));
            formB.Add(new Rejection("Code3", "Desc3", "Reason3", RejectionState.FOREVER));
            formB.Add(new Rejection("Code4", "Desc4", "Reason4", RejectionState.TMPCRIM));
            mockRejList.SetupGet(f => f.FormA).Returns(formA);
            mockRejList.SetupGet(f => f.FormB).Returns(formB);
            var ctrlr = new FirearmLicenseController(ctrls, typeof(FakeReporter), typeof(FakeReporter), mockRejList.Object);
            Assert.IsTrue(formA.SetEquals(ctrls.FormA.Items.Cast<IRejection>()));
            Assert.IsTrue(formB.SetEquals(ctrls.FormB.Items.Cast<IRejection>()));

            Assert.IsFalse(ctrls.GenReport.Enabled);
            ctrls.PrevDenial.Checked = true;
            Assert.IsTrue(ctrls.GenReport.Enabled);

            ctrls.LastOffence.Value = DateTime.UtcNow.AddMonths(-1);
            Assert.IsTrue(ctrls.ActiveOffence.Visible);

            ctrls.DateOfBirth.Value = DateTime.UtcNow.AddYears(-20);
            Assert.IsTrue(ctrls.Underage.Visible);

            ctrls.FormA.SetItemChecked(0, true);
            Assert.IsFalse(ctrls.FormB.Enabled);

            ctrls.FormB.SetItemChecked(0, true);
            Assert.IsFalse(ctrls.FormA.Enabled);
            Assert.IsTrue(ctrls.IsFormB.Checked);
            ctrls.FormB.SetItemChecked(0, false);
            ctrls.IsFormB.Checked = false;

            ctrls.FormA.Enabled = true;
            ctrls.Name.Text = "Joe Smith";
            genReport.SimulateMouseUp(MouseButtons.Left);
            Assert.AreEqual(1, FakeReporter.ctorCalls.Count);
            var args = FakeReporter.ctorCalls[0];
            Assert.AreEqual("Joe Smith", args[0] as string);
            Assert.IsFalse((bool)args[1]);
            Assert.AreEqual(ctrls.LastOffence.Value, (DateTime)args[2]);
            var rej = (args[3] as IEnumerable<object>).Cast<IRejection>();
            Assert.AreEqual(1, rej.Count());
            Assert.AreEqual(tstRej, rej.First());
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyResetsControls() {
            var formA = new HashSet<IRejection>();
            var formB = new HashSet<IRejection>();
            var tstRej = new Rejection("Code1", "Desc1", "Reason1", RejectionState.REAPPLY);
            formA.Add(tstRej);
            formA.Add(new Rejection("Code2", "Desc2", "Reason2", RejectionState.AMENDIT));
            formB.Add(new Rejection("Code3", "Desc3", "Reason3", RejectionState.FOREVER));
            formB.Add(new Rejection("Code4", "Desc4", "Reason4", RejectionState.TMPCRIM));
            mockRejList.SetupGet(f => f.FormA).Returns(formA);
            mockRejList.SetupGet(f => f.FormB).Returns(formB);
            var ctrlr = new FirearmLicenseController(ctrls, typeof(FakeReporter), typeof(FakeReporter), mockRejList.Object);

            ctrls.FormA.SetItemChecked(0, true);
            ctrls.FormB.SetItemChecked(1, true);
            ctrls.FormA.Enabled = false;
            ctrls.FormB.Enabled = false;
            ctrls.ActiveOffence.Visible = true;
            ctrls.Underage.Visible = true;
            ctrls.GenBkgndChk.Enabled = true;
            genReport.SimulateMouseUp(MouseButtons.Right);
            Assert.IsFalse(ctrls.FormA.GetItemChecked(0));
            Assert.IsFalse(ctrls.FormB.GetItemChecked(1));
            Assert.IsTrue(ctrls.FormA.Enabled);
            Assert.IsTrue(ctrls.FormB.Enabled);
            Assert.IsFalse(ctrls.ActiveOffence.Visible);
            Assert.IsFalse(ctrls.Underage.Visible);
            Assert.IsFalse(ctrls.GenBkgndChk.Enabled);
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesBackgroundCheck() {
            var formA = new HashSet<IRejection>();
            var formB = new HashSet<IRejection>();
            var tstRej = new Rejection("Code1", "Desc1", "Reason1", RejectionState.REAPPLY);
            formA.Add(tstRej);
            formA.Add(new Rejection("Code2", "Desc2", "Reason2", RejectionState.AMENDIT));
            formB.Add(new Rejection("Code3", "Desc3", "Reason3", RejectionState.FOREVER));
            formB.Add(new Rejection("Code4", "Desc4", "Reason4", RejectionState.TMPCRIM));
            mockRejList.SetupGet(f => f.FormA).Returns(formA);
            mockRejList.SetupGet(f => f.FormB).Returns(formB);
            var ctrlr = new FirearmLicenseController(ctrls, typeof(FakeReporter), typeof(FakeReporter), mockRejList.Object);

            ctrls.Name.Text = "Joe Smithy";
            ctrls.GenBkgndChk.Enabled = true;
            ctrls.GenBkgndChk.PerformClick();
            Assert.AreEqual(1, FakeReporter.ctorCalls.Count);
            Assert.AreEqual(1, FakeReporter.ctorCalls[0].Length);
            Assert.AreEqual("Joe Smithy", FakeReporter.ctorCalls[0][0] as string);
        }

        [TestMethod]
        public void FirearmLicenseControllerCorrectlyCopiesNameWithUnderscore() {
            ctrls.Name.Text = "Peter Jones";
            ctrls.NameUnderscored.PerformClick();
            Assert.AreEqual("Peter_Jones", Clipboard.GetText());
        }
    }
}
