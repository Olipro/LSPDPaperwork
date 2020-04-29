using System.Collections.Generic;
using System.Windows.Forms;

namespace LSPDPaperwork {
    public interface ISuspectManager {
        ICollection<Suspect> Suspects { get; }
        AutoCompleteStringCollection SuspNames { get; }
        AutoCompleteStringCollection SuspPhnes { get; }
        void AddSuspect(Suspect susp);
        Suspect FindFromName(string name);
        Suspect FindFromPhone(string phone);
    }
}
