using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LSPDPaperwork
{
    class CrimeList : VersionedFileData
    {
        public const string TEMPLATE = "Crimes.txt";
        private readonly ISet<Crime> crimes = new HashSet<Crime>();
        private readonly AutoCompleteStringCollection autoComp = new AutoCompleteStringCollection();

        private void AddCrime(string str)
        {
            var data = str.Split(new string[] { "__" }, StringSplitOptions.None);
            var crime = new Crime(data[0], data[1]);
            if (crimes.Add(crime))
            {
                autoComp.Add(crime.Description());
                autoComp.Add(crime.ToString());
            }
        }

        private void PopulateCrimes(Stream input)
        {
            using (input)
            using (var strm = new StreamReader(input))
                while (!strm.EndOfStream)
                    AddCrime(strm.ReadLine());
        }

        public CrimeList() : base(TEMPLATE, Properties.Resources.Crimes)
        {
            PopulateCrimes(File.OpenRead(TEMPLATE));
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
