using System;
using System.Collections.Generic;
using System.IO;
using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using static LSPDPaperwork.FirearmLicenseReporter;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestFirearmLicenseReporter {
        private static void PopulateFile(string name, string data) {
            using (var f = File.Create(name))
            using (var s = new StreamWriter(f))
                s.Write(data);
        }
        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesApproval() {
            PopulateFile(APPROVED, "Test __applicant__ data");
            var flr = new FirearmLicenseReporter("John Doe", false, DateTime.Now);
            Assert.AreEqual("Test John Doe data", flr.GetReport());
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesFormBPending() {
            PopulateFile(BKGNDCHK, "Test __applicant__ stuff");
            var flr = new FirearmLicenseReporter("Jane Doe", true, DateTime.Now);
            Assert.AreEqual("Test Jane Doe stuff", flr.GetReport());
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesOnHold() {
            PopulateFile(ISONHOLD, "Testing __applicant__ __reasons__ __date__ data");
            var reasons = new List<IRejection>();
            reasons.Add(new Rejection("Code", "Desc", "Reason", RejectionState.AMENDIT));
            var flr = new FirearmLicenseReporter("Adam Doe", false, DateTime.Now, reasons);
            var time = DateTime.UtcNow.AddHours(48);
            var report = flr.GetReport();
            Assert.AreEqual("Testing Adam Doe [*]Code - Reason" + Environment.NewLine +
                time.ToString(" dd/MM/yyyy HH:mm UTC") +
                " data", report);
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesReapply() {
            PopulateFile(REJECTED, "Test __applicant__ __reasons__ __reapply__ data");
            var reasons = new List<IRejection>();
            reasons.Add(new Rejection("Code2", "Desc2", "Reason2", RejectionState.REAPPLY));
            var time = DateTime.UtcNow.AddHours(72);
            var flr = new FirearmLicenseReporter("Joe Doe", false, DateTime.Now, reasons);
            var str = flr.GetReport();
            Assert.IsTrue(str.StartsWith("Test Joe Doe [*]Code2 - Reason2"));
            Assert.IsTrue(str.Contains(retryMsg.Replace("DATE", time.ToString("dd/MM/yyyy HH:mm UTC"))));
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesTmpCrim() {
            PopulateFile(REJECTED, "Test __applicant__ __reasons__ __reapply__ data");
            var reasons = new List<IRejection>();
            reasons.Add(new Rejection("Code3", "Desc3", "Reason3", RejectionState.TMPCRIM));
            var refPnt = DateTime.UtcNow;
            var time = refPnt.AddMonths(3);
            var flr = new FirearmLicenseReporter("Joe Doe", false, refPnt, reasons);
            var str = flr.GetReport();
            Assert.IsTrue(str.StartsWith("Test Joe Doe [*]Code3 - Reason3"));
            Assert.IsTrue(str.Contains(tempCrim.Replace("DATE", time.ToString("dd/MM/yyyy HH:mm UTC"))));
        }

        [TestMethod]
        public void FirearmLicenseReporterCorrectlyGeneratesBanned() {
            PopulateFile(REJECTED, "Test __applicant__ __reasons__ __reapply__ data");
            var reasons = new List<IRejection>();
            reasons.Add(new Rejection("Code4", "Desc4", "Reason4", RejectionState.FOREVER));
            var time = DateTime.UtcNow.AddHours(72);
            var flr = new FirearmLicenseReporter("Joe Doe", false, DateTime.Now, reasons);
            var str = flr.GetReport();
            Assert.IsTrue(str.StartsWith("Test Joe Doe [*]Code4 - Reason4"));
            Assert.IsTrue(str.Contains(bannedMsg.Replace("DATE", time.ToString("dd/MM/yyyy HH:mm UTC"))));
        }
    }
}
