using System;

namespace LSPDPaperwork
{
    public class Crime
    {
        public Crime(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public void AddPrefix(string prefix)
        {
            Prefix = prefix + Prefix;
        }

        public void DelPrefix(string prefix)
        {
            Prefix = Prefix.Replace(prefix, "");
        }

        public void AddSuffix(string suffix)
        {
            Suffix += suffix;
        }

        public void DelSuffix(string suffix)
        {
            Suffix = this.Suffix.Replace(suffix, "");
        }

        public override string ToString()
        {
            return Code + " - " + Prefix + Description + Suffix;
        }

        public string Code { get; }

        public string Description { get; }

        public string Prefix { get; private set; } = "";

        public string Suffix { get; private set; } = "";

        public bool Equals(string desc)
        {
            return Description.Equals(desc, StringComparison.OrdinalIgnoreCase) || ToString().Equals(desc, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            return obj is Crime c && (this == c || Code.Equals(c.Code, StringComparison.Ordinal));
        }

        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        public void Reset()
        {
            Prefix = "";
            Suffix = "";
        }
    }
}
