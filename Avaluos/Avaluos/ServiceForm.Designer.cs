namespace Avaluos
{
    partial class ServiceForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listDocuments = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnRemoveDocument = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listPayments = new System.Windows.Forms.ListView();
            this.colAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNewPayment = new System.Windows.Forms.TextBox();
            this.ddlResponsible = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlServiceType = new System.Windows.Forms.ComboBox();
            this.dteVisit = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.ddlContact_Seller = new System.Windows.Forms.ComboBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.ddlContact_Client = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblContact_Seller = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.ddlResponsible);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ddlServiceType);
            this.groupBox1.Controls.Add(this.dteVisit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.ddlContact_Seller);
            this.groupBox1.Controls.Add(this.ddlStatus);
            this.groupBox1.Controls.Add(this.ddlContact_Client);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblContact_Seller);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(900, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaluo Catastral";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Titulo";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(422, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 386);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listDocuments);
            this.tabPage1.Controls.Add(this.btnAddDocument);
            this.tabPage1.Controls.Add(this.btnRemoveDocument);
            this.tabPage1.Controls.Add(this.btnOpenFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Documentos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listDocuments
            // 
            this.listDocuments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colType});
            this.listDocuments.FullRowSelect = true;
            this.listDocuments.GridLines = true;
            this.listDocuments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listDocuments.HideSelection = false;
            this.listDocuments.Location = new System.Drawing.Point(10, 15);
            this.listDocuments.MultiSelect = false;
            this.listDocuments.Name = "listDocuments";
            this.listDocuments.Size = new System.Drawing.Size(293, 339);
            this.listDocuments.TabIndex = 17;
            this.listDocuments.UseCompatibleStateImageBehavior = false;
            this.listDocuments.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            // 
            // colType
            // 
            this.colType.Text = "Tipo";
            this.colType.Width = 218;
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Location = new System.Drawing.Point(309, 82);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(75, 23);
            this.btnAddDocument.TabIndex = 18;
            this.btnAddDocument.Text = "Agregar";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnRemoveDocument
            // 
            this.btnRemoveDocument.Location = new System.Drawing.Point(309, 111);
            this.btnRemoveDocument.Name = "btnRemoveDocument";
            this.btnRemoveDocument.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDocument.TabIndex = 19;
            this.btnRemoveDocument.Text = "Remover";
            this.btnRemoveDocument.UseVisualStyleBackColor = true;
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(309, 15);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 20;
            this.btnOpenFolder.Text = "Abrir Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listPayments);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtAmountTotal);
            this.tabPage2.Controls.Add(this.txtToPay);
            this.tabPage2.Controls.Add(this.btnPayment);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtNewPayment);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listPayments
            // 
            this.listPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAmount,
            this.colDate});
            this.listPayments.GridLines = true;
            this.listPayments.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPayments.HideSelection = false;
            this.listPayments.Location = new System.Drawing.Point(10, 15);
            this.listPayments.MultiSelect = false;
            this.listPayments.Name = "listPayments";
            this.listPayments.Size = new System.Drawing.Size(271, 339);
            this.listPayments.TabIndex = 27;
            this.listPayments.UseCompatibleStateImageBehavior = false;
            this.listPayments.View = System.Windows.Forms.View.Details;
            // 
            // colAmount
            // 
            this.colAmount.Text = "Monto";
            this.colAmount.Width = 74;
            // 
            // colDate
            // 
            this.colDate.Text = "Fecha";
            this.colDate.Width = 119;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Por pagar";
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.Location = new System.Drawing.Point(369, 106);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.Size = new System.Drawing.Size(90, 20);
            this.txtAmountTotal.TabIndex = 13;
            this.txtAmountTotal.TextChanged += new System.EventHandler(this.AllowOnlyNumbers);
            this.txtAmountTotal.Enter += new System.EventHandler(this.txtAmountTotal_Enter);
            // 
            // txtToPay
            // 
            this.txtToPay.Location = new System.Drawing.Point(369, 132);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.ReadOnly = true;
            this.txtToPay.Size = new System.Drawing.Size(90, 20);
            this.txtToPay.TabIndex = 15;
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(384, 36);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(75, 23);
            this.btnPayment.TabIndex = 30;
            this.btnPayment.Text = "Abonar";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(310, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Pago";
            // 
            // txtNewPayment
            // 
            this.txtNewPayment.Location = new System.Drawing.Point(348, 10);
            this.txtNewPayment.Name = "txtNewPayment";
            this.txtNewPayment.Size = new System.Drawing.Size(111, 20);
            this.txtNewPayment.TabIndex = 29;
            this.txtNewPayment.TextChanged += new System.EventHandler(this.AllowOnlyNumbers);
            this.txtNewPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewPayment_KeyPress);
            // 
            // ddlResponsible
            // 
            this.ddlResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlResponsible.FormattingEnabled = true;
            this.ddlResponsible.Location = new System.Drawing.Point(104, 203);
            this.ddlResponsible.Name = "ddlResponsible";
            this.ddlResponsible.Size = new System.Drawing.Size(155, 21);
            this.ddlResponsible.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Responsable";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Tipo de Servicio";
            // 
            // ddlServiceType
            // 
            this.ddlServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlServiceType.FormattingEnabled = true;
            this.ddlServiceType.Location = new System.Drawing.Point(96, 92);
            this.ddlServiceType.Name = "ddlServiceType";
            this.ddlServiceType.Size = new System.Drawing.Size(133, 21);
            this.ddlServiceType.TabIndex = 31;
            this.ddlServiceType.SelectedIndexChanged += new System.EventHandler(this.ddlServiceType_SelectedIndexChanged);
            // 
            // dteVisit
            // 
            this.dteVisit.CustomFormat = "dd/MMM/yyyy";
            this.dteVisit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteVisit.Location = new System.Drawing.Point(133, 177);
            this.dteVisit.Name = "dteVisit";
            this.dteVisit.Size = new System.Drawing.Size(126, 20);
            this.dteVisit.TabIndex = 24;
            this.dteVisit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dteVisit_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fecha de Visita";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(792, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(8, 297);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(374, 103);
            this.txtNotes.TabIndex = 16;
            // 
            // ddlContact_Seller
            // 
            this.ddlContact_Seller.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlContact_Seller.FormattingEnabled = true;
            this.ddlContact_Seller.Location = new System.Drawing.Point(69, 146);
            this.ddlContact_Seller.Name = "ddlContact_Seller";
            this.ddlContact_Seller.Size = new System.Drawing.Size(190, 21);
            this.ddlContact_Seller.TabIndex = 14;
            // 
            // ddlStatus
            // 
            this.ddlStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(283, 92);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(113, 21);
            this.ddlStatus.TabIndex = 11;
            // 
            // ddlContact_Client
            // 
            this.ddlContact_Client.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlContact_Client.FormattingEnabled = true;
            this.ddlContact_Client.Location = new System.Drawing.Point(55, 119);
            this.ddlContact_Client.Name = "ddlContact_Client";
            this.ddlContact_Client.Size = new System.Drawing.Size(204, 21);
            this.ddlContact_Client.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Notas";
            // 
            // lblContact_Seller
            // 
            this.lblContact_Seller.AutoSize = true;
            this.lblContact_Seller.Location = new System.Drawing.Point(10, 149);
            this.lblContact_Seller.Name = "lblContact_Seller";
            this.lblContact_Seller.Size = new System.Drawing.Size(53, 13);
            this.lblContact_Seller.TabIndex = 7;
            this.lblContact_Seller.Text = "Vendedor";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(29, 27);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(61, 20);
            this.txtID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estatus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // ServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 470);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "svcAC";
            this.Load += new System.EventHandler(this.svcAC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.ComboBox ddlContact_Client;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblContact_Seller;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listDocuments;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtToPay;
        private System.Windows.Forms.ComboBox ddlContact_Seller;
        private System.Windows.Forms.Button btnRemoveDocument;
        private System.Windows.Forms.Button btnAddDocument;
        private System.Windows.Forms.DateTimePicker dteVisit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ListView listPayments;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.TextBox txtNewPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ColumnHeader colAmount;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ddlServiceType;
        private System.Windows.Forms.ComboBox ddlResponsible;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}