using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LSPD_Paperwork
{
    class CrimeList
    {
        private IList<Crime> crimes = new List<Crime>();
        private AutoCompleteStringCollection autoComp = new AutoCompleteStringCollection();

        public CrimeList(Stream input)
        {
            using (input)
            using (var strm = new StreamReader(input))
            {
                while (!strm.EndOfStream)
                {
                    var data = strm.ReadLine().Split(new char[] { '_', '_' });
                    var crime = new Crime(data[0], data[2]);
                    crimes.Add(crime);
                    autoComp.Add(crime.Description());
                    autoComp.Add(crime.ToString());
                }
            }
        }

        public IEnumerable<Crime> Crimes()
        {
            return crimes;
        }

        public AutoCompleteStringCollection CrimesAutoCompletion()
        {
            return autoComp;
        }
    }
}
