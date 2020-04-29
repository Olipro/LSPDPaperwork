using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.IO;
using System.Text;

using static LSPDPaperwork.Properties.Resources;

namespace LSPDPaperwork {
    public class FirearmLicenseReporter : VersionedFileData, IReporter {
        public const string APPROVED = "FLDApproved.txt";
        public const string BKGNDCHK = "FLDBkgndChk.txt";
        public const string ISONHOLD = "FLDIsOnHold.txt";
        public const string REJECTED = "FLDRejected.txt";
        public const string bannedMsg = "You may not apply in the future. ((You may reapply no sooner than DATE on a new character with no criminal record))";
        public const string tempCrim = "You may re-apply no sooner than DATE. Providing you do not commit further crimes";
        public const string retryMsg = "You may re-apply for a Personal Firearm Permit no sooner than DATE";
        public static readonly CultureInfo enUS = CultureInfo.GetCultureInfo("en-US");

        private readonly IReportTemplateParser parser;

        private static IReportTemplateParser DoParser(string file) {
            using (var f = File.OpenRead(file))
                return new ReportTemplateParser(f);
        }

        public FirearmLicenseReporter(string applicant, bool formB, DateTime lastCrime)
            : this(applicant, formB, lastCrime, new List<object>()) { }

        public FirearmLicenseReporter(string applicant,
                                      bool formB,
                                      DateTime lastCrime,
                                      IEnumerable<object> rejections)
            : base(APPROVED, FLDApproved,
                   BKGNDCHK, FLDBkgndChk,
                   ISONHOLD, FLDIsOnHold,
                   REJECTED, FLDRejected) {
            Contract.Requires(rejections != null);
            var worst = (int)RejectionState.NONE;
            var reasons = new StringBuilder();
            foreach (IRejection rej in rejections) {
                worst = Math.Max((int)rej.Type, worst);
                reasons.AppendLine("[*]" + rej.Code + " - " + rej.Reason);
            }
            switch ((RejectionState)worst) {
                case RejectionState.NONE:
                    parser = DoParser(formB ? BKGNDCHK : APPROVED);
                    break;
                case RejectionState.AMENDIT:
                    parser = DoParser(ISONHOLD);
                    var expiry = DateTime.UtcNow.AddHours(48);
                    parser.SetValue("date", expiry.ToString("dd/MM/yyyy HH:mm UTC", enUS));
                    break;
                case RejectionState.REAPPLY:
                    parser = DoParser(REJECTED);
                    expiry = DateTime.Now.AddHours(72).ToUniversalTime();
                    parser.SetValue("reapply", retryMsg.Replace("DATE", expiry.ToString("dd/MM/yyyy HH:mm UTC", enUS)));
                    break;
                case RejectionState.TMPCRIM:
                    parser = DoParser(REJECTED);
                    expiry = lastCrime.AddMonths(3);
                    parser.SetValue("reapply", tempCrim.Replace("DATE", expiry.ToString("dd/MM/yyyy HH:mm UTC", enUS)));
                    break;
                case RejectionState.FOREVER:
                    parser = DoParser(REJECTED);
                    expiry = DateTime.Now.AddHours(72).ToUniversalTime();
                    parser.SetValue("reapply", bannedMsg.Replace("DATE", expiry.ToString("dd/MM/yyyy HH:mm UTC", enUS))); ;
                    break;
            }
            parser.SetValue("reasons", reasons.ToString());
            parser.SetValue("applicant", applicant);
            parser.SetValue("officerSig", parser.GetPrefill("officerSig"));
            parser.SetValue("officers", parser.GetPrefill("officers"));
        }

        public string GetPrefill() => "";

        public string GetReport() => parser.Parse();
    }
}
