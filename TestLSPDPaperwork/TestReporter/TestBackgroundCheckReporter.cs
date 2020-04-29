using System;
using System.IO;
using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestBackgroundCheckReporter {
        [TestMethod]
        public void BackgroundCheckReporterCorrectlyGeneratesReport() {
            using (var f = File.Create(BackgroundCheckReporter.TEMPLATE))
            using (var s = new StreamWriter(f))
                s.Write("Test__applicant__ data");
            IReporter bcr = new BackgroundCheckReporter("Some Guy");
            Assert.AreEqual("", bcr.GetPrefill());
            Assert.AreEqual("TestSome Guy data", bcr.GetReport());
        }
    }
}
