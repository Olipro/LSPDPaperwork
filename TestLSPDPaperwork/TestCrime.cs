using System;
using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestCrime
    {
        [TestMethod]
        public void PrefixesAndSuffixesAreCorrectlyHandled()
        {
            var c = new Crime("AB12", "SomeDesc");
            c.AddPrefix("Prefix");
            Assert.AreEqual("AB12 - PrefixSomeDesc", c.ToString());
            c.AddSuffix("Suffix");
            Assert.AreEqual("AB12 - PrefixSomeDescSuffix", c.ToString());
            Assert.AreEqual("SomeDesc", c.Description);
            Assert.AreEqual("AB12", c.Code);
            Assert.AreEqual("Prefix", c.Prefix);
            Assert.AreEqual("Suffix", c.Suffix);
            c.AddSuffix("More");
            c.AddPrefix("More1");
            Assert.AreEqual("AB12 - More1PrefixSomeDescSuffixMore", c.ToString());
            c.DelPrefix("Prefix");
            c.DelSuffix("Suffix");
            Assert.AreEqual("AB12 - More1SomeDescMore", c.ToString());
            c.Reset();
            Assert.AreEqual("AB12 - SomeDesc", c.ToString());
        }

        [TestMethod]
        public void EqualityComparisonsAreCorrectlyHandled()
        {
            var c = new Crime("BA45", "AnotherDesc");
            Assert.IsTrue(c.Equals("AnotherDesc"));
            Assert.IsTrue(c.Equals(new Crime("BA45", "DifferentDesc")));
            Assert.IsTrue(c.Equals(c));
            Assert.IsFalse(c.Equals(new object()));
            Assert.IsFalse(c.Equals(new Crime("BA46", "AnotherDesc")));
            Assert.AreEqual(c.GetHashCode(), "BA45".GetHashCode());
        }
    }
}
