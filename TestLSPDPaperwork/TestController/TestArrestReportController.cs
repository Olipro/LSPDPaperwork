using LSPDPaperwork;
using LSPDPaperwork.FormControllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static LSPDPaperwork.FormControllers.ArrestReportController;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestArrestReportController {
        AutoCompleteStringCollection ac;
        Mock<ISuspectManager> mockSuspMgr;
        CheckedListBox chkCrimes;
        Button btnAccessory;
        Button btnAggravated;
        Button btnGovEmployee;
        FakeButton btnGenArrestReport;
        FakeTextBox suggestCharge;
        Mock<TextBox> officers;
        Controls ctrls;
        readonly Mock<IReporter> mockReporter = new Mock<IReporter>();
        readonly Type rptT = typeof(FakeReporter);
        Mock<ICrimeList> mockCrimeList;
        readonly Mock<ICrime> mockCrime1 = new Mock<ICrime>();
        readonly Mock<ICrime> mockCrime2 = new Mock<ICrime>();
        
        [TestInitialize]
        public void TestInitialize() {
            ac = new AutoCompleteStringCollection();
            mockSuspMgr = new Mock<ISuspectManager>();
            mockSuspMgr.Setup(f => f.SuspNames).Returns(ac);
            mockSuspMgr.Setup(f => f.SuspPhnes).Returns(ac);
            chkCrimes = new CheckedListBox();
            btnAccessory = new Button();
            btnAggravated = new Button();
            btnGovEmployee = new Button();
            btnGenArrestReport = new FakeButton();
            suggestCharge = new FakeTextBox();
            officers = new Mock<TextBox>();
            ctrls = new Controls {
                SuspName = new TextBox(),
                SuspPhone = new TextBox(),
                LicensesRevoked = new CheckBox(),
                ArrestingOfficers = officers.Object,
                Mugshot = new TextBox(),
                ChkCrimes = chkCrimes,
                Narrative = new TextBox(),
                BtnGovEmployee = btnGovEmployee,
                BtnAttempted = new Button(),
                BtnAccessory = btnAccessory,
                BtnAggravated = btnAggravated,
                SuggestCharge = suggestCharge,
                BtnGenArrestReport = btnGenArrestReport,
            };
            mockCrimeList = new Mock<ICrimeList>();
            var crimeList = new HashSet<ICrime> { mockCrime1.Object,
                                                 mockCrime2.Object };
            mockCrimeList.Setup(f => f.Crimes).Returns(crimeList);
        }

        [TestCleanup]
        public void TestCleanup() {
            FakeReporter.ctorCalls.Clear();
        }

        [TestMethod]
        public void ControllerSuccessfullyGeneratesAnArrestReport() {
            string[] strs = new string[] { "", "", "", "" };
            mockCrime1.SetupGet(f => f.Prefix).Returns(() => strs[0]);
            mockCrime1.SetupGet(f => f.Suffix).Returns(() => strs[1]);
            var ctrlr = new ArrestReportController(ctrls, mockSuspMgr.Object, () => mockReporter.Object, rptT, mockCrimeList.Object);
            chkCrimes.SetItemChecked(0, true);
            chkCrimes.SelectedIndex = 0;
            mockCrime1.Setup(f => f.AddSuffix(It.IsAny<string>())).Callback((string s) => strs[1] = s);
            mockCrime1.Setup(f => f.AddPrefix("Accessory to ")).Callback((string s) => strs[0] = s);
            for (var i = 0; i < 3; ++i) {
                btnAccessory.PerformClick();
                btnGovEmployee.PerformClick();
            }
            mockCrime1.VerifyAll();

            chkCrimes.SelectedIndex = -1;
            btnAggravated.PerformClick();
            suggestCharge.Text = "Test2";
            mockCrime2.Setup(f => f.Equals(It.IsAny<string>())).Returns(true);
            suggestCharge.SimulateKeyUp(new KeyEventArgs(Keys.A));
            Assert.AreEqual(-1, chkCrimes.SelectedIndex);
            suggestCharge.SimulateKeyUp(new KeyEventArgs(Keys.Enter));
            mockCrime2.VerifyAll();
            Assert.AreEqual(1, chkCrimes.SelectedIndex);
            Assert.IsTrue(chkCrimes.GetItemChecked(1));

            officers.SetupProperty(f => f.Text, "john smith\nJane doe");
            officers.Setup(f => f.Multiline).Returns(true);
            ctrls.SuspName.Text = "some crim";
            ctrls.SuspPhone.Text = "1234567";
            ctrls.LicensesRevoked.Checked = true;
            ctrls.Mugshot.Text = "abcdef";
            ctrls.Narrative.Text = "Narrative";
            btnGenArrestReport.SimulateMouseUp(MouseButtons.Left);
            officers.VerifyAll();
            Assert.AreEqual("John Smith\nJane Doe", officers.Object.Text);
            Assert.AreEqual("Fake report", Clipboard.GetText());
            Assert.AreEqual(1, FakeReporter.ctorCalls.Count);
            var args = FakeReporter.ctorCalls[0];
            Assert.AreEqual(7, args.Length);
            var a = 0;
            Assert.AreEqual("Some Crim", args[a++] as string);
            Assert.AreEqual("1234567", args[a++] as string);
            Assert.IsTrue((bool)args[a++]);
            var offStrs = args[a++] as string[];
            Assert.AreEqual(2, offStrs.Length);
            Assert.AreEqual("John Smith", offStrs[0]);
            Assert.AreEqual("Jane Doe", offStrs[1]);
            Assert.AreEqual("abcdef", args[a++] as string);
            var crimes = (args[a++] as IEnumerable<object>).GetEnumerator();
            crimes.MoveNext();
            Assert.AreEqual(chkCrimes.Items[0] as Crime, crimes.Current as Crime);
            crimes.MoveNext();
            Assert.AreEqual(chkCrimes.Items[1] as Crime, crimes.Current as Crime);
            Assert.AreEqual("Narrative", args[a++] as string);
        }

        [TestMethod]
        public void FieldsAreCorrectlyResetWhenRightClickIsTriggered() {
            var ctrlr = new ArrestReportController(ctrls, mockSuspMgr.Object, () => mockReporter.Object, rptT, mockCrimeList.Object);
            mockReporter.Setup(f => f.GetPrefill()).Returns("SomePrefill");
            officers.SetupProperty(f => f.Text);
            chkCrimes.SetItemChecked(0, true);
            btnGenArrestReport.SimulateMouseUp(MouseButtons.Right);
            mockReporter.VerifyAll();
            Assert.AreEqual("SomePrefill", officers.Object.Text);
            Assert.IsFalse(chkCrimes.GetItemChecked(0));
        }

        [TestMethod]
        public void PhoneNumbersAndNamesAreCorrectlyMatched() {
            var ctrlr = new ArrestReportController(ctrls, mockSuspMgr.Object, () => mockReporter.Object, rptT, mockCrimeList.Object);
            mockSuspMgr.Setup(f => f.FindFromName(It.IsAny<string>())).Returns(new Suspect("", "1234567"));
            ctrls.SuspName.Text = "Test";
            mockSuspMgr.VerifyAll();
            Assert.AreEqual("1234567", ctrls.SuspPhone.Text);
            mockSuspMgr.Setup(f => f.FindFromPhone(It.IsAny<string>())).Returns(new Suspect("Johnny", ""));
            ctrls.SuspName.Text = "";
            ctrls.SuspPhone.Text = "1111111";
            mockSuspMgr.VerifyAll();
            Assert.AreEqual("Johnny", ctrls.SuspName.Text);
        }
    }
}
