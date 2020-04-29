using System.Collections.Generic;

namespace LSPDPaperwork {
    interface IReportTemplateParser {
        void SetValue(string key, string value);
        string GetPrefill(string name);
        IDictionary<string, string> GetAllPrefills();
        string Parse();
    }
}
