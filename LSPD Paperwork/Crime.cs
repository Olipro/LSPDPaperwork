using System;

namespace LSPD_Paperwork
{
    public class Crime
    {
        private string code;
        private string description;
        private string prefix = "";
        private string suffix = "";

        public Crime(string code, string description)
        {
            this.code = code;
            this.description = description;
        }

        public void AddPrefix(string prefix)
        {
            this.prefix = prefix + this.prefix;
        }

        public void DelPrefix(string prefix)
        {
            this.prefix = this.prefix.Replace(prefix, "");
        }

        public void AddSuffix(string suffix)
        {
            this.suffix += suffix;
        }

        public void DelSuffix(string suffix)
        {
            this.suffix = this.suffix.Replace(suffix, "");
        }

        public override string ToString()
        {
            return code + " - " + prefix + description + suffix;
        }

        public string Description()
        {
            return description;
        }

        public string Prefix()
        {
            return prefix;
        }

        public string Suffix()
        {
            return suffix;
        }

        public bool Equals(string desc)
        {
            return description.Equals(desc, StringComparison.OrdinalIgnoreCase) || ToString().Equals(desc, StringComparison.OrdinalIgnoreCase);
        }

        public void Reset()
        {
            prefix = "";
            suffix = "";
        }
    }
}
