namespace LSPDPaperwork
{
    partial class LSPDPMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                suspMgr.Dispose();
                if (components != null)
                    components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblImpoundReason;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label lblLocation;
            System.Windows.Forms.Label lblDateTime;
            System.Windows.Forms.Label lblVehColour;
            System.Windows.Forms.Label lblVehModel;
            System.Windows.Forms.Label lblLicensePlate;
            System.Windows.Forms.Label lblPhoneNum;
            System.Windows.Forms.Label lblVehOwner;
            System.Windows.Forms.Label lblOfficersInvolved;
            System.Windows.Forms.Label lblIrImpOfficer;
            System.Windows.Forms.Label lblIrImpDate;
            System.Windows.Forms.Label lblIrColor;
            System.Windows.Forms.Label lblIrModel;
            System.Windows.Forms.Label lblIrLicense;
            System.Windows.Forms.Label lblIrPhone;
            System.Windows.Forms.Label lblIrvehOwner;
            System.Windows.Forms.Label lblIrFee;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label17;
            System.Windows.Forms.Label label18;
            System.Windows.Forms.Label label19;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.TableLayoutPanel tblImpoundReport;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSPDPMainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArrestReport = new System.Windows.Forms.TabPage();
            this.txtMugshot = new System.Windows.Forms.TextBox();
            this.txtArrestingOfficers = new System.Windows.Forms.TextBox();
            this.txtSuspect = new System.Windows.Forms.TextBox();
            this.btnGenArrestReport = new System.Windows.Forms.Button();
            this.txtNarrative = new System.Windows.Forms.TextBox();
            this.chkLicensesRevoked = new System.Windows.Forms.CheckBox();
            this.chkCrimes = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSuggestCharge = new System.Windows.Forms.TextBox();
            this.btnAccessory = new System.Windows.Forms.Button();
            this.btnAttempted = new System.Windows.Forms.Button();
            this.btnAggravated = new System.Windows.Forms.Button();
            this.btnGovEmployee = new System.Windows.Forms.Button();
            this.txtSuspPhone = new System.Windows.Forms.TextBox();
            this.tabImpoundReport = new System.Windows.Forms.TabPage();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtScreenshot = new System.Windows.Forms.TextBox();
            this.txtImpoundLocation = new System.Windows.Forms.TextBox();
            this.txtVehColour = new System.Windows.Forms.TextBox();
            this.txtVehModel = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.txtVehOwner = new System.Windows.Forms.TextBox();
            this.dtImpoundTime = new System.Windows.Forms.DateTimePicker();
            this.txtOfficersInvolved = new System.Windows.Forms.TextBox();
            this.btnGenImpoundReport = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTimestamp = new System.Windows.Forms.TextBox();
            this.txtVehDetails = new System.Windows.Forms.TextBox();
            this.tabImpoundRelease = new System.Windows.Forms.TabPage();
            this.txtRelOfficer = new System.Windows.Forms.TextBox();
            this.txtRelColour = new System.Windows.Forms.TextBox();
            this.txtRelModel = new System.Windows.Forms.TextBox();
            this.txtRelLicense = new System.Windows.Forms.TextBox();
            this.txtRelVehOwner = new System.Windows.Forms.TextBox();
            this.txtRelDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenReleaseReport = new System.Windows.Forms.Button();
            this.txtRelFee = new System.Windows.Forms.TextBox();
            this.txtRelPhoneNum = new System.Windows.Forms.TextBox();
            this.tabDutyReport = new System.Windows.Forms.TabPage();
            this.dtWatchStart = new System.Windows.Forms.DateTimePicker();
            this.btnGenDutyReport = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtWatchEnd = new System.Windows.Forms.DateTimePicker();
            this.numArrests = new System.Windows.Forms.NumericUpDown();
            this.numCitations = new System.Windows.Forms.NumericUpDown();
            this.tabFirearms = new System.Windows.Forms.TabPage();
            this.txtApplicant = new System.Windows.Forms.TextBox();
            this.btnGenFirearmsVerdict = new System.Windows.Forms.Button();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.chkFormA = new System.Windows.Forms.CheckedListBox();
            this.chkFormB = new System.Windows.Forms.CheckedListBox();
            this.activeOffence = new System.Windows.Forms.Label();
            this.lblUnderage = new System.Windows.Forms.Label();
            this.dtLastOffence = new System.Windows.Forms.DateTimePicker();
            this.chkIsFormB = new System.Windows.Forms.CheckBox();
            this.chkDeniedBefore = new System.Windows.Forms.CheckBox();
            this.btnGenBkgndChk = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuAOT = new System.Windows.Forms.ToolStripMenuItem();
            this.trayContextMenuSep = new System.Windows.Forms.ToolStripSeparator();
            this.trayMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNameUnderscore = new System.Windows.Forms.Button();
            lblImpoundReason = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblLocation = new System.Windows.Forms.Label();
            lblDateTime = new System.Windows.Forms.Label();
            lblVehColour = new System.Windows.Forms.Label();
            lblVehModel = new System.Windows.Forms.Label();
            lblLicensePlate = new System.Windows.Forms.Label();
            lblPhoneNum = new System.Windows.Forms.Label();
            lblVehOwner = new System.Windows.Forms.Label();
            lblOfficersInvolved = new System.Windows.Forms.Label();
            lblIrImpOfficer = new System.Windows.Forms.Label();
            lblIrImpDate = new System.Windows.Forms.Label();
            lblIrColor = new System.Windows.Forms.Label();
            lblIrModel = new System.Windows.Forms.Label();
            lblIrLicense = new System.Windows.Forms.Label();
            lblIrPhone = new System.Windows.Forms.Label();
            lblIrvehOwner = new System.Windows.Forms.Label();
            lblIrFee = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label17 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            label19 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label16 = new System.Windows.Forms.Label();
            tblImpoundReport = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabArrestReport.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabImpoundReport.SuspendLayout();
            tblImpoundReport.SuspendLayout();
            this.tabImpoundRelease.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            this.tabDutyReport.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCitations)).BeginInit();
            this.tabFirearms.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            this.trayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImpoundReason
            // 
            lblImpoundReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblImpoundReason.AutoSize = true;
            lblImpoundReason.Location = new System.Drawing.Point(3, 316);
            lblImpoundReason.Name = "lblImpoundReason";
            lblImpoundReason.Size = new System.Drawing.Size(102, 82);
            lblImpoundReason.TabIndex = 21;
            lblImpoundReason.Text = "Impound Statement:";
            lblImpoundReason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(41, 208);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(64, 26);
            label2.TabIndex = 17;
            label2.Text = "Screenshot:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblLocation.AutoSize = true;
            lblLocation.Location = new System.Drawing.Point(54, 182);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new System.Drawing.Size(51, 26);
            lblLocation.TabIndex = 15;
            lblLocation.Text = "Location:";
            lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new System.Drawing.Point(28, 156);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(77, 26);
            lblDateTime.TabIndex = 13;
            lblDateTime.Text = "Impound Time:";
            lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVehColour
            // 
            lblVehColour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblVehColour.AutoSize = true;
            lblVehColour.Location = new System.Drawing.Point(27, 104);
            lblVehColour.Name = "lblVehColour";
            lblVehColour.Size = new System.Drawing.Size(78, 26);
            lblVehColour.TabIndex = 11;
            lblVehColour.Text = "Vehicle Colour:";
            lblVehColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVehModel
            // 
            lblVehModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblVehModel.AutoSize = true;
            lblVehModel.Location = new System.Drawing.Point(28, 78);
            lblVehModel.Name = "lblVehModel";
            lblVehModel.Size = new System.Drawing.Size(77, 26);
            lblVehModel.TabIndex = 8;
            lblVehModel.Text = "Vehicle Model:";
            lblVehModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblLicensePlate.AutoSize = true;
            lblLicensePlate.Location = new System.Drawing.Point(31, 52);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new System.Drawing.Size(74, 26);
            lblLicensePlate.TabIndex = 6;
            lblLicensePlate.Text = "License Plate:";
            lblLicensePlate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhoneNum
            // 
            lblPhoneNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblPhoneNum.AutoSize = true;
            lblPhoneNum.Location = new System.Drawing.Point(24, 26);
            lblPhoneNum.Name = "lblPhoneNum";
            lblPhoneNum.Size = new System.Drawing.Size(81, 26);
            lblPhoneNum.TabIndex = 4;
            lblPhoneNum.Text = "Phone Number:";
            lblPhoneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVehOwner
            // 
            lblVehOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblVehOwner.AutoSize = true;
            lblVehOwner.Location = new System.Drawing.Point(26, 0);
            lblVehOwner.Name = "lblVehOwner";
            lblVehOwner.Size = new System.Drawing.Size(79, 26);
            lblVehOwner.TabIndex = 0;
            lblVehOwner.Text = "Vehicle Owner:";
            lblVehOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOfficersInvolved
            // 
            lblOfficersInvolved.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblOfficersInvolved.AutoSize = true;
            lblOfficersInvolved.Location = new System.Drawing.Point(15, 234);
            lblOfficersInvolved.Name = "lblOfficersInvolved";
            lblOfficersInvolved.Size = new System.Drawing.Size(90, 82);
            lblOfficersInvolved.TabIndex = 19;
            lblOfficersInvolved.Text = "Officers Involved:";
            lblOfficersInvolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrImpOfficer
            // 
            lblIrImpOfficer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrImpOfficer.AutoSize = true;
            lblIrImpOfficer.Location = new System.Drawing.Point(3, 156);
            lblIrImpOfficer.Name = "lblIrImpOfficer";
            lblIrImpOfficer.Size = new System.Drawing.Size(99, 26);
            lblIrImpOfficer.TabIndex = 15;
            lblIrImpOfficer.Text = "Impounding Officer:";
            lblIrImpOfficer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrImpDate
            // 
            lblIrImpDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrImpDate.AutoSize = true;
            lblIrImpDate.Location = new System.Drawing.Point(25, 130);
            lblIrImpDate.Name = "lblIrImpDate";
            lblIrImpDate.Size = new System.Drawing.Size(77, 26);
            lblIrImpDate.TabIndex = 13;
            lblIrImpDate.Text = "Impound Date:";
            lblIrImpDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrColor
            // 
            lblIrColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrColor.AutoSize = true;
            lblIrColor.Location = new System.Drawing.Point(24, 104);
            lblIrColor.Name = "lblIrColor";
            lblIrColor.Size = new System.Drawing.Size(78, 26);
            lblIrColor.TabIndex = 11;
            lblIrColor.Text = "Vehicle Colour:";
            lblIrColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrModel
            // 
            lblIrModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrModel.AutoSize = true;
            lblIrModel.Location = new System.Drawing.Point(25, 78);
            lblIrModel.Name = "lblIrModel";
            lblIrModel.Size = new System.Drawing.Size(77, 26);
            lblIrModel.TabIndex = 8;
            lblIrModel.Text = "Vehicle Model:";
            lblIrModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrLicense
            // 
            lblIrLicense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrLicense.AutoSize = true;
            lblIrLicense.Location = new System.Drawing.Point(28, 52);
            lblIrLicense.Name = "lblIrLicense";
            lblIrLicense.Size = new System.Drawing.Size(74, 26);
            lblIrLicense.TabIndex = 6;
            lblIrLicense.Text = "License Plate:";
            lblIrLicense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrPhone
            // 
            lblIrPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrPhone.AutoSize = true;
            lblIrPhone.Location = new System.Drawing.Point(21, 26);
            lblIrPhone.Name = "lblIrPhone";
            lblIrPhone.Size = new System.Drawing.Size(81, 26);
            lblIrPhone.TabIndex = 4;
            lblIrPhone.Text = "Phone Number:";
            lblIrPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrvehOwner
            // 
            lblIrvehOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrvehOwner.AutoSize = true;
            lblIrvehOwner.Location = new System.Drawing.Point(23, 0);
            lblIrvehOwner.Name = "lblIrvehOwner";
            lblIrvehOwner.Size = new System.Drawing.Size(79, 26);
            lblIrvehOwner.TabIndex = 0;
            lblIrvehOwner.Text = "Vehicle Owner:";
            lblIrvehOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIrFee
            // 
            lblIrFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            lblIrFee.AutoSize = true;
            lblIrFee.Location = new System.Drawing.Point(32, 182);
            lblIrFee.Name = "lblIrFee";
            lblIrFee.Size = new System.Drawing.Size(70, 26);
            lblIrFee.TabIndex = 19;
            lblIrFee.Text = "Release Fee:";
            lblIrFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 286);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 26);
            label1.TabIndex = 15;
            label1.Text = "Mugshot:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 156);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 130);
            label4.TabIndex = 11;
            label4.Text = "Charges:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 81);
            label5.TabIndex = 8;
            label5.Text = "Officers Involved:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(3, 52);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(99, 23);
            label6.TabIndex = 6;
            label6.Text = "Licenses Revoked:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(21, 26);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 26);
            label7.TabIndex = 4;
            label7.Text = "Phone Number:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(22, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(80, 26);
            label8.TabIndex = 0;
            label8.Text = "Suspect Name:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(49, 312);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(53, 94);
            label9.TabIndex = 19;
            label9.Text = "Narrative:";
            label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(32, 78);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(50, 26);
            label11.TabIndex = 8;
            label11.Text = "Citations:";
            label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(40, 52);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(42, 26);
            label12.TabIndex = 6;
            label12.Text = "Arrests:";
            label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(6, 26);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(76, 26);
            label13.TabIndex = 4;
            label13.Text = "End of Watch:";
            label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(3, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(79, 26);
            label14.TabIndex = 0;
            label14.Text = "Start of Watch:";
            label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(44, 104);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(38, 310);
            label15.TabIndex = 19;
            label15.Text = "Notes:";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(364, 156);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 26);
            label3.TabIndex = 22;
            label3.Text = "Timestamp Converter:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(25, 130);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(80, 26);
            label10.TabIndex = 24;
            label10.Text = "Vehicle Details:";
            label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(40, 133);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(43, 145);
            label17.TabIndex = 15;
            label17.Text = "Form A:";
            label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(14, 107);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(69, 26);
            label18.TabIndex = 13;
            label18.Text = "Date of Birth:";
            label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label19.AutoSize = true;
            label19.Location = new System.Drawing.Point(3, 81);
            label19.Name = "label19";
            label19.Size = new System.Drawing.Size(80, 26);
            label19.TabIndex = 11;
            label19.Text = "Latest Offence:";
            label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(29, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(54, 29);
            label23.TabIndex = 0;
            label23.Text = "Applicant:";
            label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(40, 278);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(43, 145);
            label20.TabIndex = 15;
            label20.Text = "Form B:";
            label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArrestReport);
            this.tabControl1.Controls.Add(this.tabImpoundReport);
            this.tabControl1.Controls.Add(this.tabImpoundRelease);
            this.tabControl1.Controls.Add(this.tabDutyReport);
            this.tabControl1.Controls.Add(this.tabFirearms);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(800, 450);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // tabArrestReport
            // 
            this.tabArrestReport.Controls.Add(tableLayoutPanel2);
            this.tabArrestReport.Location = new System.Drawing.Point(4, 22);
            this.tabArrestReport.Name = "tabArrestReport";
            this.tabArrestReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabArrestReport.Size = new System.Drawing.Size(792, 449);
            this.tabArrestReport.TabIndex = 0;
            this.tabArrestReport.Text = "Arrest Report";
            this.tabArrestReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(this.txtMugshot, 1, 5);
            tableLayoutPanel2.Controls.Add(label1, 0, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Controls.Add(this.txtArrestingOfficers, 1, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Controls.Add(label8, 0, 0);
            tableLayoutPanel2.Controls.Add(this.txtSuspect, 1, 0);
            tableLayoutPanel2.Controls.Add(label9, 0, 6);
            tableLayoutPanel2.Controls.Add(this.btnGenArrestReport, 0, 7);
            tableLayoutPanel2.Controls.Add(this.txtNarrative, 1, 6);
            tableLayoutPanel2.Controls.Add(this.chkLicensesRevoked, 1, 2);
            tableLayoutPanel2.Controls.Add(this.chkCrimes, 1, 4);
            tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 4);
            tableLayoutPanel2.Controls.Add(this.txtSuspPhone, 1, 1);
            tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(786, 444);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtMugshot
            // 
            this.txtMugshot.Location = new System.Drawing.Point(108, 289);
            this.txtMugshot.Name = "txtMugshot";
            this.txtMugshot.Size = new System.Drawing.Size(331, 20);
            this.txtMugshot.TabIndex = 6;
            // 
            // txtArrestingOfficers
            // 
            this.txtArrestingOfficers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtArrestingOfficers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtArrestingOfficers.Location = new System.Drawing.Point(108, 78);
            this.txtArrestingOfficers.Multiline = true;
            this.txtArrestingOfficers.Name = "txtArrestingOfficers";
            this.txtArrestingOfficers.Size = new System.Drawing.Size(331, 75);
            this.txtArrestingOfficers.TabIndex = 4;
            // 
            // txtSuspect
            // 
            this.txtSuspect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSuspect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSuspect.Location = new System.Drawing.Point(108, 3);
            this.txtSuspect.Name = "txtSuspect";
            this.txtSuspect.Size = new System.Drawing.Size(331, 20);
            this.txtSuspect.TabIndex = 1;
            // 
            // btnGenArrestReport
            // 
            this.btnGenArrestReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel2.SetColumnSpan(this.btnGenArrestReport, 3);
            this.btnGenArrestReport.Location = new System.Drawing.Point(3, 409);
            this.btnGenArrestReport.Name = "btnGenArrestReport";
            this.btnGenArrestReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenArrestReport.TabIndex = 8;
            this.btnGenArrestReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenArrestReport.UseVisualStyleBackColor = true;
            // 
            // txtNarrative
            // 
            tableLayoutPanel2.SetColumnSpan(this.txtNarrative, 2);
            this.txtNarrative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNarrative.Location = new System.Drawing.Point(108, 315);
            this.txtNarrative.Multiline = true;
            this.txtNarrative.Name = "txtNarrative";
            this.txtNarrative.Size = new System.Drawing.Size(675, 88);
            this.txtNarrative.TabIndex = 7;
            // 
            // chkLicensesRevoked
            // 
            this.chkLicensesRevoked.AutoSize = true;
            this.chkLicensesRevoked.Location = new System.Drawing.Point(108, 55);
            this.chkLicensesRevoked.Name = "chkLicensesRevoked";
            this.chkLicensesRevoked.Size = new System.Drawing.Size(63, 17);
            this.chkLicensesRevoked.TabIndex = 3;
            this.chkLicensesRevoked.Text = "Yes/No";
            this.chkLicensesRevoked.UseVisualStyleBackColor = true;
            // 
            // chkCrimes
            // 
            this.chkCrimes.CheckOnClick = true;
            this.chkCrimes.FormattingEnabled = true;
            this.chkCrimes.HorizontalScrollbar = true;
            this.chkCrimes.Location = new System.Drawing.Point(108, 159);
            this.chkCrimes.Name = "chkCrimes";
            this.chkCrimes.Size = new System.Drawing.Size(331, 124);
            this.chkCrimes.TabIndex = 21;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtSuggestCharge, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAccessory, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnAttempted, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnAggravated, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnGovEmployee, 3, 2);
            this.tableLayoutPanel3.Controls.Add(label16, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(445, 159);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(338, 124);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // txtSuggestCharge
            // 
            this.txtSuggestCharge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSuggestCharge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tableLayoutPanel3.SetColumnSpan(this.txtSuggestCharge, 4);
            this.txtSuggestCharge.Location = new System.Drawing.Point(3, 16);
            this.txtSuggestCharge.Name = "txtSuggestCharge";
            this.txtSuggestCharge.Size = new System.Drawing.Size(329, 20);
            this.txtSuggestCharge.TabIndex = 1;
            // 
            // btnAccessory
            // 
            this.btnAccessory.AutoSize = true;
            this.btnAccessory.Location = new System.Drawing.Point(3, 42);
            this.btnAccessory.Name = "btnAccessory";
            this.btnAccessory.Size = new System.Drawing.Size(75, 23);
            this.btnAccessory.TabIndex = 7;
            this.btnAccessory.TabStop = false;
            this.btnAccessory.Text = "Accessory";
            this.btnAccessory.UseVisualStyleBackColor = true;
            // 
            // btnAttempted
            // 
            this.btnAttempted.Location = new System.Drawing.Point(84, 42);
            this.btnAttempted.Name = "btnAttempted";
            this.btnAttempted.Size = new System.Drawing.Size(75, 23);
            this.btnAttempted.TabIndex = 8;
            this.btnAttempted.TabStop = false;
            this.btnAttempted.Text = "Attempted";
            this.btnAttempted.UseVisualStyleBackColor = true;
            // 
            // btnAggravated
            // 
            this.btnAggravated.AutoSize = true;
            this.btnAggravated.Location = new System.Drawing.Point(165, 42);
            this.btnAggravated.Name = "btnAggravated";
            this.btnAggravated.Size = new System.Drawing.Size(72, 23);
            this.btnAggravated.TabIndex = 9;
            this.btnAggravated.TabStop = false;
            this.btnAggravated.Text = "Aggravated";
            this.btnAggravated.UseVisualStyleBackColor = true;
            // 
            // btnGovEmployee
            // 
            this.btnGovEmployee.AutoSize = true;
            this.btnGovEmployee.Location = new System.Drawing.Point(243, 42);
            this.btnGovEmployee.Name = "btnGovEmployee";
            this.btnGovEmployee.Size = new System.Drawing.Size(89, 23);
            this.btnGovEmployee.TabIndex = 10;
            this.btnGovEmployee.TabStop = false;
            this.btnGovEmployee.Text = "Gov. Employee";
            this.btnGovEmployee.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(label16, 4);
            label16.Location = new System.Drawing.Point(3, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(94, 13);
            label16.TabIndex = 11;
            label16.Text = "Crime Search Box:";
            // 
            // txtSuspPhone
            // 
            this.txtSuspPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSuspPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSuspPhone.Location = new System.Drawing.Point(108, 29);
            this.txtSuspPhone.MaxLength = 7;
            this.txtSuspPhone.Name = "txtSuspPhone";
            this.txtSuspPhone.Size = new System.Drawing.Size(331, 20);
            this.txtSuspPhone.TabIndex = 2;
            // 
            // tabImpoundReport
            // 
            this.tabImpoundReport.Controls.Add(tblImpoundReport);
            this.tabImpoundReport.Location = new System.Drawing.Point(4, 22);
            this.tabImpoundReport.Name = "tabImpoundReport";
            this.tabImpoundReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabImpoundReport.Size = new System.Drawing.Size(792, 449);
            this.tabImpoundReport.TabIndex = 1;
            this.tabImpoundReport.Text = "Impound Report";
            this.tabImpoundReport.UseVisualStyleBackColor = true;
            // 
            // tblImpoundReport
            // 
            tblImpoundReport.ColumnCount = 4;
            tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tblImpoundReport.Controls.Add(this.txtReason, 1, 10);
            tblImpoundReport.Controls.Add(lblImpoundReason, 0, 10);
            tblImpoundReport.Controls.Add(this.txtScreenshot, 1, 8);
            tblImpoundReport.Controls.Add(label2, 0, 8);
            tblImpoundReport.Controls.Add(this.txtImpoundLocation, 1, 7);
            tblImpoundReport.Controls.Add(lblLocation, 0, 7);
            tblImpoundReport.Controls.Add(lblDateTime, 0, 6);
            tblImpoundReport.Controls.Add(this.txtVehColour, 1, 4);
            tblImpoundReport.Controls.Add(lblVehColour, 0, 4);
            tblImpoundReport.Controls.Add(this.txtVehModel, 1, 3);
            tblImpoundReport.Controls.Add(lblVehModel, 0, 3);
            tblImpoundReport.Controls.Add(this.txtLicensePlate, 1, 2);
            tblImpoundReport.Controls.Add(lblLicensePlate, 0, 2);
            tblImpoundReport.Controls.Add(lblPhoneNum, 0, 1);
            tblImpoundReport.Controls.Add(lblVehOwner, 0, 0);
            tblImpoundReport.Controls.Add(this.txtVehOwner, 1, 0);
            tblImpoundReport.Controls.Add(this.dtImpoundTime, 1, 6);
            tblImpoundReport.Controls.Add(lblOfficersInvolved, 0, 9);
            tblImpoundReport.Controls.Add(this.txtOfficersInvolved, 1, 9);
            tblImpoundReport.Controls.Add(this.btnGenImpoundReport, 0, 11);
            tblImpoundReport.Controls.Add(this.txtPhoneNumber, 1, 1);
            tblImpoundReport.Controls.Add(label3, 2, 6);
            tblImpoundReport.Controls.Add(this.txtTimestamp, 3, 6);
            tblImpoundReport.Controls.Add(label10, 0, 5);
            tblImpoundReport.Controls.Add(this.txtVehDetails, 1, 5);
            tblImpoundReport.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tblImpoundReport.Location = new System.Drawing.Point(3, 3);
            tblImpoundReport.Name = "tblImpoundReport";
            tblImpoundReport.RowCount = 12;
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tblImpoundReport.Size = new System.Drawing.Size(786, 446);
            tblImpoundReport.TabIndex = 0;
            // 
            // txtReason
            // 
            this.txtReason.AcceptsReturn = true;
            this.txtReason.Location = new System.Drawing.Point(111, 319);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(247, 76);
            this.txtReason.TabIndex = 10;
            // 
            // txtScreenshot
            // 
            this.txtScreenshot.Location = new System.Drawing.Point(111, 211);
            this.txtScreenshot.Name = "txtScreenshot";
            this.txtScreenshot.Size = new System.Drawing.Size(247, 20);
            this.txtScreenshot.TabIndex = 8;
            // 
            // txtImpoundLocation
            // 
            this.txtImpoundLocation.Location = new System.Drawing.Point(111, 185);
            this.txtImpoundLocation.Name = "txtImpoundLocation";
            this.txtImpoundLocation.Size = new System.Drawing.Size(247, 20);
            this.txtImpoundLocation.TabIndex = 7;
            // 
            // txtVehColour
            // 
            this.txtVehColour.Location = new System.Drawing.Point(111, 107);
            this.txtVehColour.Name = "txtVehColour";
            this.txtVehColour.Size = new System.Drawing.Size(247, 20);
            this.txtVehColour.TabIndex = 5;
            // 
            // txtVehModel
            // 
            this.txtVehModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVehModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVehModel.Location = new System.Drawing.Point(111, 81);
            this.txtVehModel.Name = "txtVehModel";
            this.txtVehModel.Size = new System.Drawing.Size(247, 20);
            this.txtVehModel.TabIndex = 4;
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(111, 55);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(247, 20);
            this.txtLicensePlate.TabIndex = 3;
            // 
            // txtVehOwner
            // 
            this.txtVehOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtVehOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVehOwner.Location = new System.Drawing.Point(111, 3);
            this.txtVehOwner.Name = "txtVehOwner";
            this.txtVehOwner.Size = new System.Drawing.Size(247, 20);
            this.txtVehOwner.TabIndex = 1;
            // 
            // dtImpoundTime
            // 
            this.dtImpoundTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtImpoundTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtImpoundTime.Location = new System.Drawing.Point(111, 159);
            this.dtImpoundTime.Name = "dtImpoundTime";
            this.dtImpoundTime.Size = new System.Drawing.Size(247, 20);
            this.dtImpoundTime.TabIndex = 14;
            // 
            // txtOfficersInvolved
            // 
            this.txtOfficersInvolved.AcceptsReturn = true;
            this.txtOfficersInvolved.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtOfficersInvolved.Location = new System.Drawing.Point(111, 237);
            this.txtOfficersInvolved.Multiline = true;
            this.txtOfficersInvolved.Name = "txtOfficersInvolved";
            this.txtOfficersInvolved.Size = new System.Drawing.Size(247, 76);
            this.txtOfficersInvolved.TabIndex = 9;
            // 
            // btnGenImpoundReport
            // 
            this.btnGenImpoundReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            tblImpoundReport.SetColumnSpan(this.btnGenImpoundReport, 4);
            this.btnGenImpoundReport.Location = new System.Drawing.Point(3, 410);
            this.btnGenImpoundReport.Name = "btnGenImpoundReport";
            this.btnGenImpoundReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenImpoundReport.TabIndex = 11;
            this.btnGenImpoundReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenImpoundReport.UseVisualStyleBackColor = true;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhoneNumber.Location = new System.Drawing.Point(111, 29);
            this.txtPhoneNumber.MaxLength = 7;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(247, 20);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Location = new System.Drawing.Point(480, 159);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(165, 20);
            this.txtTimestamp.TabIndex = 23;
            // 
            // txtVehDetails
            // 
            this.txtVehDetails.Location = new System.Drawing.Point(111, 133);
            this.txtVehDetails.Name = "txtVehDetails";
            this.txtVehDetails.Size = new System.Drawing.Size(247, 20);
            this.txtVehDetails.TabIndex = 6;
            // 
            // tabImpoundRelease
            // 
            this.tabImpoundRelease.Controls.Add(tableLayoutPanel1);
            this.tabImpoundRelease.Location = new System.Drawing.Point(4, 22);
            this.tabImpoundRelease.Name = "tabImpoundRelease";
            this.tabImpoundRelease.Size = new System.Drawing.Size(792, 449);
            this.tabImpoundRelease.TabIndex = 2;
            this.tabImpoundRelease.Text = "Impound Release Report";
            this.tabImpoundRelease.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(this.txtRelOfficer, 1, 6);
            tableLayoutPanel1.Controls.Add(lblIrImpOfficer, 0, 6);
            tableLayoutPanel1.Controls.Add(lblIrImpDate, 0, 5);
            tableLayoutPanel1.Controls.Add(this.txtRelColour, 1, 4);
            tableLayoutPanel1.Controls.Add(lblIrColor, 0, 4);
            tableLayoutPanel1.Controls.Add(this.txtRelModel, 1, 3);
            tableLayoutPanel1.Controls.Add(lblIrModel, 0, 3);
            tableLayoutPanel1.Controls.Add(this.txtRelLicense, 1, 2);
            tableLayoutPanel1.Controls.Add(lblIrLicense, 0, 2);
            tableLayoutPanel1.Controls.Add(lblIrPhone, 0, 1);
            tableLayoutPanel1.Controls.Add(lblIrvehOwner, 0, 0);
            tableLayoutPanel1.Controls.Add(this.txtRelVehOwner, 1, 0);
            tableLayoutPanel1.Controls.Add(this.txtRelDate, 1, 5);
            tableLayoutPanel1.Controls.Add(lblIrFee, 0, 7);
            tableLayoutPanel1.Controls.Add(this.btnGenReleaseReport, 0, 8);
            tableLayoutPanel1.Controls.Add(this.txtRelFee, 1, 7);
            tableLayoutPanel1.Controls.Add(this.txtRelPhoneNum, 1, 1);
            tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // txtRelOfficer
            // 
            this.txtRelOfficer.Location = new System.Drawing.Point(108, 159);
            this.txtRelOfficer.Name = "txtRelOfficer";
            this.txtRelOfficer.Size = new System.Drawing.Size(247, 20);
            this.txtRelOfficer.TabIndex = 7;
            // 
            // txtRelColour
            // 
            this.txtRelColour.Location = new System.Drawing.Point(108, 107);
            this.txtRelColour.Name = "txtRelColour";
            this.txtRelColour.Size = new System.Drawing.Size(247, 20);
            this.txtRelColour.TabIndex = 5;
            // 
            // txtRelModel
            // 
            this.txtRelModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRelModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRelModel.Location = new System.Drawing.Point(108, 81);
            this.txtRelModel.Name = "txtRelModel";
            this.txtRelModel.Size = new System.Drawing.Size(247, 20);
            this.txtRelModel.TabIndex = 4;
            // 
            // txtRelLicense
            // 
            this.txtRelLicense.Location = new System.Drawing.Point(108, 55);
            this.txtRelLicense.Name = "txtRelLicense";
            this.txtRelLicense.Size = new System.Drawing.Size(247, 20);
            this.txtRelLicense.TabIndex = 3;
            // 
            // txtRelVehOwner
            // 
            this.txtRelVehOwner.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRelVehOwner.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRelVehOwner.Location = new System.Drawing.Point(108, 3);
            this.txtRelVehOwner.Name = "txtRelVehOwner";
            this.txtRelVehOwner.Size = new System.Drawing.Size(247, 20);
            this.txtRelVehOwner.TabIndex = 1;
            // 
            // txtRelDate
            // 
            this.txtRelDate.CustomFormat = "dd/MM/yyyy";
            this.txtRelDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtRelDate.Location = new System.Drawing.Point(108, 133);
            this.txtRelDate.Name = "txtRelDate";
            this.txtRelDate.Size = new System.Drawing.Size(247, 20);
            this.txtRelDate.TabIndex = 6;
            // 
            // btnGenReleaseReport
            // 
            this.btnGenReleaseReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel1.SetColumnSpan(this.btnGenReleaseReport, 3);
            this.btnGenReleaseReport.Location = new System.Drawing.Point(3, 211);
            this.btnGenReleaseReport.Name = "btnGenReleaseReport";
            this.btnGenReleaseReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenReleaseReport.TabIndex = 9;
            this.btnGenReleaseReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenReleaseReport.UseVisualStyleBackColor = true;
            // 
            // txtRelFee
            // 
            this.txtRelFee.Location = new System.Drawing.Point(108, 185);
            this.txtRelFee.Name = "txtRelFee";
            this.txtRelFee.Size = new System.Drawing.Size(247, 20);
            this.txtRelFee.TabIndex = 8;
            // 
            // txtRelPhoneNum
            // 
            this.txtRelPhoneNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtRelPhoneNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRelPhoneNum.Location = new System.Drawing.Point(108, 29);
            this.txtRelPhoneNum.MaxLength = 7;
            this.txtRelPhoneNum.Name = "txtRelPhoneNum";
            this.txtRelPhoneNum.Size = new System.Drawing.Size(247, 20);
            this.txtRelPhoneNum.TabIndex = 2;
            // 
            // tabDutyReport
            // 
            this.tabDutyReport.Controls.Add(tableLayoutPanel4);
            this.tabDutyReport.Location = new System.Drawing.Point(4, 22);
            this.tabDutyReport.Name = "tabDutyReport";
            this.tabDutyReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabDutyReport.Size = new System.Drawing.Size(792, 449);
            this.tabDutyReport.TabIndex = 3;
            this.tabDutyReport.Text = "Duty Report";
            this.tabDutyReport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel4.Controls.Add(this.dtWatchStart, 1, 0);
            tableLayoutPanel4.Controls.Add(label11, 0, 3);
            tableLayoutPanel4.Controls.Add(label12, 0, 2);
            tableLayoutPanel4.Controls.Add(label13, 0, 1);
            tableLayoutPanel4.Controls.Add(label14, 0, 0);
            tableLayoutPanel4.Controls.Add(label15, 0, 4);
            tableLayoutPanel4.Controls.Add(this.btnGenDutyReport, 0, 5);
            tableLayoutPanel4.Controls.Add(this.txtNotes, 1, 4);
            tableLayoutPanel4.Controls.Add(this.dtWatchEnd, 1, 1);
            tableLayoutPanel4.Controls.Add(this.numArrests, 1, 2);
            tableLayoutPanel4.Controls.Add(this.numCitations, 1, 3);
            tableLayoutPanel4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel4.Size = new System.Drawing.Size(786, 444);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // dtWatchStart
            // 
            this.dtWatchStart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtWatchStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWatchStart.Location = new System.Drawing.Point(88, 3);
            this.dtWatchStart.Name = "dtWatchStart";
            this.dtWatchStart.Size = new System.Drawing.Size(247, 20);
            this.dtWatchStart.TabIndex = 1;
            // 
            // btnGenDutyReport
            // 
            this.btnGenDutyReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel4.SetColumnSpan(this.btnGenDutyReport, 2);
            this.btnGenDutyReport.Location = new System.Drawing.Point(3, 417);
            this.btnGenDutyReport.Name = "btnGenDutyReport";
            this.btnGenDutyReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenDutyReport.TabIndex = 6;
            this.btnGenDutyReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenDutyReport.UseVisualStyleBackColor = true;
            // 
            // txtNotes
            // 
            this.txtNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotes.Location = new System.Drawing.Point(88, 107);
            this.txtNotes.MaxLength = 65535;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNotes.Size = new System.Drawing.Size(695, 304);
            this.txtNotes.TabIndex = 5;
            // 
            // dtWatchEnd
            // 
            this.dtWatchEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtWatchEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtWatchEnd.Location = new System.Drawing.Point(88, 29);
            this.dtWatchEnd.Name = "dtWatchEnd";
            this.dtWatchEnd.Size = new System.Drawing.Size(247, 20);
            this.dtWatchEnd.TabIndex = 2;
            // 
            // numArrests
            // 
            this.numArrests.Location = new System.Drawing.Point(88, 55);
            this.numArrests.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numArrests.Name = "numArrests";
            this.numArrests.Size = new System.Drawing.Size(120, 20);
            this.numArrests.TabIndex = 3;
            // 
            // numCitations
            // 
            this.numCitations.Location = new System.Drawing.Point(88, 81);
            this.numCitations.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCitations.Name = "numCitations";
            this.numCitations.Size = new System.Drawing.Size(120, 20);
            this.numCitations.TabIndex = 4;
            // 
            // tabFirearms
            // 
            this.tabFirearms.Controls.Add(tableLayoutPanel5);
            this.tabFirearms.Location = new System.Drawing.Point(4, 22);
            this.tabFirearms.Name = "tabFirearms";
            this.tabFirearms.Size = new System.Drawing.Size(792, 449);
            this.tabFirearms.TabIndex = 4;
            this.tabFirearms.Text = "Firearms Permit";
            this.tabFirearms.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            tableLayoutPanel5.AutoSize = true;
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel5.Controls.Add(this.btnNameUnderscore, 2, 0);
            tableLayoutPanel5.Controls.Add(label17, 0, 5);
            tableLayoutPanel5.Controls.Add(label18, 0, 4);
            tableLayoutPanel5.Controls.Add(label19, 0, 3);
            tableLayoutPanel5.Controls.Add(label23, 0, 0);
            tableLayoutPanel5.Controls.Add(this.txtApplicant, 1, 0);
            tableLayoutPanel5.Controls.Add(this.btnGenFirearmsVerdict, 0, 7);
            tableLayoutPanel5.Controls.Add(this.dtDOB, 1, 4);
            tableLayoutPanel5.Controls.Add(this.chkFormA, 1, 5);
            tableLayoutPanel5.Controls.Add(label20, 0, 6);
            tableLayoutPanel5.Controls.Add(this.chkFormB, 1, 6);
            tableLayoutPanel5.Controls.Add(this.activeOffence, 2, 3);
            tableLayoutPanel5.Controls.Add(this.lblUnderage, 2, 4);
            tableLayoutPanel5.Controls.Add(this.dtLastOffence, 1, 3);
            tableLayoutPanel5.Controls.Add(this.chkIsFormB, 1, 2);
            tableLayoutPanel5.Controls.Add(this.chkDeniedBefore, 1, 1);
            tableLayoutPanel5.Controls.Add(this.btnGenBkgndChk, 2, 2);
            tableLayoutPanel5.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel5.Size = new System.Drawing.Size(786, 452);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // txtApplicant
            // 
            this.txtApplicant.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtApplicant.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApplicant.Location = new System.Drawing.Point(89, 3);
            this.txtApplicant.Name = "txtApplicant";
            this.txtApplicant.Size = new System.Drawing.Size(424, 20);
            this.txtApplicant.TabIndex = 1;
            // 
            // btnGenFirearmsVerdict
            // 
            this.btnGenFirearmsVerdict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            tableLayoutPanel5.SetColumnSpan(this.btnGenFirearmsVerdict, 3);
            this.btnGenFirearmsVerdict.Enabled = false;
            this.btnGenFirearmsVerdict.Location = new System.Drawing.Point(3, 426);
            this.btnGenFirearmsVerdict.Name = "btnGenFirearmsVerdict";
            this.btnGenFirearmsVerdict.Size = new System.Drawing.Size(780, 23);
            this.btnGenFirearmsVerdict.TabIndex = 9;
            this.btnGenFirearmsVerdict.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenFirearmsVerdict.UseVisualStyleBackColor = true;
            // 
            // dtDOB
            // 
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDOB.Location = new System.Drawing.Point(89, 110);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(424, 20);
            this.dtDOB.TabIndex = 24;
            // 
            // chkFormA
            // 
            this.chkFormA.CheckOnClick = true;
            this.chkFormA.ColumnWidth = 220;
            this.chkFormA.FormattingEnabled = true;
            this.chkFormA.HorizontalScrollbar = true;
            this.chkFormA.Location = new System.Drawing.Point(89, 136);
            this.chkFormA.Name = "chkFormA";
            this.chkFormA.Size = new System.Drawing.Size(424, 139);
            this.chkFormA.TabIndex = 25;
            this.chkFormA.ThreeDCheckBoxes = true;
            // 
            // chkFormB
            // 
            this.chkFormB.CheckOnClick = true;
            this.chkFormB.FormattingEnabled = true;
            this.chkFormB.Location = new System.Drawing.Point(89, 281);
            this.chkFormB.Name = "chkFormB";
            this.chkFormB.Size = new System.Drawing.Size(424, 139);
            this.chkFormB.TabIndex = 25;
            // 
            // activeOffence
            // 
            this.activeOffence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.activeOffence.AutoSize = true;
            this.activeOffence.BackColor = System.Drawing.Color.Red;
            this.activeOffence.Location = new System.Drawing.Point(519, 81);
            this.activeOffence.Name = "activeOffence";
            this.activeOffence.Size = new System.Drawing.Size(68, 26);
            this.activeOffence.TabIndex = 26;
            this.activeOffence.Text = "INELIGIBLE!";
            this.activeOffence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.activeOffence.Visible = false;
            // 
            // lblUnderage
            // 
            this.lblUnderage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUnderage.AutoSize = true;
            this.lblUnderage.BackColor = System.Drawing.Color.Red;
            this.lblUnderage.Location = new System.Drawing.Point(519, 107);
            this.lblUnderage.Name = "lblUnderage";
            this.lblUnderage.Size = new System.Drawing.Size(57, 26);
            this.lblUnderage.TabIndex = 27;
            this.lblUnderage.Text = "Underage!";
            this.lblUnderage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnderage.Visible = false;
            // 
            // dtLastOffence
            // 
            this.dtLastOffence.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtLastOffence.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLastOffence.Location = new System.Drawing.Point(89, 84);
            this.dtLastOffence.Name = "dtLastOffence";
            this.dtLastOffence.Size = new System.Drawing.Size(424, 20);
            this.dtLastOffence.TabIndex = 23;
            this.dtLastOffence.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // chkIsFormB
            // 
            this.chkIsFormB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkIsFormB.AutoSize = true;
            this.chkIsFormB.Location = new System.Drawing.Point(89, 55);
            this.chkIsFormB.Name = "chkIsFormB";
            this.chkIsFormB.Size = new System.Drawing.Size(65, 23);
            this.chkIsFormB.TabIndex = 28;
            this.chkIsFormB.Text = "Form B?";
            this.chkIsFormB.UseVisualStyleBackColor = true;
            // 
            // chkDeniedBefore
            // 
            this.chkDeniedBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chkDeniedBefore.AutoSize = true;
            this.chkDeniedBefore.Location = new System.Drawing.Point(89, 32);
            this.chkDeniedBefore.Name = "chkDeniedBefore";
            this.chkDeniedBefore.Size = new System.Drawing.Size(137, 17);
            this.chkDeniedBefore.TabIndex = 22;
            this.chkDeniedBefore.Text = "Not Previously Denied?";
            this.chkDeniedBefore.UseVisualStyleBackColor = true;
            // 
            // btnGenBkgndChk
            // 
            this.btnGenBkgndChk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenBkgndChk.AutoSize = true;
            this.btnGenBkgndChk.Enabled = false;
            this.btnGenBkgndChk.Location = new System.Drawing.Point(519, 55);
            this.btnGenBkgndChk.Name = "btnGenBkgndChk";
            this.btnGenBkgndChk.Size = new System.Drawing.Size(109, 23);
            this.btnGenBkgndChk.TabIndex = 29;
            this.btnGenBkgndChk.Text = "Background Check";
            this.btnGenBkgndChk.UseVisualStyleBackColor = true;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayContextMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "LSPD Paperwork";
            this.trayIcon.Visible = true;
            // 
            // trayContextMenu
            // 
            this.trayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuAOT,
            this.trayContextMenuSep,
            this.trayMenuExit});
            this.trayContextMenu.Name = "trayContextMenu";
            this.trayContextMenu.Size = new System.Drawing.Size(152, 54);
            this.trayContextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TrayContextMenu_ItemClicked);
            // 
            // trayMenuAOT
            // 
            this.trayMenuAOT.CheckOnClick = true;
            this.trayMenuAOT.Name = "trayMenuAOT";
            this.trayMenuAOT.Size = new System.Drawing.Size(151, 22);
            this.trayMenuAOT.Text = "Always on Top";
            // 
            // trayContextMenuSep
            // 
            this.trayContextMenuSep.Name = "trayContextMenuSep";
            this.trayContextMenuSep.Size = new System.Drawing.Size(148, 6);
            // 
            // trayMenuExit
            // 
            this.trayMenuExit.Name = "trayMenuExit";
            this.trayMenuExit.Size = new System.Drawing.Size(151, 22);
            this.trayMenuExit.Text = "Exit";
            // 
            // btnNameUnderscore
            // 
            this.btnNameUnderscore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNameUnderscore.AutoSize = true;
            this.btnNameUnderscore.Enabled = false;
            this.btnNameUnderscore.Location = new System.Drawing.Point(519, 3);
            this.btnNameUnderscore.Name = "btnNameUnderscore";
            this.btnNameUnderscore.Size = new System.Drawing.Size(109, 23);
            this.btnNameUnderscore.TabIndex = 30;
            this.btnNameUnderscore.Text = "Name With _";
            this.btnNameUnderscore.UseVisualStyleBackColor = true;
            // 
            // LSPDPMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LSPDPMainForm";
            this.Text = "LSPD Paperwork";
            this.tabControl1.ResumeLayout(false);
            this.tabArrestReport.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabImpoundReport.ResumeLayout(false);
            tblImpoundReport.ResumeLayout(false);
            tblImpoundReport.PerformLayout();
            this.tabImpoundRelease.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            this.tabDutyReport.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCitations)).EndInit();
            this.tabFirearms.ResumeLayout(false);
            this.tabFirearms.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            this.trayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArrestReport;
        private System.Windows.Forms.TabPage tabImpoundReport;
        private System.Windows.Forms.TabPage tabImpoundRelease;
        private System.Windows.Forms.TextBox txtVehOwner;
        private System.Windows.Forms.TextBox txtVehModel;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.TextBox txtVehColour;
        private System.Windows.Forms.DateTimePicker dtImpoundTime;
        private System.Windows.Forms.TextBox txtImpoundLocation;
        private System.Windows.Forms.TextBox txtScreenshot;
        private System.Windows.Forms.TextBox txtOfficersInvolved;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnGenImpoundReport;
        private System.Windows.Forms.TextBox txtRelOfficer;
        private System.Windows.Forms.TextBox txtRelColour;
        private System.Windows.Forms.TextBox txtRelModel;
        private System.Windows.Forms.TextBox txtRelLicense;
        private System.Windows.Forms.TextBox txtRelVehOwner;
        private System.Windows.Forms.DateTimePicker txtRelDate;
        private System.Windows.Forms.Button btnGenReleaseReport;
        private System.Windows.Forms.TextBox txtRelFee;
        private System.Windows.Forms.TextBox txtMugshot;
        private System.Windows.Forms.TextBox txtArrestingOfficers;
        private System.Windows.Forms.TextBox txtSuspect;
        private System.Windows.Forms.Button btnGenArrestReport;
        private System.Windows.Forms.TextBox txtNarrative;
        private System.Windows.Forms.CheckBox chkLicensesRevoked;
        private System.Windows.Forms.CheckedListBox chkCrimes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtSuggestCharge;
        private System.Windows.Forms.Button btnAccessory;
        private System.Windows.Forms.Button btnAttempted;
        private System.Windows.Forms.Button btnAggravated;
        private System.Windows.Forms.Button btnGovEmployee;
        private System.Windows.Forms.TextBox txtSuspPhone;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtRelPhoneNum;
        private System.Windows.Forms.TabPage tabDutyReport;
        private System.Windows.Forms.DateTimePicker dtWatchStart;
        private System.Windows.Forms.Button btnGenDutyReport;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtWatchEnd;
        private System.Windows.Forms.NumericUpDown numArrests;
        private System.Windows.Forms.NumericUpDown numCitations;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.TextBox txtVehDetails;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuAOT;
        private System.Windows.Forms.ToolStripSeparator trayContextMenuSep;
        private System.Windows.Forms.ToolStripMenuItem trayMenuExit;
        private System.Windows.Forms.TabPage tabFirearms;
        private System.Windows.Forms.TextBox txtApplicant;
        private System.Windows.Forms.Button btnGenFirearmsVerdict;
        private System.Windows.Forms.CheckBox chkDeniedBefore;
        private System.Windows.Forms.DateTimePicker dtLastOffence;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.CheckedListBox chkFormA;
        private System.Windows.Forms.CheckedListBox chkFormB;
        private System.Windows.Forms.Label activeOffence;
        private System.Windows.Forms.Label lblUnderage;
        private System.Windows.Forms.CheckBox chkIsFormB;
        private System.Windows.Forms.Button btnGenBkgndChk;
        private System.Windows.Forms.Button btnNameUnderscore;
    }
}

