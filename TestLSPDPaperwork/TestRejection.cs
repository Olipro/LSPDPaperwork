using System;
using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork {
    [TestClass]
    public class TestRejection {
        [TestMethod]
        public void RejectionCorrectlyConstructsFromInputData() {
            var rej = new Rejection("Code", "desc", "rsn", (int)RejectionState.FOREVER);
            Assert.AreEqual("Code", rej.Code);
            Assert.AreEqual("desc", rej.Desc);
            Assert.AreEqual("rsn", rej.Reason);
            Assert.AreEqual(RejectionState.FOREVER, rej.Type);
            Assert.AreEqual("Codedesc".GetHashCode(), rej.GetHashCode());
            Assert.AreEqual("Code - desc", rej.ToString());
            Assert.IsTrue(rej.Equals(rej));
            Assert.IsTrue(rej.Equals(new Rejection("Code", "desc", "a", 0)));
            Assert.IsFalse(rej.Equals(this));
            Assert.IsFalse(rej.Equals(new Rejection("code", "desc", "2", 0)));
            Assert.IsFalse(rej.Equals(new Rejection("Code", "Desc", "2", 0)));
        }
    }
}
