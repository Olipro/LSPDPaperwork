using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestCrimeList
    {
        [TestMethod]
        public void ListOfCrimesAreCorrectlyHandled()
        {
            using (var file = File.Create(CrimeList.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("AB01__Test1\nAB02__Test2\nAB03__Test3");
            var cl = new CrimeList();
            var e = cl.Crimes.GetEnumerator();
            Assert.IsTrue(e.MoveNext());
            Assert.AreEqual("AB01 - Test1", e.Current.ToString());
            Assert.IsTrue(e.MoveNext());
            Assert.AreEqual("AB02 - Test2", e.Current.ToString());
            Assert.IsTrue(e.MoveNext());
            Assert.AreEqual("AB03 - Test3", e.Current.ToString());
            Assert.IsFalse(e.MoveNext());
            var a = cl.CrimesAutoCompletion;
            Assert.AreEqual(6, a.Count);
            Assert.AreEqual("Test1", a[0]);
            Assert.AreEqual("AB01 - Test1", a[1]);
        }
    }
}
