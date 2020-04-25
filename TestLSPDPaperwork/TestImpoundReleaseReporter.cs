using LSPDPaperwork;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestImpoundReleaseReporter
    {
        [TestMethod]
        public void ImpoundReleaseReporterCorrectlyGeneratesReport()
        {
            using (var file = File.Create(ImpoundReleaseReporter.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("__vehOwner__X__phoneNum__X__license__X__vehModel__X__vehColor__X__impoundDate__X__impOfficer__X__fee__");
            var now = DateTime.Now;
            var irr = new ImpoundReleaseReporter("A", "B", "C", "D", "E", now, "F", "55");
            var dStr = now.ToString("dd/MM/yyyy", ImpoundReleaseReporter.enUS);
            Assert.AreEqual("AXBXCXDXEX" + dStr + "XFX$55", irr.GetReport());
            irr = new ImpoundReleaseReporter("A", "B", "C", "D", "E", now, "F", "0");
            Assert.AreEqual("AXBXCXDXEX" + dStr + "XFX$0 (Secure Impound)", irr.GetReport());
        }
    }
}
