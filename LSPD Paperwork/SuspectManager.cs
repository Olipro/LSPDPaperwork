using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LSPD_Paperwork
{
    class SuspectManager
    {
        private List<Suspect> suspects = new List<Suspect>();
        private Stream dbFile;
        private StreamReader dbRd;

        public SuspectManager(Stream dbFile)
        {
            this.dbFile = dbFile;
            dbRd = new StreamReader(dbFile);
            while (!dbRd.EndOfStream)
            {
                var suspStr = dbRd.ReadLine().Split(new char[] { '_', '_' });
                var susp = new Suspect(suspStr[0], suspStr[2]);
                suspects.Add(susp);
                SuspNames.Add(susp.Name);
                SuspPhnes.Add(susp.Phone);
            }
        }

        public IEnumerable<Suspect> Suspects { get => suspects; }
        public AutoCompleteStringCollection SuspNames { get; } = new AutoCompleteStringCollection();
        public AutoCompleteStringCollection SuspPhnes { get; } = new AutoCompleteStringCollection();

        public void AddSuspect(Suspect suspect)
        {
            if (suspect.Name.Length == 0 || suspect.Phone.Length != 7)
                return;
            var existingSusp = FindFromName(suspect.Name);
            if (existingSusp != null)
            {
                SuspPhnes.Remove(existingSusp.Phone);
                existingSusp.Phone = suspect.Phone;
                SuspPhnes.Add(existingSusp.Phone);
            }
            else
            {
                suspects.Add(suspect);
                SuspNames.Add(suspect.Name);
                SuspPhnes.Add(suspect.Phone);
            }
        }

        public Suspect FindFromName(string name)
        {
            return suspects.Find(susp => susp.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public Suspect FindFromPhone(string phone)
        {
            return suspects.Find(susp => susp.Phone.Equals(phone));
        }

        ~SuspectManager()
        {
            dbFile.SetLength(0);
            dbFile.Seek(0, SeekOrigin.Begin);
            using (var dbWr = new StreamWriter(dbFile))
                foreach (var suspect in suspects)
                    dbWr.WriteLine(suspect);
            dbFile.Close();
        }
    }
}
