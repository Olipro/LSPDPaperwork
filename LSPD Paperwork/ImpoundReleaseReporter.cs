using System;
using System.IO;

namespace LSPD_Paperwork
{
    class ImpoundReleaseReporter : IReporter
    {
        public static readonly string TEMPLATE = "ImpoundRelease.txt";
        private IReportTemplateParser parser;
        public ImpoundReleaseReporter(string vehOwner,
                                      string phoneNum,
                                      string license,
                                      string vehModel,
                                      string vehColor,
                                      DateTime impoundDate,
                                      string impOfficer,
                                      string fee)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
            if (fee.Equals("0"))
                fee += " (Secure Impound)";
            parser.SetValue("vehOwner", vehOwner);
            parser.SetValue("phoneNum", phoneNum);
            parser.SetValue("license", license);
            parser.SetValue("vehModel", vehModel);
            parser.SetValue("vehColor", vehColor);
            parser.SetValue("impoundDate", impoundDate.ToString("dd/MM/yyyy"));
            parser.SetValue("impOfficer", impOfficer);
            parser.SetValue("fee", "$" + fee);
        }

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
