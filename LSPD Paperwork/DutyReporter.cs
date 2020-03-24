using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPD_Paperwork
{
    class DutyReporter : IReporter
    {
        public static readonly string TEMPLATE = "DutyReport.txt";
        private IReportTemplateParser parser;
        public DutyReporter(DateTime start, DateTime end, decimal arrests, decimal citations, string notes)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
            parser.SetValue("date", start.ToString("dd/MM/yyyy"));
            var time = end - start;
            parser.SetValue("dutyHours", time.TotalHours.ToString("N2"));
            parser.SetValue("watchStart", start.ToString("hh:mm"));
            parser.SetValue("arrests", arrests.ToString());
            parser.SetValue("citations", citations.ToString());
            parser.SetValue("notes", notes);
        }

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
