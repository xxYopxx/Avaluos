namespace Avaluos
{
    partial class ServiceSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkServiceType = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listResults = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colService = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.chkDateEnd = new System.Windows.Forms.CheckBox();
            this.chkDateStart = new System.Windows.Forms.CheckBox();
            this.chkDateVisit = new System.Windows.Forms.CheckBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpVisit = new System.Windows.Forms.DateTimePicker();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.ddlServiceType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSeller = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.chkServiceType);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.listResults);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Controls.Add(this.chkDateEnd);
            this.groupBox1.Controls.Add(this.chkDateStart);
            this.groupBox1.Controls.Add(this.chkDateVisit);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.dtpVisit);
            this.groupBox1.Controls.Add(this.ddlStatus);
            this.groupBox1.Controls.Add(this.ddlServiceType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSeller);
            this.groupBox1.Controls.Add(this.txtClient);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 436);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Servicios";
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(288, 56);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(61, 17);
            this.chkStatus.TabIndex = 20;
            this.chkStatus.Text = "Estatus";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkServiceType
            // 
            this.chkServiceType.AutoSize = true;
            this.chkServiceType.Location = new System.Drawing.Point(288, 32);
            this.chkServiceType.Name = "chkServiceType";
            this.chkServiceType.Size = new System.Drawing.Size(103, 17);
            this.chkServiceType.TabIndex = 19;
            this.chkServiceType.Text = "Tipo de Servicio";
            this.chkServiceType.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(815, 123);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(734, 123);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listResults
            // 
            this.listResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colService,
            this.colClient,
            this.colStatus,
            this.colDateStart});
            this.listResults.GridLines = true;
            this.listResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listResults.HideSelection = false;
            this.listResults.Location = new System.Drawing.Point(6, 152);
            this.listResults.MultiSelect = false;
            this.listResults.Name = "listResults";
            this.listResults.Size = new System.Drawing.Size(884, 278);
            this.listResults.TabIndex = 16;
            this.listResults.UseCompatibleStateImageBehavior = false;
            this.listResults.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colService
            // 
            this.colService.Text = "Servicio";
            this.colService.Width = 150;
            // 
            // colClient
            // 
            this.colClient.Text = "Cliente";
            this.colClient.Width = 247;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Estatus";
            this.colStatus.Width = 237;
            // 
            // colDateStart
            // 
            this.colDateStart.Text = "Fecha Solicitud";
            this.colDateStart.Width = 173;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MMM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(718, 82);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(130, 20);
            this.dtpEnd.TabIndex = 15;
            // 
            // chkDateEnd
            // 
            this.chkDateEnd.AutoSize = true;
            this.chkDateEnd.Location = new System.Drawing.Point(601, 82);
            this.chkDateEnd.Name = "chkDateEnd";
            this.chkDateEnd.Size = new System.Drawing.Size(111, 17);
            this.chkDateEnd.TabIndex = 14;
            this.chkDateEnd.Text = "Fecha de Entrega";
            this.chkDateEnd.UseVisualStyleBackColor = true;
            // 
            // chkDateStart
            // 
            this.chkDateStart.AutoSize = true;
            this.chkDateStart.Location = new System.Drawing.Point(601, 56);
            this.chkDateStart.Name = "chkDateStart";
            this.chkDateStart.Size = new System.Drawing.Size(114, 17);
            this.chkDateStart.TabIndex = 13;
            this.chkDateStart.Text = "Fecha de Solicitud";
            this.chkDateStart.UseVisualStyleBackColor = true;
            // 
            // chkDateVisit
            // 
            this.chkDateVisit.AutoSize = true;
            this.chkDateVisit.Location = new System.Drawing.Point(601, 33);
            this.chkDateVisit.Name = "chkDateVisit";
            this.chkDateVisit.Size = new System.Drawing.Size(99, 17);
            this.chkDateVisit.TabIndex = 12;
            this.chkDateVisit.Text = "Fecha de Visita";
            this.chkDateVisit.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MMM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(721, 56);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(127, 20);
            this.dtpStart.TabIndex = 11;
            // 
            // dtpVisit
            // 
            this.dtpVisit.CustomFormat = "dd/MMM/yyyy";
            this.dtpVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVisit.Location = new System.Drawing.Point(706, 30);
            this.dtpVisit.Name = "dtpVisit";
            this.dtpVisit.Size = new System.Drawing.Size(120, 20);
            this.dtpVisit.TabIndex = 8;
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(355, 55);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(227, 21);
            this.ddlStatus.TabIndex = 7;
            // 
            // ddlServiceType
            // 
            this.ddlServiceType.FormattingEnabled = true;
            this.ddlServiceType.Location = new System.Drawing.Point(397, 29);
            this.ddlServiceType.Name = "ddlServiceType";
            this.ddlServiceType.Size = new System.Drawing.Size(185, 21);
            this.ddlServiceType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendedor";
            // 
            // txtSeller
            // 
            this.txtSeller.Location = new System.Drawing.Point(65, 56);
            this.txtSeller.Name = "txtSeller";
            this.txtSeller.Size = new System.Drawing.Size(185, 20);
            this.txtSeller.TabIndex = 2;
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(51, 30);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(199, 20);
            this.txtClient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // ServiceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 470);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServiceSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchServices";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSeller;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpVisit;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.ComboBox ddlServiceType;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkServiceType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listResults;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colService;
        private System.Windows.Forms.ColumnHeader colClient;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colDateStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.CheckBox chkDateEnd;
        private System.Windows.Forms.CheckBox chkDateStart;
        private System.Windows.Forms.CheckBox chkDateVisit;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}