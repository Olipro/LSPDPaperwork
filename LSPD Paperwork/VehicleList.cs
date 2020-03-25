using System.IO;
using System.Windows.Forms;

namespace LSPD_Paperwork
{
    class VehicleList
    {
        private AutoCompleteStringCollection vehicles = new AutoCompleteStringCollection();
        public VehicleList(Stream file)
        {
            using (file)
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
