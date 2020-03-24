using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPD_Paperwork
{
    interface IReportTemplateParser
    {
        void SetValue(string key, string value);

        string Parse();
    }
}
