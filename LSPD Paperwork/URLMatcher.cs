using System;
using System.Collections.Generic;
using System.IO;

namespace LSPDPaperwork
{
    public class URLMatcher : VersionedFileData
    {
        private readonly ICollection<string> uris = new List<string>();
        public int Count => uris.Count;
        public URLMatcher(string file) : base(file, Properties.Resources.ImgServices)
        {
            using (var f = File.OpenRead(file))
            using (var strm = new StreamReader(f))
            {
                while (!strm.EndOfStream)
                    uris.Add(strm.ReadLine());
            }
        }

        public bool HasMatchFor(string str)
        {
            if (!Uri.TryCreate(str, UriKind.Absolute, out Uri _))
                return false;
            foreach (var needle in uris)
                if (str.Contains(needle))
                    return true;
            return false;
        }
    }
}
