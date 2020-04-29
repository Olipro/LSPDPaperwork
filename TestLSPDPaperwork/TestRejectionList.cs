using System;
using System.IO;
using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestRejectionList {
        [TestMethod]
        public void RejectionListCorrectlyParsesInputTemplate() {
            using (var f = File.Create(RejectionList.TEMPLATE))
            using (var s = new StreamWriter(f))
                s.Write("A__Test__Desc__Msg__1\nB__Test2__Desc2__Msg2__2");
            var rl = new RejectionList();
            Assert.AreEqual(1, rl.FormA.Count);
            Assert.AreEqual(1, rl.FormB.Count);

            var e = rl.FormA.GetEnumerator();
            Assert.IsTrue(e.MoveNext());
            Assert.AreEqual("Test", e.Current.Code);
            Assert.AreEqual("Desc", e.Current.Desc);
            Assert.AreEqual("Msg", e.Current.Reason);
            Assert.AreEqual(RejectionState.REAPPLY, e.Current.Type);

            e = rl.FormB.GetEnumerator();
            Assert.IsTrue(e.MoveNext());
            Assert.AreEqual("Test2", e.Current.Code);
            Assert.AreEqual("Desc2", e.Current.Desc);
            Assert.AreEqual("Msg2", e.Current.Reason);
            Assert.AreEqual(RejectionState.TMPCRIM, e.Current.Type);
        }
    }
}
