using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;

using static LSPDPaperwork.Properties.Resources;

namespace LSPDPaperwork {
    public class ArrestReporter : VersionedFileData, IReporter {
        public const string TEMPLATE = "ArrestReport.txt";
        private readonly IReportTemplateParser parser;

        public ArrestReporter() : base(TEMPLATE, ArrestReport) {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
        }

        public ArrestReporter(string suspect,
                              string phone,
                              bool licensesRevoked,
                              string[] officers,
                              string mugshot,
                              IEnumerable<object> crimes,
                              string narrative) : this() {
            Contract.Requires(officers != null);
            Contract.Requires(crimes != null);

            parser.SetValue("suspect", suspect);
            parser.SetValue("phone", phone);
            parser.SetValue("licensesRevoked", licensesRevoked ? "Yes" : "No");
            parser.SetValue("narrative", narrative);
            parser.SetValue("mugshot", mugshot);
            string officersStr = "";
            foreach (var officer in officers)
                officersStr += "[*]" + officer + '\n';
            officersStr = officersStr.TrimEnd(new char[] { '\n', '\r' });
            parser.SetValue("officers", officersStr);
            string chargesStr = "";
            foreach (Crime crime in crimes)
                chargesStr += "[*]" + crime.ToString() + '\n';
            chargesStr = chargesStr.TrimEnd(new char[] { '\r', '\n' });
            parser.SetValue("charges", chargesStr);
        }

        public string GetPrefill() {
            return parser.GetPrefill("officers");
        }

        public string GetReport() {
            return parser.Parse();
        }
    }
}
