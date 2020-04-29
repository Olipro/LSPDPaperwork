using System;

namespace LSPDPaperwork {
    public class Rejection : IRejection {
        public string Code { get; }
        public string Desc { get; }
        public string Reason { get; }
        public RejectionState Type { get; }

        public Rejection(string code, string desc, string reason, int type)
            : this(code, desc, reason, (RejectionState)type) { }

        public Rejection(string code, string desc, string reason, RejectionState type) {
            Code = code;
            Desc = desc;
            Reason = reason;
            Type = type;
        }

        public override int GetHashCode() => (Code + Desc).GetHashCode();

        public override bool Equals(object obj) {
            return obj is Rejection r && r.Code.Equals(Code, StringComparison.Ordinal) && r.Desc.Equals(Desc, StringComparison.Ordinal);
        }

        public override string ToString() => Code + " - " + Desc;
    }
}
