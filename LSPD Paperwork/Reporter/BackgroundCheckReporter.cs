using System.IO;

using static LSPDPaperwork.Properties.Resources;

namespace LSPDPaperwork {
    class BackgroundCheckReporter : VersionedFileData, IReporter {
        public const string TEMPLATE = "FLDReqBkgndChk.txt";

        private readonly IReportTemplateParser parser;

        public BackgroundCheckReporter(string applicant)
            : base(TEMPLATE, FLDReqBkgndChk) {
            using (var f = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(f);
            parser.SetValue("applicant", applicant);
        }

        public string GetPrefill() => "";
        public string GetReport() => parser.Parse();
    }
}
