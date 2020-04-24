using System.IO;
using System.Windows.Forms;

namespace LSPDPaperwork
{
    class VehicleList : VersionedFileData
    {
        public const string TEMPLATE = "Vehicles.txt";
        private AutoCompleteStringCollection vehicles = new AutoCompleteStringCollection();
        public VehicleList() : base(TEMPLATE, Properties.Resources.Vehicles)
        {
            using (var file = File.OpenRead(TEMPLATE))
            using (var strm = new StreamReader(file)) {
                while (!strm.EndOfStream)
                    vehicles.Add(strm.ReadLine());
            }
        }

        public AutoCompleteStringCollection Vehicles()
        {
            return vehicles;
        }
    }
}
