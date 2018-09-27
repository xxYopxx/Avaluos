namespace Avaluos
{
    partial class svcAC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlContact_Client = new System.Windows.Forms.ComboBox();
            this.ddlStatus = new System.Windows.Forms.ComboBox();
            this.txtAmountPaid = new System.Windows.Forms.TextBox();
            this.txtAmountTotal = new System.Windows.Forms.TextBox();
            this.ddlContact_Seller = new System.Windows.Forms.ComboBox();
            this.txtToPay = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.listDocuments = new System.Windows.Forms.ListView();
            this.btnAddDocument = new System.Windows.Forms.Button();
            this.btnRemoveDocument = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveDocument);
            this.groupBox1.Controls.Add(this.btnAddDocument);
            this.groupBox1.Controls.Add(this.listDocuments);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.txtToPay);
            this.groupBox1.Controls.Add(this.ddlContact_Seller);
            this.groupBox1.Controls.Add(this.txtAmountTotal);
            this.groupBox1.Controls.Add(this.txtAmountPaid);
            this.groupBox1.Controls.Add(this.ddlStatus);
            this.groupBox1.Controls.Add(this.ddlContact_Client);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(900, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avaluo Catastral";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estatus";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(29, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad pagada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Por pagar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vendedor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Notas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Documentos";
            // 
            // ddlContact_Client
            // 
            this.ddlContact_Client.FormattingEnabled = true;
            this.ddlContact_Client.Location = new System.Drawing.Point(50, 60);
            this.ddlContact_Client.Name = "ddlContact_Client";
            this.ddlContact_Client.Size = new System.Drawing.Size(204, 21);
            this.ddlContact_Client.TabIndex = 10;
            // 
            // ddlStatus
            // 
            this.ddlStatus.FormattingEnabled = true;
            this.ddlStatus.Location = new System.Drawing.Point(472, 27);
            this.ddlStatus.Name = "ddlStatus";
            this.ddlStatus.Size = new System.Drawing.Size(136, 21);
            this.ddlStatus.TabIndex = 11;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Location = new System.Drawing.Point(518, 60);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Size = new System.Drawing.Size(90, 20);
            this.txtAmountPaid.TabIndex = 12;
            // 
            // txtAmountTotal
            // 
            this.txtAmountTotal.Location = new System.Drawing.Point(518, 86);
            this.txtAmountTotal.Name = "txtAmountTotal";
            this.txtAmountTotal.Size = new System.Drawing.Size(90, 20);
            this.txtAmountTotal.TabIndex = 13;
            // 
            // ddlContact_Seller
            // 
            this.ddlContact_Seller.FormattingEnabled = true;
            this.ddlContact_Seller.Location = new System.Drawing.Point(64, 87);
            this.ddlContact_Seller.Name = "ddlContact_Seller";
            this.ddlContact_Seller.Size = new System.Drawing.Size(190, 21);
            this.ddlContact_Seller.TabIndex = 14;
            // 
            // txtToPay
            // 
            this.txtToPay.Location = new System.Drawing.Point(518, 112);
            this.txtToPay.Name = "txtToPay";
            this.txtToPay.Size = new System.Drawing.Size(90, 20);
            this.txtToPay.TabIndex = 15;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(8, 229);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(388, 215);
            this.txtNotes.TabIndex = 16;
            // 
            // listDocuments
            // 
            this.listDocuments.Location = new System.Drawing.Point(427, 159);
            this.listDocuments.Name = "listDocuments";
            this.listDocuments.Size = new System.Drawing.Size(387, 285);
            this.listDocuments.TabIndex = 17;
            this.listDocuments.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddDocument
            // 
            this.btnAddDocument.Location = new System.Drawing.Point(820, 159);
            this.btnAddDocument.Name = "btnAddDocument";
            this.btnAddDocument.Size = new System.Drawing.Size(75, 23);
            this.btnAddDocument.TabIndex = 18;
            this.btnAddDocument.Text = "Agregar";
            this.btnAddDocument.UseVisualStyleBackColor = true;
            this.btnAddDocument.Click += new System.EventHandler(this.btnAddDocument_Click);
            // 
            // btnRemoveDocument
            // 
            this.btnRemoveDocument.Location = new System.Drawing.Point(820, 227);
            this.btnRemoveDocument.Name = "btnRemoveDocument";
            this.btnRemoveDocument.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveDocument.TabIndex = 19;
            this.btnRemoveDocument.Text = "Remover";
            this.btnRemoveDocument.UseVisualStyleBackColor = true;
            // 
            // svcAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 470);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "svcAC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "svcAC";
            this.Load += new System.EventHandler(this.svcAC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmountTotal;
        private System.Windows.Forms.TextBox txtAmountPaid;
        private System.Windows.Forms.ComboBox ddlStatus;
        private System.Windows.Forms.ComboBox ddlContact_Client;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
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
    }
}