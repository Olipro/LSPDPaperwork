using LSPDPaperwork.FormControllers;
using System.Windows.Forms;

namespace LSPDPaperwork {
    public partial class LSPDPMainForm : Form {
        private readonly SuspectManager suspMgr = new SuspectManager();
        private readonly CrimeList crimeList = new CrimeList();
        private readonly RejectionList rejList = new RejectionList();
        public LSPDPMainForm() {
            InitializeComponent();

            var arcControl = new ArrestReportController.Controls {
                SuspName = txtSuspect,
                SuspPhone = txtSuspPhone,
                LicensesRevoked = chkLicensesRevoked,
                ArrestingOfficers = txtArrestingOfficers,
                Mugshot = txtMugshot,
                ChkCrimes = chkCrimes,
                Narrative = txtNarrative,
                BtnGovEmployee = btnGovEmployee,
                BtnAttempted = btnAttempted,
                BtnAccessory = btnAccessory,
                BtnAggravated = btnAggravated,
                SuggestCharge = txtSuggestCharge,
                BtnGenArrestReport = btnGenArrestReport,
            };
            _ = new ArrestReportController(arcControl, suspMgr,
                                           () => new ArrestReporter(),
                                           typeof(ArrestReporter),
                                           crimeList,
                                           "https://gov.eclipse-rp.net/posting.php?mode=reply&f=159&t=19");

            var ircControl = new ImpoundReportController.Controls {
                SuspName = txtVehOwner,
                SuspPhone = txtPhoneNumber,
                LicensePlate = txtLicensePlate,
                VehicleModel = txtVehModel,
                VehicleColor = txtVehColour,
                VehicleDetails = txtVehDetails,
                ImpoundTime = dtImpoundTime,
                Location = txtImpoundLocation,
                Reason = txtReason,
                Officers = txtOfficersInvolved,
                Screenshot = txtScreenshot,
                TimestampConverter = txtTimestamp,
                BtnGenImpoundReport = btnGenImpoundReport,
            };
            _ = new ImpoundReportController(ircControl,
                                            suspMgr,
                                            () => new ImpoundReporter(),
                                            typeof(ImpoundReporter),
                                            "https://gov.eclipse-rp.net/posting.php?mode=reply&f=565&t=7636");

            var irrcControl = new ImpoundReleaseReportController.Controls {
                SuspName = txtRelVehOwner,
                SuspPhone = txtRelPhoneNum,
                LicensePlate = txtRelLicense,
                VehicleModel = txtRelModel,
                VehicleColor = txtRelColour,
                ImpoundDate = txtRelDate,
                ImpOfficer = txtRelOfficer,
                ReleaseFee = txtRelFee,
                BtnGenReleaseReport = btnGenReleaseReport,
            };
            _ = new ImpoundReleaseReportController(irrcControl,
                                                   suspMgr,
                                                   typeof(ImpoundReleaseReporter),
                                                   "https://gov.eclipse-rp.net/posting.php?mode=reply&f=565&t=7641");

            var drcControl = new DutyReportController.Controls {
                Start = dtWatchStart,
                End = dtWatchEnd,
                Arrests = numArrests,
                Citations = numCitations,
                Notes = txtNotes,
                BtnGenDutyReport = btnGenDutyReport,
            };
            _ = new DutyReportController(drcControl,
                                         () => new DutyReporter(),
                                         typeof(DutyReporter),
                                         OfficerData.OfficerDRs);

            var flControl = new FirearmLicenseController.Controls {
                Name = txtApplicant,
                PrevDenial = chkDeniedBefore,
                IsFormB = chkIsFormB,
                LastOffence = dtLastOffence,
                DateOfBirth = dtDOB,
                FormA = chkFormA,
                FormB = chkFormB,
                ActiveOffence = activeOffence,
                Underage = lblUnderage,
                NameUnderscored = btnNameUnderscore,
                GenBkgndChk = btnGenBkgndChk,
                GenReport = btnGenFirearmsVerdict,
            };
            _ = new FirearmLicenseController(flControl, typeof(FirearmLicenseReporter), typeof(BackgroundCheckReporter), rejList);
        }

        private void TrayContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
            if (e.ClickedItem == trayMenuAOT)
                TopMost = !trayMenuAOT.Checked;
            else if (e.ClickedItem == trayMenuExit)
                Close();
        }
    }
}
