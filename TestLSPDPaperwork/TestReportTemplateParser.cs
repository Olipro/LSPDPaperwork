using System.IO;
using LSPD_Paperwork;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
