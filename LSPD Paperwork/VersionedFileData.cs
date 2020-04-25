using System;
using System.IO;
using System.Reflection;

namespace LSPDPaperwork
{
    public abstract class VersionedFileData
    {
        protected static readonly DateTime buildTime = File.GetLastWriteTimeUtc(Assembly.GetExecutingAssembly().Location);

        protected VersionedFileData(string file, string embeddedData)
        {
            var fileExists = File.Exists(file);
            if (!fileExists || File.GetLastWriteTimeUtc(file) < buildTime)
            {
                if (fileExists)
                {
                    var parser = new ReportTemplateParser(File.OpenRead(file));
                    var subst = parser.GetAllPrefills();
                    parser = new ReportTemplateParser(new StringReader(embeddedData));
                    foreach (var i in subst)
                        parser.SetValue(i.Key, "__" + i.Key + ":" + i.Value + "__");
                    embeddedData = parser.Parse();
                }
                using (var f = File.Create(file))
                using (var writer = new StreamWriter(f))
                    writer.Write(embeddedData);
                File.SetLastWriteTimeUtc(file, buildTime);
            }
        }
    }
}
