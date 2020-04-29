using System.Collections.Generic;

namespace LSPDPaperwork {
    public interface IRejectionList {
        ISet<IRejection> FormA { get; }
        ISet<IRejection> FormB { get; }
    }
}
