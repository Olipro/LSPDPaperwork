using System;
using System.IO;
using System.Reflection;

namespace LSPDPaperwork {
    public abstract class VersionedFileData {
        protected static readonly DateTime buildTime = File.GetLastWriteTimeUtc(Assembly.GetExecutingAssembly().Location);

        private void DoFileUpdate(string file, string embeddedData) {
            var fileExists = File.Exists(file);
            if (!fileExists || File.GetLastWriteTimeUtc(file) < buildTime) {
                var parser = fileExists ? new ReportTemplateParser(File.OpenRead(file)) : new ReportTemplateParser(new StringReader(embeddedData));
                var subst = parser.GetAllPrefills();
                parser = new ReportTemplateParser(new StringReader(embeddedData));
                foreach (var i in subst) {
                    var val = i.Value;
                    if ("officers".Equals(i.Key, StringComparison.Ordinal) && val.Length == 0) {
                        val = OfficerData.OfficerName;
                    } else if ("officerSig".Equals(i.Key, StringComparison.Ordinal) && val.Length == 0) {
                        val = OfficerData.OfficerSig;
                    }
                    parser.SetValue(i.Key, "__" + i.Key + ":" + val + "__");
                }
                embeddedData = parser.Parse();
                using (var f = File.Create(file))
                using (var writer = new StreamWriter(f))
                    writer.Write(embeddedData);
                File.SetLastWriteTimeUtc(file, buildTime);
            }
        }

        protected VersionedFileData(params string[] args) {
            for (var i = 0; i < args.Length; i += 2)
                DoFileUpdate(args[i], args[i + 1]);
        }
    }
}
