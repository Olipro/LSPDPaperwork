using LSPDPaperwork;
using System;
using System.Collections.Generic;

namespace TestLSPDPaperwork {
    internal class FakeReporter : IReporter {
        public static List<object[]> ctorCalls = new List<object[]>();

        public FakeReporter() { }
        public FakeReporter(string a,
                            string b,
                            bool c,
                            string[] d,
                            string e,
                            IEnumerable<object> f,
                            string g) => LogArgs(a, b, c, d, e, f, g);
        public FakeReporter(DateTime a,
                            DateTime b,
                            decimal c,
                            decimal d,
                            string e) => LogArgs(a, b, c, d, e);
        public FakeReporter(string a,
                            string b,
                            string c,
                            string d,
                            string e,
                            DateTime f,
                            string g,
                            string h) => LogArgs(a, b, c, d, e, f, g, h);
        public FakeReporter(string a,
                            string b,
                            string c,
                            string d,
                            string e,
                            string f,
                            DateTime g,
                            string h,
                            string i,
                            string j,
                            string k) => LogArgs(a, b, c, d, e, f, g, h, i, j, k);
        public FakeReporter(string a,
                            bool b,
                            DateTime c,
                            IEnumerable<object> d) => LogArgs(a, b, c, d);
        public FakeReporter(string a) => LogArgs(a);
        private static void LogArgs(params object[] args) {
            ctorCalls.Add(args);
        }
        public virtual string GetPrefill() {
            return "Fake prefill";
        }

        public virtual string GetReport() {
            return "Fake report";
        }
    }
}
