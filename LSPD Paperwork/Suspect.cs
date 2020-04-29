using System;
using System.Globalization;

namespace LSPDPaperwork {
    public class Suspect {
        private static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");
        public Suspect(string name, string phone) {
            Name = name;
            Phone = phone;
        }

        public string Name { get; }
        public string Phone { get; set; }

        public override string ToString() {
            return Name + "__" + Phone;
        }

        public override bool Equals(object obj) {
            return obj is Suspect s &&
                (this == s ||
                (Name.Equals(s.Name, StringComparison.OrdinalIgnoreCase) &&
                 Phone.Equals(s.Phone, StringComparison.Ordinal)));
        }

        public override int GetHashCode() {
            return Name.ToLower(enUS).GetHashCode();
        }
    }
}
