using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace LSPDPaperwork
{
    public class ReportTemplateParser : IReportTemplateParser
    {
        private static readonly Regex rgx = new Regex("__([A-z0-9]+):(.+?)__");

        private readonly string template;
        private readonly IDictionary<string, string> vars = new Dictionary<string, string>();
        public ReportTemplateParser(TextReader input)
        {
            Contract.Assert(input != null);
            template = input.ReadToEnd();
            input.Close();
        }

        public ReportTemplateParser(FileStream file) : this(new StreamReader(file))
        {
            Contract.Assert(file != null);
            file.Close();
        }

        public void SetValue(string key, string value)
        {
            vars.Add(key, value);
        }

        public string GetPrefill(string name)
        {
            var prefix = "__" + name + ":";
            var start = template.IndexOf(prefix, StringComparison.Ordinal);
            if (start == -1)
                return "";
            var end = template.IndexOf("__", start + prefix.Length, StringComparison.Ordinal);
            return template.Substring(start + prefix.Length, end - start - prefix.Length);
        }

        public IDictionary<string, string> GetAllPrefills()
        {
            var ret = new Dictionary<string, string>();
            foreach (Match i in rgx.Matches(template))
                ret.Add(i.Groups[1].Value, i.Groups[2].Value);
            return ret;
        }

        public string Parse()
        {
            var ret = new StringBuilder(template);
            foreach (var pair in vars)
            {
                var prefill = "__" + pair.Key + ':';
                var idx = ret.ToString().IndexOf(prefill, StringComparison.Ordinal);
                if (idx != -1)
                {
                    var end = ret.ToString().IndexOf("__", idx + prefill.Length, StringComparison.Ordinal);
                    idx = idx + prefill.Length - 1;
                    ret.Remove(idx, end - idx + 1);
                }
                ret.Replace("__" + pair.Key + "__", pair.Value);
            }
            return ret.ToString();
        }
    }
}
