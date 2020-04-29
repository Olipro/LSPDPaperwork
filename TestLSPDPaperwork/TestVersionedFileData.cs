using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestVersionedFileData {
        private const string testFile = "testfile.txt";
        private class Dummy : VersionedFileData {
            public Dummy(string file, string data) : base(file, data) { }
            public static DateTime BaseTime() { return buildTime; }
        }

        [TestInitialize]
        [TestCleanup]
        public void Cleanup() {
            if (File.Exists(testFile))
                File.Delete(testFile);
        }

        [TestMethod]
        public void FileIsCorrectlyCreatedIfNotPresent() {
            var d = new Dummy(testFile, "asdfasdf");
            Assert.IsTrue(File.Exists(testFile));
            using (var strm = new StreamReader(testFile))
                Assert.AreEqual("asdfasdf", strm.ReadToEnd());
            Assert.AreEqual(File.GetLastWriteTimeUtc(testFile), Dummy.BaseTime());
        }

        [TestMethod]
        public void ExistingFileDataIsCorrectlyMerged() {
            var old = "some __template:data__ with __var__";
            var New = "a __template:stuff__ with __var__ __more__";

            using (var file = File.Create(testFile))
            using (var strm = new StreamWriter(file))
                strm.Write(old);
            File.SetLastWriteTimeUtc(testFile, Dummy.BaseTime().AddMinutes(-5));
            new Dummy(testFile, New);
            string f;
            using (var strm = new StreamReader(testFile))
                f = strm.ReadToEnd();
            Assert.AreEqual(New.Replace("stuff", "data"), f);
        }
    }
}
