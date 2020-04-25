using System;
using System.Globalization;
using System.IO;

namespace LSPDPaperwork
{
    public class DutyReporter : VersionedFileData, IReporter
    {
        public const string TEMPLATE = "DutyReport.txt";
        public static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");
        private readonly IReportTemplateParser parser;

        public DutyReporter() : base(TEMPLATE, Properties.Resources.DutyReport)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
        }
        public DutyReporter(DateTime start,
                            DateTime end,
                            decimal arrests,
                            decimal citations,
                            string notes) : this()
        {
            parser.SetValue("date", start.ToString("dd/MM/yyyy", enUS));
            var time = end - start;
            parser.SetValue("dutyHours", time.TotalHours.ToString("N2", enUS));
            parser.SetValue("watchStart", start.ToString("hh:mm", enUS));
            parser.SetValue("arrests", arrests.ToString(enUS));
            parser.SetValue("citations", citations.ToString(enUS));
            parser.SetValue("notes", notes);
        }

        public string GetPrefill() => parser.GetPrefill("notes");

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
