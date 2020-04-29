using System;
using System.IO;
using System.Windows.Forms;

namespace LSPDPaperwork {
    public partial class OfficerData : Form {
        public const string DATAFILE = "OfficerData.txt";
        public static string OfficerName { get; private set; }
        public static string OfficerSig { get; private set; }
        public static string OfficerDRs { get; private set; }

        public static bool CheckForData() {
            if (!File.Exists(DATAFILE))
                return false;
            using (var f = File.OpenRead(DATAFILE))
            using (var s = new StreamReader(f)) {
                OfficerName = s.ReadLine();
                OfficerSig = s.ReadLine();
                OfficerDRs = s.ReadLine();
            }
            if (OfficerDRs.Length == 0)
                OfficerDRs = null;
            return true;
        }

        public OfficerData() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            OfficerName = txtOfficerName.Text;
            OfficerSig = txtOfficerSig.Text;
            OfficerDRs = txtOfficerDRs.Text;
            using (var f = File.Create(DATAFILE))
            using (var s = new StreamWriter(f)) {
                s.WriteLine(OfficerName);
                s.WriteLine(OfficerSig);
                s.WriteLine(OfficerDRs);
            }
            Close();
        }
    }
}
