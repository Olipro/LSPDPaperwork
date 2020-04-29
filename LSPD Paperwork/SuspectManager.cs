using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LSPDPaperwork {
    public class SuspectManager : IDisposable, ISuspectManager {
        public const string TEMPLATE = "Suspects.txt";
        private static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");

        private readonly ISet<Suspect> suspects = new HashSet<Suspect>();
        private readonly IDictionary<string, Suspect> suspectsByName = new Dictionary<string, Suspect>();
        private readonly IDictionary<string, Suspect> suspectsByPhone = new Dictionary<string, Suspect>();
        private readonly Stream dbFile;

        public SuspectManager() {
            dbFile = File.Open(TEMPLATE, FileMode.OpenOrCreate);
            using (var dbRd = new StreamReader(dbFile, Encoding.UTF8, false, 128, true))
                while (!dbRd.EndOfStream) {
                    var suspStr = dbRd.ReadLine().Split(new string[] { "__" }, StringSplitOptions.None);
                    AddSuspect(new Suspect(suspStr[0], suspStr[1]));
                }
        }

        public ICollection<Suspect> Suspects { get => suspects; }
        public AutoCompleteStringCollection SuspNames { get; } = new AutoCompleteStringCollection();
        public AutoCompleteStringCollection SuspPhnes { get; } = new AutoCompleteStringCollection();

        public void AddSuspect(Suspect susp) {
            Contract.Assert(susp != null);
            if (susp.Name.Length == 0 || susp.Phone.Length != 7)
                return;
            RemoveAllMatching(susp);
            suspects.Add(susp);
            suspectsByName.Add(susp.Name.ToLower(enUS), susp);
            suspectsByPhone.Add(susp.Phone, susp);
            SuspNames.Add(susp.Name);
            SuspPhnes.Add(susp.Phone);
        }

        private void RemoveSuspect(Suspect susp) {
            if (susp != null) {
                suspects.Remove(susp);
                suspectsByName.Remove(susp.Name.ToLower(enUS));
                suspectsByPhone.Remove(susp.Phone);
                SuspNames.Remove(susp.Name);
                SuspPhnes.Remove(susp.Phone);
            }
        }

        private void RemoveAllMatching(Suspect susp) {
            RemoveSuspect(FindFromName(susp.Name));
            RemoveSuspect(FindFromPhone(susp.Phone));
        }

        public Suspect FindFromName(string name) {
            Contract.Assert(name != null);
            suspectsByName.TryGetValue(name.ToLower(enUS), out Suspect ret);
            return ret;
        }

        public Suspect FindFromPhone(string phone) {
            suspectsByPhone.TryGetValue(phone, out Suspect ret);
            return ret;
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            using (dbFile) {
                if (!disposing || !dbFile.CanWrite)
                    return;
                dbFile.SetLength(0);
                dbFile.Seek(0, SeekOrigin.Begin);
                using (var dbWr = new StreamWriter(dbFile))
                    foreach (var suspect in suspects)
                        dbWr.WriteLine(suspect);
            }
        }

        ~SuspectManager() {
            Dispose(false);
        }
    }
}
