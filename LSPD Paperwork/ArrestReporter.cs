using System.Collections.Generic;
using System.IO;

namespace LSPD_Paperwork
{
    public class ArrestReporter : IReporter
    {
        public static readonly string TEMPLATE = "ArrestReport.txt";
        private IReportTemplateParser parser;
        
        public ArrestReporter(string suspect,
                              string phone,
                              bool licensesRevoked,
                              string[] officers,
                              string mugshot,
                              IEnumerable<Crime> crimes,
                              string narrative)
        {
            using (var file = File.OpenRead(TEMPLATE))
                parser = new ReportTemplateParser(file);
            parser.SetValue("suspect", suspect);
            parser.SetValue("phone", phone);
            parser.SetValue("licensesRevoked", licensesRevoked ? "Yes" : "No");
            parser.SetValue("narrative", narrative);
            parser.SetValue("mugshot", mugshot);
            string officersStr = "";
            foreach (var officer in officers)
                officersStr += "[*]" + officer + '\n';
            officersStr = officersStr.TrimEnd(new char[]{ '\n', '\r'});
            parser.SetValue("officers", officersStr);
            string chargesStr = "";
            foreach (Crime crime in crimes)
                chargesStr += "[*]" + crime.ToString() + '\n';
            chargesStr = chargesStr.TrimEnd(new char[]{ '\r', '\n' });
            parser.SetValue("charges", chargesStr);
        }

        public string GetReport()
        {
            return parser.Parse();
        }
    }
}
