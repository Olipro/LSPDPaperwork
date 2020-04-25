using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestArrestReporter
    {
        [TestInitialize]
        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(ArrestReporter.TEMPLATE))
                File.Delete(ArrestReporter.TEMPLATE);
        }

        [TestMethod]
        public void ArrestReporterSuccessfullyProcessesData()
        {
            using (var file = File.OpenWrite(ArrestReporter.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("A __suspect__ w __phone__ x __licensesRevoked__ 4 __narrative__ 7 __mugshot__ 8 __officers:somedata__ 9 __charges__");
            var reporter = new ArrestReporter("1", "2", true, new string[] { "3", "4" }, "5", new List<Crime>() { new Crime(";", ":") }, "yes");
            File.Delete(ArrestReporter.TEMPLATE);
            Assert.AreEqual("A 1 w 2 x Yes 4 yes 7 5 8 [*]3\n[*]4 9 [*]; - :", reporter.GetReport());
            Assert.AreEqual("somedata", reporter.GetPrefill());
        }
    }
}
