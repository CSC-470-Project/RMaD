using RMaD.Classes;

namespace RMaD
{
    partial class UxForm
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
            if (disposing && (components != null))
            {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxForm));
            this.pnlShipments = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewShipment = new System.Windows.Forms.DataGridView();
            this.btnAddShipment = new System.Windows.Forms.Button();
            this.lblShipments = new System.Windows.Forms.Label();
            this.pnlGroups = new System.Windows.Forms.Panel();
            this.lblGroups = new System.Windows.Forms.Label();
            this.imageIcons = new System.Windows.Forms.ImageList(this.components);
            this.pnlReports = new System.Windows.Forms.Panel();
            this.lblEplanation = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.dgReport = new System.Windows.Forms.DataGridView();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblReports = new System.Windows.Forms.Label();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.pbProfilePic = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.lblSettins = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnSettingsMenu = new System.Windows.Forms.Button();
            this.btnUserMenu = new System.Windows.Forms.Button();
            this.btnReportsMenu = new System.Windows.Forms.Button();
            this.btnGroupMenu = new System.Windows.Forms.Button();
            this.btnShipmentMenu = new System.Windows.Forms.Button();
            this.pnlShipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipment)).BeginInit();
            this.pnlGroups.SuspendLayout();
            this.pnlReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).BeginInit();
            this.pnlSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShipments
            // 
            this.pnlShipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShipments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlShipments.Controls.Add(this.dataGridViewShipment);
            this.pnlShipments.Controls.Add(this.btnEdit);
            this.pnlShipments.Controls.Add(this.btnRemove);
            this.pnlShipments.Controls.Add(this.btnRefresh);
            this.pnlShipments.Controls.Add(this.btnAddShipment);
            this.pnlShipments.Controls.Add(this.lblShipments);
            this.pnlShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlShipments.Location = new System.Drawing.Point(77, 2);
            this.pnlShipments.Name = "pnlShipments";
            this.pnlShipments.Size = new System.Drawing.Size(580, 707);
            this.pnlShipments.TabIndex = 0;
            this.pnlShipments.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShipments_Paint);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(163, 636);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 43);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit Shipment";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(290, 636);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 43);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Shipment";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Image = global::RMaD.Properties.Resources.Refresh;
            this.btnRefresh.Location = new System.Drawing.Point(508, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(40, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewShipment
            // 
            this.dataGridViewShipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewShipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewShipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewShipment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShipment.Location = new System.Drawing.Point(3, 57);
            this.dataGridViewShipment.Name = "dataGridViewShipment";
            this.dataGridViewShipment.ReadOnly = true;
            this.dataGridViewShipment.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShipment.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShipment.Size = new System.Drawing.Size(574, 563);
            this.dataGridViewShipment.TabIndex = 2;
            // 
            // btnAddShipment
            // 
            this.btnAddShipment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddShipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShipment.Location = new System.Drawing.Point(31, 636);
            this.btnAddShipment.Name = "btnAddShipment";
            this.btnAddShipment.Size = new System.Drawing.Size(126, 43);
            this.btnAddShipment.TabIndex = 1;
            this.btnAddShipment.Text = "Add Shipment";
            this.btnAddShipment.UseVisualStyleBackColor = true;
            this.btnAddShipment.Click += new System.EventHandler(this.btnAddShipment_Click);
            // 
            // lblShipments
            // 
            this.lblShipments.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipments.Location = new System.Drawing.Point(30, 8);
            this.lblShipments.Name = "lblShipments";
            this.lblShipments.Size = new System.Drawing.Size(180, 42);
            this.lblShipments.TabIndex = 0;
            this.lblShipments.Text = "Shipments";
            // 
            // pnlGroups
            // 
            this.pnlGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGroups.Controls.Add(this.lblGroups);
            this.pnlGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlGroups.Location = new System.Drawing.Point(77, 2);
            this.pnlGroups.Name = "pnlGroups";
            this.pnlGroups.Size = new System.Drawing.Size(580, 707);
            this.pnlGroups.TabIndex = 1;
            // 
            // lblGroups
            // 
            this.lblGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroups.Location = new System.Drawing.Point(30, 27);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(127, 42);
            this.lblGroups.TabIndex = 0;
            this.lblGroups.Text = "Groups";
            // 
            // imageIcons
            // 
            this.imageIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageIcons.ImageStream")));
            this.imageIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageIcons.Images.SetKeyName(0, "ShipmentMenu.png");
            this.imageIcons.Images.SetKeyName(1, "GroupMenu.png");
            this.imageIcons.Images.SetKeyName(2, "ReportMenu.png");
            this.imageIcons.Images.SetKeyName(3, "UserMenu.png");
            this.imageIcons.Images.SetKeyName(4, "Settings.png");
            // 
            // pnlReports
            // 
            this.pnlReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReports.Controls.Add(this.lblEplanation);
            this.pnlReports.Controls.Add(this.btnSearch);
            this.pnlReports.Controls.Add(this.lblEndDate);
            this.pnlReports.Controls.Add(this.lblStart);
            this.pnlReports.Controls.Add(this.dgReport);
            this.pnlReports.Controls.Add(this.dtEndDate);
            this.pnlReports.Controls.Add(this.dtStartDate);
            this.pnlReports.Controls.Add(this.lblReports);
            this.pnlReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlReports.Location = new System.Drawing.Point(77, 2);
            this.pnlReports.Name = "pnlReports";
            this.pnlReports.Size = new System.Drawing.Size(580, 707);
            this.pnlReports.TabIndex = 2;
            // 
            // lblEplanation
            // 
            this.lblEplanation.AutoSize = true;
            this.lblEplanation.Location = new System.Drawing.Point(150, 100);
            this.lblEplanation.Name = "lblEplanation";
            this.lblEplanation.Size = new System.Drawing.Size(269, 24);
            this.lblEplanation.TabIndex = 9;
            this.lblEplanation.Text = "Get Shipments Between Dates:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(211, 269);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 35);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Generate Data";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(107, 198);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 7;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(107, 158);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(94, 24);
            this.lblStart.TabIndex = 6;
            this.lblStart.Text = "Start Date:";
            // 
            // dgReport
            // 
            this.dgReport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.GridColor = System.Drawing.SystemColors.Control;
            this.dgReport.Location = new System.Drawing.Point(10, 331);
            this.dgReport.Name = "dgReport";
            this.dgReport.Size = new System.Drawing.Size(558, 373);
            this.dgReport.TabIndex = 5;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(219, 193);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(200, 26);
            this.dtEndDate.TabIndex = 4;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(219, 158);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 26);
            this.dtStartDate.TabIndex = 3;
            // 
            // lblReports
            // 
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(30, 27);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(127, 42);
            this.lblReports.TabIndex = 0;
            this.lblReports.Text = "Reports";
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.Controls.Add(this.btnCancelEdit);
            this.pnlUser.Controls.Add(this.btnEditUser);
            this.pnlUser.Controls.Add(this.tbToken);
            this.pnlUser.Controls.Add(this.tbEmail);
            this.pnlUser.Controls.Add(this.tbLastname);
            this.pnlUser.Controls.Add(this.tbFirstname);
            this.pnlUser.Controls.Add(this.lblToken);
            this.pnlUser.Controls.Add(this.lblEmail);
            this.pnlUser.Controls.Add(this.lblLastname);
            this.pnlUser.Controls.Add(this.lblFirstname);
            this.pnlUser.Controls.Add(this.pbProfilePic);
            this.pnlUser.Controls.Add(this.lblUser);
            this.pnlUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlUser.Location = new System.Drawing.Point(77, 2);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(580, 707);
            this.pnlUser.TabIndex = 3;
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Location = new System.Drawing.Point(292, 474);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(80, 33);
            this.btnCancelEdit.TabIndex = 11;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(211, 474);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 33);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // tbToken
            // 
            this.tbToken.Location = new System.Drawing.Point(211, 415);
            this.tbToken.Name = "tbToken";
            this.tbToken.ReadOnly = true;
            this.tbToken.Size = new System.Drawing.Size(233, 29);
            this.tbToken.TabIndex = 9;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(211, 380);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(233, 29);
            this.tbEmail.TabIndex = 8;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(211, 345);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.ReadOnly = true;
            this.tbLastname.Size = new System.Drawing.Size(233, 29);
            this.tbLastname.TabIndex = 7;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(211, 310);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.ReadOnly = true;
            this.tbFirstname.Size = new System.Drawing.Size(233, 29);
            this.tbFirstname.TabIndex = 6;
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(89, 420);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(69, 24);
            this.lblToken.TabIndex = 5;
            this.lblToken.Text = "Token:";
            this.lblToken.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(89, 385);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 24);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Location = new System.Drawing.Point(89, 350);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(96, 24);
            this.lblLastname.TabIndex = 3;
            this.lblLastname.Text = "Lastname:";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Location = new System.Drawing.Point(89, 315);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(98, 24);
            this.lblFirstname.TabIndex = 2;
            this.lblFirstname.Text = "Firstname:";
            this.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbProfilePic
            // 
            this.pbProfilePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProfilePic.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePic.Image")));
            this.pbProfilePic.Location = new System.Drawing.Point(225, 118);
            this.pbProfilePic.MaximumSize = new System.Drawing.Size(128, 125);
            this.pbProfilePic.MinimumSize = new System.Drawing.Size(128, 125);
            this.pbProfilePic.Name = "pbProfilePic";
            this.pbProfilePic.Size = new System.Drawing.Size(128, 125);
            this.pbProfilePic.TabIndex = 1;
            this.pbProfilePic.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(156, 246);
            this.lblUser.MinimumSize = new System.Drawing.Size(166, 38);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(263, 38);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Username";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSettings.Controls.Add(this.lblSettins);
            this.pnlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSettings.Location = new System.Drawing.Point(77, 2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(580, 707);
            this.pnlSettings.TabIndex = 4;
            // 
            // lblSettins
            // 
            this.lblSettins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettins.Location = new System.Drawing.Point(30, 27);
            this.lblSettins.Name = "lblSettins";
            this.lblSettins.Size = new System.Drawing.Size(137, 42);
            this.lblSettins.TabIndex = 0;
            this.lblSettins.Text = "Settings";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnSettingsMenu
            // 
            this.btnSettingsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSettingsMenu.ImageIndex = 4;
            this.btnSettingsMenu.ImageList = this.imageIcons;
            this.btnSettingsMenu.Location = new System.Drawing.Point(-1, 659);
            this.btnSettingsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettingsMenu.Name = "btnSettingsMenu";
            this.btnSettingsMenu.Size = new System.Drawing.Size(75, 50);
            this.btnSettingsMenu.TabIndex = 5;
            this.btnSettingsMenu.UseVisualStyleBackColor = true;
            this.btnSettingsMenu.Click += new System.EventHandler(this.btnSettingsMenu_Click);
            // 
            // btnUserMenu
            // 
            this.btnUserMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUserMenu.ImageIndex = 3;
            this.btnUserMenu.ImageList = this.imageIcons;
            this.btnUserMenu.Location = new System.Drawing.Point(-1, 609);
            this.btnUserMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnUserMenu.Name = "btnUserMenu";
            this.btnUserMenu.Size = new System.Drawing.Size(75, 50);
            this.btnUserMenu.TabIndex = 75;
            this.btnUserMenu.UseVisualStyleBackColor = true;
            this.btnUserMenu.Click += new System.EventHandler(this.btnUserMenu_Click);
            // 
            // btnReportsMenu
            // 
            this.btnReportsMenu.ImageIndex = 2;
            this.btnReportsMenu.ImageList = this.imageIcons;
            this.btnReportsMenu.Location = new System.Drawing.Point(-1, 102);
            this.btnReportsMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnReportsMenu.Name = "btnReportsMenu";
            this.btnReportsMenu.Size = new System.Drawing.Size(75, 50);
            this.btnReportsMenu.TabIndex = 3;
            this.btnReportsMenu.UseVisualStyleBackColor = true;
            this.btnReportsMenu.Click += new System.EventHandler(this.btnReportsMenu_Click);
            // 
            // btnGroupMenu
            // 
            this.btnGroupMenu.ImageIndex = 1;
            this.btnGroupMenu.ImageList = this.imageIcons;
            this.btnGroupMenu.Location = new System.Drawing.Point(-1, 52);
            this.btnGroupMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnGroupMenu.Name = "btnGroupMenu";
            this.btnGroupMenu.Size = new System.Drawing.Size(75, 50);
            this.btnGroupMenu.TabIndex = 2;
            this.btnGroupMenu.UseVisualStyleBackColor = true;
            this.btnGroupMenu.Click += new System.EventHandler(this.btnGroupMenu_Click);
            // 
            // btnShipmentMenu
            // 
            this.btnShipmentMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btnShipmentMenu.ImageIndex = 0;
            this.btnShipmentMenu.ImageList = this.imageIcons;
            this.btnShipmentMenu.Location = new System.Drawing.Point(-1, 2);
            this.btnShipmentMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btnShipmentMenu.Name = "btnShipmentMenu";
            this.btnShipmentMenu.Size = new System.Drawing.Size(75, 50);
            this.btnShipmentMenu.TabIndex = 1;
            this.btnShipmentMenu.UseVisualStyleBackColor = false;
            this.btnShipmentMenu.Click += new System.EventHandler(this.btnShipmentMenu_Click);
            // 
            // UxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(657, 709);
            this.Controls.Add(this.btnSettingsMenu);
            this.Controls.Add(this.btnUserMenu);
            this.Controls.Add(this.btnReportsMenu);
            this.Controls.Add(this.btnGroupMenu);
            this.Controls.Add(this.btnShipmentMenu);
            this.Controls.Add(this.pnlReports);
            this.Controls.Add(this.pnlGroups);
            this.Controls.Add(this.pnlShipments);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UxForm_Load);
            this.pnlShipments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShipment)).EndInit();
            this.pnlGroups.ResumeLayout(false);
            this.pnlReports.ResumeLayout(false);
            this.pnlReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfilePic)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShipments;
        private System.Windows.Forms.Label lblShipments;
        private System.Windows.Forms.Button btnShipmentMenu;
        private System.Windows.Forms.Button btnGroupMenu;
        private System.Windows.Forms.Button btnReportsMenu;
        private System.Windows.Forms.Button btnUserMenu;
        private System.Windows.Forms.Button btnSettingsMenu;
        private System.Windows.Forms.Panel pnlGroups;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.Panel pnlReports;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Label lblSettins;
        private System.Windows.Forms.Button btnAddShipment;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.DataGridView dataGridViewShipment;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ImageList imageIcons;
        private System.Windows.Forms.PictureBox pbProfilePic;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DataGridView dgReport;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblEplanation;
        private System.Windows.Forms.Button btnSearch;
    }
}