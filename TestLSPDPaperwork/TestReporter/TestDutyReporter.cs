using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestDutyReporter {
        [TestMethod]
        public void DutyReporterCorrectlyProcessesReportData() {
            using (var file = File.Create(DutyReporter.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("__date__X__dutyHours__X__watchStart__X__arrests__X__citations__X__notes:def__");
            var s = DateTime.Now;
            var e = s.AddHours(4.5);
            var dr = new DutyReporter(s, e, 2, 3, "stuff");
            Assert.AreEqual("def", dr.GetPrefill());
            var date = s.ToString("dd/MM/yyyy", DutyReporter.enUS);
            var dHrs = (e - s).TotalHours.ToString("N2", DutyReporter.enUS);
            var time = s.ToString("hh:mm", DutyReporter.enUS);
            Assert.AreEqual(date + "X" + dHrs + "X" + time + "X" + "2X3Xstuff", dr.GetReport());
        }
    }
}
