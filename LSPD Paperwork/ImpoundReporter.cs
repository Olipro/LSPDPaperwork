using System;
using System.Globalization;
using System.IO;

namespace LSPDPaperwork
{
    class ImpoundReporter : VersionedFileData, IReporter
    {
        public const string TEMPLATE = "ImpoundReport.txt";
        private static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");

        private readonly IReportTemplateParser parser;

        public ImpoundReporter() : base(TEMPLATE, Properties.Resources.ImpoundReport)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
        }

        public ImpoundReporter(string vehOwner,
                               string phoneNum,
                               string license,
                               string model,
                               string color,
                               string details,
                               DateTime impoundTime,
                               string location,
                               string reason,
                               string officers,
                               string screenshot) : this()
        {
            parser.SetValue("vehOwner", vehOwner);
            parser.SetValue("phoneNum", phoneNum);
            parser.SetValue("license", license);
            parser.SetValue("model", model);
            parser.SetValue("color", color);
            parser.SetValue("details", details);
            parser.SetValue("impoundTime", impoundTime.ToString("dd/MM/yyyy HH:mm", enUS));
            parser.SetValue("location", location);
            parser.SetValue("reason", reason);
            parser.SetValue("officers", officers);
            parser.SetValue("screenshot", screenshot);
        }

        public string GetPrefill()
        {
            return parser.GetPrefill("officers");
        }

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
