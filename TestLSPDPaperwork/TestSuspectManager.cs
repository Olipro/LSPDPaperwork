using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestSuspectManager
    {
        [TestCleanup]
        public void Cleanup()
        {
            if (File.Exists(SuspectManager.TEMPLATE))
                File.Delete(SuspectManager.TEMPLATE);
        }

        [TestMethod]
        public void SuspectManagerCorrectlyManagesSuspects()
        {
            using (var file = File.Create(SuspectManager.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("John Smith__1234567\nJane Doe__7654321\nJohn Doe__3455431");
            using (var suspMgr = new SuspectManager())
            {
                Assert.AreEqual(suspMgr.Suspects.Count, 3);
                Assert.AreEqual(suspMgr.SuspNames.Count, 3);
                Assert.AreEqual(suspMgr.SuspPhnes.Count, 3);
                var susp = suspMgr.FindFromName("jane doe");
                Assert.AreEqual(susp.Name, "Jane Doe");
                Assert.AreEqual(susp.Phone, "7654321");
                Assert.AreEqual(susp, suspMgr.FindFromPhone("7654321"));
                var newSusp = new Suspect("Adam Smith", "5555555");
                suspMgr.AddSuspect(newSusp);
                Assert.AreEqual(suspMgr.Suspects.Count, 4);
                Assert.IsTrue(suspMgr.Suspects.Contains(newSusp));
            }
            using (var file = File.OpenRead(SuspectManager.TEMPLATE))
            using (var strm = new StreamReader(file))
            {
                var str = strm.ReadToEnd();
                Assert.IsTrue(str.Contains("John Smith__1234567"));
                Assert.IsTrue(str.Contains("Jane Doe__7654321"));
                Assert.IsTrue(str.Contains("John Doe__3455431"));
                Assert.IsTrue(str.Contains("Adam Smith__5555555"));
            }
        }

        [TestMethod]
        public void SuspectManagerCorrectlyInitializesFromNoFile()
        {
            Cleanup();
            using (var suspMgr = new SuspectManager())
            {
                Assert.AreEqual(suspMgr.Suspects.Count, 0);
                suspMgr.AddSuspect(new Suspect("John Doe", "1234567"));
                suspMgr.AddSuspect(new Suspect("Jane Doe", "7654321"));
            }
            using (var file = File.OpenRead(SuspectManager.TEMPLATE))
            using (var strm = new StreamReader(file))
            {
                var str = strm.ReadToEnd();
                Assert.IsTrue(str.Contains("John Doe__1234567"));
                Assert.IsTrue(str.Contains("Jane Doe__7654321"));
            }
        }

        [TestMethod]
        public void SuspectManagerCorrectlyDeduplicatesFile()
        {
            using (var file = File.Create(SuspectManager.TEMPLATE))
            using (var strm = new StreamWriter(file))
                strm.Write("John Doe__1234567\nJane Doe__1234567\nAdam Doe__1234123\nAdam Doe__1111111");
            using (var suspMgr = new SuspectManager())
            {
                Assert.AreEqual(suspMgr.Suspects.Count, 2);
                Assert.AreEqual(suspMgr.FindFromName("Jane Doe").Phone, "1234567");
                Assert.IsNull(suspMgr.FindFromName("John Doe"));
                Assert.AreEqual(suspMgr.FindFromName("Adam Doe").Phone, "1111111");
                suspMgr.AddSuspect(new Suspect("Joey Doe", "5555555"));
                Assert.AreEqual(suspMgr.Suspects.Count, 3);
                suspMgr.AddSuspect(new Suspect("Joey Doe", "4444444"));
                Assert.AreEqual(suspMgr.Suspects.Count, 3);
                Assert.AreEqual(suspMgr.SuspNames.Count, 3);
                Assert.AreEqual(suspMgr.SuspPhnes.Count, 3);
                Assert.AreEqual(suspMgr.FindFromName("Joey Doe").Phone, "4444444");
                Assert.AreEqual(suspMgr.FindFromPhone("4444444").Name, "Joey Doe");
                Assert.IsNull(suspMgr.FindFromPhone("5555555"));
            }
            using (var file = File.OpenRead(SuspectManager.TEMPLATE))
            using (var strm = new StreamReader(file))
            {
                var str = strm.ReadToEnd();
                Assert.IsTrue(str.Contains("Jane Doe__1234567"));
                Assert.IsFalse(str.Contains("John Doe"));
                Assert.IsTrue(str.Contains("Adam Doe__1111111"));
                Assert.IsTrue(str.Contains("Joey Doe__4444444"));
                Assert.IsFalse(str.Contains("Joey Doe__5555555"));
            }
        }
    }
}
