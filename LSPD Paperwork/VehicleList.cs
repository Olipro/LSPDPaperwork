using System.IO;
using System.Windows.Forms;

namespace LSPDPaperwork {
    public class VehicleList : VersionedFileData {
        public const string TEMPLATE = "Vehicles.txt";

        public AutoCompleteStringCollection Vehicles { get; } = new AutoCompleteStringCollection();

        public VehicleList() : base(TEMPLATE, Properties.Resources.Vehicles) {
            using (var file = File.OpenRead(TEMPLATE))
            using (var strm = new StreamReader(file)) {
                while (!strm.EndOfStream)
                    Vehicles.Add(strm.ReadLine());
            }
        }
    }
}
