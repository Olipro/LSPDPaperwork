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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LSPDPMainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabArrestReport = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
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
            this.label16 = new System.Windows.Forms.Label();
            this.txtSuspPhone = new System.Windows.Forms.TextBox();
            this.tabImpoundReport = new System.Windows.Forms.TabPage();
            this.tblImpoundReport = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dtWatchStart = new System.Windows.Forms.DateTimePicker();
            this.btnGenDutyReport = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtWatchEnd = new System.Windows.Forms.DateTimePicker();
            this.numArrests = new System.Windows.Forms.NumericUpDown();
            this.numCitations = new System.Windows.Forms.NumericUpDown();
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
            this.tabControl1.SuspendLayout();
            this.tabArrestReport.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabImpoundReport.SuspendLayout();
            this.tblImpoundReport.SuspendLayout();
            this.tabImpoundRelease.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabDutyReport.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCitations)).BeginInit();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabArrestReport);
            this.tabControl1.Controls.Add(this.tabImpoundReport);
            this.tabControl1.Controls.Add(this.tabImpoundRelease);
            this.tabControl1.Controls.Add(this.tabDutyReport);
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
            this.tabArrestReport.Controls.Add(this.tableLayoutPanel2);
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
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.txtMugshot, 1, 5);
            this.tableLayoutPanel2.Controls.Add(label1, 0, 5);
            this.tableLayoutPanel2.Controls.Add(label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtArrestingOfficers, 1, 3);
            this.tableLayoutPanel2.Controls.Add(label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(label8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtSuspect, 1, 0);
            this.tableLayoutPanel2.Controls.Add(label9, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnGenArrestReport, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtNarrative, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.chkLicensesRevoked, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkCrimes, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtSuspPhone, 1, 1);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 444);
            this.tableLayoutPanel2.TabIndex = 2;
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
            this.txtSuspect.TextChanged += new System.EventHandler(this.Suspect_TextChanged);
            // 
            // btnGenArrestReport
            // 
            this.btnGenArrestReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.SetColumnSpan(this.btnGenArrestReport, 3);
            this.btnGenArrestReport.Location = new System.Drawing.Point(3, 409);
            this.btnGenArrestReport.Name = "btnGenArrestReport";
            this.btnGenArrestReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenArrestReport.TabIndex = 8;
            this.btnGenArrestReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenArrestReport.UseVisualStyleBackColor = true;
            this.btnGenArrestReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGenArrestReport_MouseUp);
            // 
            // txtNarrative
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.txtNarrative, 2);
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
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 0);
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
            this.txtSuggestCharge.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSuggestCharge_KeyUp);
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
            this.btnAccessory.Click += new System.EventHandler(this.BtnChargeModifier_Click);
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
            this.btnAttempted.Click += new System.EventHandler(this.BtnChargeModifier_Click);
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
            this.btnAggravated.Click += new System.EventHandler(this.BtnChargeModifier_Click);
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
            this.btnGovEmployee.Click += new System.EventHandler(this.BtnChargeModifier_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label16, 4);
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "Crime Search Box:";
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
            this.txtSuspPhone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            this.txtSuspPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSuspPhone_KeyPress);
            // 
            // tabImpoundReport
            // 
            this.tabImpoundReport.Controls.Add(this.tblImpoundReport);
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
            this.tblImpoundReport.ColumnCount = 4;
            this.tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblImpoundReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblImpoundReport.Controls.Add(this.txtReason, 1, 10);
            this.tblImpoundReport.Controls.Add(lblImpoundReason, 0, 10);
            this.tblImpoundReport.Controls.Add(this.txtScreenshot, 1, 8);
            this.tblImpoundReport.Controls.Add(label2, 0, 8);
            this.tblImpoundReport.Controls.Add(this.txtImpoundLocation, 1, 7);
            this.tblImpoundReport.Controls.Add(lblLocation, 0, 7);
            this.tblImpoundReport.Controls.Add(lblDateTime, 0, 6);
            this.tblImpoundReport.Controls.Add(this.txtVehColour, 1, 4);
            this.tblImpoundReport.Controls.Add(lblVehColour, 0, 4);
            this.tblImpoundReport.Controls.Add(this.txtVehModel, 1, 3);
            this.tblImpoundReport.Controls.Add(lblVehModel, 0, 3);
            this.tblImpoundReport.Controls.Add(this.txtLicensePlate, 1, 2);
            this.tblImpoundReport.Controls.Add(lblLicensePlate, 0, 2);
            this.tblImpoundReport.Controls.Add(lblPhoneNum, 0, 1);
            this.tblImpoundReport.Controls.Add(lblVehOwner, 0, 0);
            this.tblImpoundReport.Controls.Add(this.txtVehOwner, 1, 0);
            this.tblImpoundReport.Controls.Add(this.dtImpoundTime, 1, 6);
            this.tblImpoundReport.Controls.Add(lblOfficersInvolved, 0, 9);
            this.tblImpoundReport.Controls.Add(this.txtOfficersInvolved, 1, 9);
            this.tblImpoundReport.Controls.Add(this.btnGenImpoundReport, 0, 11);
            this.tblImpoundReport.Controls.Add(this.txtPhoneNumber, 1, 1);
            this.tblImpoundReport.Controls.Add(label3, 2, 6);
            this.tblImpoundReport.Controls.Add(this.txtTimestamp, 3, 6);
            this.tblImpoundReport.Controls.Add(label10, 0, 5);
            this.tblImpoundReport.Controls.Add(this.txtVehDetails, 1, 5);
            this.tblImpoundReport.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tblImpoundReport.Location = new System.Drawing.Point(3, 3);
            this.tblImpoundReport.Name = "tblImpoundReport";
            this.tblImpoundReport.RowCount = 12;
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblImpoundReport.Size = new System.Drawing.Size(786, 446);
            this.tblImpoundReport.TabIndex = 0;
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
            this.txtVehOwner.TextChanged += new System.EventHandler(this.Suspect_TextChanged);
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
            this.tblImpoundReport.SetColumnSpan(this.btnGenImpoundReport, 4);
            this.btnGenImpoundReport.Location = new System.Drawing.Point(3, 410);
            this.btnGenImpoundReport.Name = "btnGenImpoundReport";
            this.btnGenImpoundReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenImpoundReport.TabIndex = 11;
            this.btnGenImpoundReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenImpoundReport.UseVisualStyleBackColor = true;
            this.btnGenImpoundReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGenImpoundReport_MouseUp);
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
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSuspPhone_KeyPress);
            // 
            // txtTimestamp
            // 
            this.txtTimestamp.Location = new System.Drawing.Point(480, 159);
            this.txtTimestamp.Name = "txtTimestamp";
            this.txtTimestamp.Size = new System.Drawing.Size(165, 20);
            this.txtTimestamp.TabIndex = 23;
            this.txtTimestamp.TextChanged += new System.EventHandler(this.TxtTimestamp_TextChanged);
            this.txtTimestamp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSuspPhone_KeyPress);
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
            this.tabImpoundRelease.Controls.Add(this.tableLayoutPanel1);
            this.tabImpoundRelease.Location = new System.Drawing.Point(4, 22);
            this.tabImpoundRelease.Name = "tabImpoundRelease";
            this.tabImpoundRelease.Size = new System.Drawing.Size(792, 449);
            this.tabImpoundRelease.TabIndex = 2;
            this.tabImpoundRelease.Text = "Impound Release Report";
            this.tabImpoundRelease.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtRelOfficer, 1, 6);
            this.tableLayoutPanel1.Controls.Add(lblIrImpOfficer, 0, 6);
            this.tableLayoutPanel1.Controls.Add(lblIrImpDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtRelColour, 1, 4);
            this.tableLayoutPanel1.Controls.Add(lblIrColor, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtRelModel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(lblIrModel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtRelLicense, 1, 2);
            this.tableLayoutPanel1.Controls.Add(lblIrLicense, 0, 2);
            this.tableLayoutPanel1.Controls.Add(lblIrPhone, 0, 1);
            this.tableLayoutPanel1.Controls.Add(lblIrvehOwner, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRelVehOwner, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRelDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(lblIrFee, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnGenReleaseReport, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtRelFee, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtRelPhoneNum, 1, 1);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.txtRelVehOwner.TextChanged += new System.EventHandler(this.Suspect_TextChanged);
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
            this.tableLayoutPanel1.SetColumnSpan(this.btnGenReleaseReport, 3);
            this.btnGenReleaseReport.Location = new System.Drawing.Point(3, 211);
            this.btnGenReleaseReport.Name = "btnGenReleaseReport";
            this.btnGenReleaseReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenReleaseReport.TabIndex = 9;
            this.btnGenReleaseReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenReleaseReport.UseVisualStyleBackColor = true;
            this.btnGenReleaseReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGenReleaseReport_MouseUp);
            // 
            // txtRelFee
            // 
            this.txtRelFee.Location = new System.Drawing.Point(108, 185);
            this.txtRelFee.Name = "txtRelFee";
            this.txtRelFee.Size = new System.Drawing.Size(247, 20);
            this.txtRelFee.TabIndex = 8;
            this.txtRelFee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRelFee_KeyPress);
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
            this.txtRelPhoneNum.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // tabDutyReport
            // 
            this.tabDutyReport.Controls.Add(this.tableLayoutPanel4);
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
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.dtWatchStart, 1, 0);
            this.tableLayoutPanel4.Controls.Add(label11, 0, 3);
            this.tableLayoutPanel4.Controls.Add(label12, 0, 2);
            this.tableLayoutPanel4.Controls.Add(label13, 0, 1);
            this.tableLayoutPanel4.Controls.Add(label14, 0, 0);
            this.tableLayoutPanel4.Controls.Add(label15, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.btnGenDutyReport, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.txtNotes, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.dtWatchEnd, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.numArrests, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.numCitations, 1, 3);
            this.tableLayoutPanel4.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(786, 444);
            this.tableLayoutPanel4.TabIndex = 3;
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
            this.tableLayoutPanel4.SetColumnSpan(this.btnGenDutyReport, 2);
            this.btnGenDutyReport.Location = new System.Drawing.Point(3, 417);
            this.btnGenDutyReport.Name = "btnGenDutyReport";
            this.btnGenDutyReport.Size = new System.Drawing.Size(780, 23);
            this.btnGenDutyReport.TabIndex = 6;
            this.btnGenDutyReport.Text = "Generate Report on Clipboard (Right-click to clear form)";
            this.btnGenDutyReport.UseVisualStyleBackColor = true;
            this.btnGenDutyReport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnGenDutyReport_MouseUp);
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabImpoundReport.ResumeLayout(false);
            this.tblImpoundReport.ResumeLayout(false);
            this.tblImpoundReport.PerformLayout();
            this.tabImpoundRelease.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabDutyReport.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numArrests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCitations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabArrestReport;
        private System.Windows.Forms.TabPage tabImpoundReport;
        private System.Windows.Forms.TabPage tabImpoundRelease;
        private System.Windows.Forms.TableLayoutPanel tblImpoundReport;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtRelOfficer;
        private System.Windows.Forms.TextBox txtRelColour;
        private System.Windows.Forms.TextBox txtRelModel;
        private System.Windows.Forms.TextBox txtRelLicense;
        private System.Windows.Forms.TextBox txtRelVehOwner;
        private System.Windows.Forms.DateTimePicker txtRelDate;
        private System.Windows.Forms.Button btnGenReleaseReport;
        private System.Windows.Forms.TextBox txtRelFee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker dtWatchStart;
        private System.Windows.Forms.Button btnGenDutyReport;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.DateTimePicker dtWatchEnd;
        private System.Windows.Forms.NumericUpDown numArrests;
        private System.Windows.Forms.NumericUpDown numCitations;
        private System.Windows.Forms.TextBox txtTimestamp;
        private System.Windows.Forms.TextBox txtVehDetails;
        private System.Windows.Forms.Label label16;
    }
}

