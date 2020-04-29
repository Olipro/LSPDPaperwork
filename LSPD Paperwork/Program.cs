using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[assembly: InternalsVisibleTo("TestLSPDPaperwork")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace LSPDPaperwork {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!OfficerData.CheckForData())
                using (var form = new OfficerData())
                    Application.Run(form);
            using (var form = new LSPDPMainForm())
                Application.Run(form);
        }
    }
}
