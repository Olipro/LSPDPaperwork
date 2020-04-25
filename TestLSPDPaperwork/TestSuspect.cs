using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestSuspect
    {
        [TestMethod]
        public void SuspectCorrectlyStoresAndComparesData()
        {
            var susp = new Suspect("SomeName", "1234567");
            Assert.AreEqual("SomeName", susp.Name);
            Assert.AreEqual("1234567", susp.Phone);
            Assert.IsTrue(susp.Equals(susp));
            Assert.IsTrue(susp.Equals(new Suspect("somename", "1234567")));
            Assert.IsFalse(susp.Equals(new Suspect("someName", "1234568")));
            Assert.IsFalse(susp.Equals(new Suspect("SomeNamex", "1234567")));
            Assert.AreEqual("somename".GetHashCode(), susp.GetHashCode());
        }
    }
}
