using System.Collections.Generic;
using System.Windows.Forms;

namespace LSPDPaperwork {
    public interface ICrimeList {
        ISet<ICrime> Crimes { get; }
        AutoCompleteStringCollection CrimesAutoCompletion { get; }
    }
}
