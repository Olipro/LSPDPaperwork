using LSPDPaperwork;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestImpoundReporter
    {
        [TestMethod]
        public void ImpoundReporterCorrectlyGeneratesReport()
        {
            using (var file = File.Create(ImpoundReporter.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("__vehOwner__X__phoneNum__X__license__X__model__X__color__X__details__X__impoundTime__X__location__X__reason__X__officers:XYZ__X__screenshot__");
            var now = DateTime.Now;
            var ir = new ImpoundReporter("A", "B", "C", "D", "E", "F", now, "G", "H", "I", "J");
            Assert.AreEqual("XYZ", ir.GetPrefill());
            var dStr = now.ToString("dd/MM/yyyy HH:mm", ImpoundReporter.enUS);
            Assert.AreEqual("AXBXCXDXEXFX" + dStr + "XGXHXIXJ", ir.GetReport());
        }
    }
}
