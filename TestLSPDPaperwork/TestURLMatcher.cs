using LSPDPaperwork;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestURLMatcher
    {
        [TestMethod]
        public void URLMatcherCorrectlyMatchesData()
        {
            using (var file = File.Create("testURL.txt"))
            using (var strm = new StreamWriter(file))
                strm.Write("url.example.com\nabc.example.net");
            var um = new URLMatcher("testURL.txt");
            Assert.IsTrue(um.HasMatchFor("http://url.example.com/i/img.jpg"));
            Assert.IsTrue(um.HasMatchFor("https://abc.example.net/file.png"));
            Assert.IsFalse(um.HasMatchFor("url.example.com/f"));
            Assert.IsFalse(um.HasMatchFor("http://www.google.com/"));
        }
    }
}
