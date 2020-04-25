using LSPDPaperwork;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestVehicleList
    {
        [TestMethod]
        public void VehicleListIsCorrectlyPopulated()
        {
            using (var file = File.Create(VehicleList.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("VehA\nVehB\nVehC\n");
            var vh = new VehicleList().Vehicles;
            Assert.AreEqual(3, vh.Count);
            Assert.AreEqual("VehA", vh[0]);
            Assert.AreEqual("VehB", vh[1]);
            Assert.AreEqual("VehC", vh[2]);
        }
    }
}
