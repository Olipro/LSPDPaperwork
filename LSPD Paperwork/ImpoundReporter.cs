using System;
using System.IO;

namespace LSPD_Paperwork
{
    class ImpoundReporter : IReporter
    {
        public static readonly string TEMPLATE = "ImpoundReport.txt";
        private IReportTemplateParser parser;
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
                               string screenshot)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
            parser.SetValue("vehOwner", vehOwner);
            parser.SetValue("phoneNum", phoneNum);
            parser.SetValue("license", license);
            parser.SetValue("model", model);
            parser.SetValue("color", color);
            parser.SetValue("details", details);
            parser.SetValue("impoundTime", impoundTime.ToString("dd/MM/yyyy HH:mm"));
            parser.SetValue("location", location);
            parser.SetValue("reason", reason);
            parser.SetValue("officers", officers);
            parser.SetValue("screenshot", screenshot);
        }

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
