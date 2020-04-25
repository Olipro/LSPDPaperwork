using LSPDPaperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace TestLSPDPaperwork
{
    [TestClass]
    public class TestReportTemplateParser
    {
        [TestMethod]
        public void ReportTemplateParserCorrectlySubstitutesVariables()
        {
            var parser = new ReportTemplateParser(new StringReader("Hello __name__, you are __this__"));
            parser.SetValue("name", "john");
            parser.SetValue("this", "here");
            Assert.IsTrue("Hello john, you are here".Equals(parser.Parse()));
        }

        [TestMethod]
        public void ReportTemplateParserCorrectlyExtractsPrefilledInputAndReplacesIt()
        {
            var parser = new ReportTemplateParser(new StringReader("Hello__ThisIsALongVariable__ __name:This is prefill__"));
            var prefill = parser.GetPrefill("name");
            Assert.AreEqual("This is prefill", prefill);
            parser.SetValue("ThisIsALongVariable", "asdf");
            parser.SetValue("name", prefill + ".");
            Assert.AreEqual("Helloasdf This is prefill.", parser.Parse());
        }

        [TestMethod]
        public void ReportTemplateParserFindsAllPrefilledVars()
        {
            var parser = new ReportTemplateParser(new StringReader("Hello __var__, __pre:filled____pre2:filled2__"));
            var prefilled = parser.GetAllPrefills();
            Assert.AreEqual(2, prefilled.Count);
            Assert.AreEqual("filled", prefilled["pre"]);
            Assert.AreEqual("filled2", prefilled["pre2"]);
        }

        [TestMethod]
        public void GetPrefillReturnsEmptyStringIfVarNotFound()
        {
            var parser = new ReportTemplateParser(new StringReader("__var__X__var2:tst__"));
            Assert.AreEqual("", parser.GetPrefill("var"));
            Assert.AreEqual("tst", parser.GetPrefill("var2"));
        }
    }
}
