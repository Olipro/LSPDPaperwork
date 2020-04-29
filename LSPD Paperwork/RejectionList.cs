using System;
using System.Collections.Generic;
using System.IO;

namespace LSPDPaperwork {
    public class RejectionList : VersionedFileData, IRejectionList {
        public const string TEMPLATE = "Rejections.txt";

        public ISet<IRejection> FormA { get; } = new HashSet<IRejection>();
        public ISet<IRejection> FormB { get; } = new HashSet<IRejection>();

        public RejectionList() : base(TEMPLATE, Properties.Resources.Rejections) {
            using (var file = File.OpenRead(TEMPLATE))
            using (var strm = new StreamReader(file))
                while (!strm.EndOfStream)
                    AddRejection(strm.ReadLine().Split(new string[] { "__" }, StringSplitOptions.None));
        }

        private void AddRejection(string[] elem) {
            var target = elem[0][0] == 'A' ? FormA : FormB;
            target.Add(new Rejection(elem[1], elem[2], elem[3], elem[4][0] - '0'));
        }
    }
}
