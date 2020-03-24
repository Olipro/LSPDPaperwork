using System.Collections.Generic;
using System.IO;

namespace LSPD_Paperwork
{
    public class ReportTemplateParser : IReportTemplateParser
    {
        string template;
        IDictionary<string, string> vars = new Dictionary<string, string>();
        public ReportTemplateParser(TextReader input)
        {
            template = input.ReadToEnd();
            input.Close();
        }

        public ReportTemplateParser(FileStream file) : this(new StreamReader(file))
        {
            file.Close();
        }

        public void SetValue(string key, string value)
        {
            vars.Add(key, value);
        }

        public string Parse()
        {
            string ret = template;
            foreach (var pair in vars)
            {
                ret = ret.Replace("__" + pair.Key + "__", pair.Value);
            }
            return ret;
        }
    }
}
