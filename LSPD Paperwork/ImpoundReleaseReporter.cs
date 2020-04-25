using System;
using System.Globalization;
using System.IO;

namespace LSPDPaperwork
{
    public class ImpoundReleaseReporter : VersionedFileData, IReporter
    {
        public const string TEMPLATE = "ImpoundRelease.txt";
        public static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");
        private readonly IReportTemplateParser parser;
        public ImpoundReleaseReporter(string vehOwner,
                                      string phoneNum,
                                      string license,
                                      string vehModel,
                                      string vehColor,
                                      DateTime impoundDate,
                                      string impOfficer,
                                      string fee) : base(TEMPLATE, Properties.Resources.ImpoundRelease)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
            if (fee.Equals("0", StringComparison.Ordinal))
                fee += " (Secure Impound)";
            parser.SetValue("vehOwner", vehOwner);
            parser.SetValue("phoneNum", phoneNum);
            parser.SetValue("license", license);
            parser.SetValue("vehModel", vehModel);
            parser.SetValue("vehColor", vehColor);
            parser.SetValue("impoundDate", impoundDate.ToString("dd/MM/yyyy", enUS));
            parser.SetValue("impOfficer", impOfficer);
            parser.SetValue("fee", "$" + fee);
        }

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
