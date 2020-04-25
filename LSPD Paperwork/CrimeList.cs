using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LSPDPaperwork
{
    public class CrimeList : VersionedFileData
    {
        public const string TEMPLATE = "Crimes.txt";

        public ISet<Crime> Crimes { get; } = new HashSet<Crime>();
        public AutoCompleteStringCollection CrimesAutoCompletion { get; } = new AutoCompleteStringCollection();

        private void AddCrime(string str)
        {
            var data = str.Split(new string[] { "__" }, StringSplitOptions.None);
            var crime = new Crime(data[0], data[1]);
            if (Crimes.Add(crime))
            {
                CrimesAutoCompletion.Add(crime.Description);
                CrimesAutoCompletion.Add(crime.ToString());
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
    }
}
