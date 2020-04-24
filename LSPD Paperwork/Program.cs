using System;
using System.Windows.Forms;

namespace LSPDPaperwork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var form = new LSPDPMainForm())
                Application.Run(form);
        }
    }
}
