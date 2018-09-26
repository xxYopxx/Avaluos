namespace Avaluos
{
    partial class Configuration
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
            this.txtDBLocation = new System.Windows.Forms.TextBox();
            this.txtDocumentsLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseDB = new System.Windows.Forms.Button();
            this.btnBrowseDocuments = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowseDocuments);
            this.groupBox1.Controls.Add(this.btnBrowseDB);
            this.groupBox1.Controls.Add(this.txtDocumentsLocation);
            this.groupBox1.Controls.Add(this.txtDBLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base de datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Raiz de Documentos";
            // 
            // txtDBLocation
            // 
            this.txtDBLocation.Location = new System.Drawing.Point(151, 33);
            this.txtDBLocation.Name = "txtDBLocation";
            this.txtDBLocation.Size = new System.Drawing.Size(386, 22);
            this.txtDBLocation.TabIndex = 2;
            // 
            // txtDocumentsLocation
            // 
            this.txtDocumentsLocation.Location = new System.Drawing.Point(151, 70);
            this.txtDocumentsLocation.Name = "txtDocumentsLocation";
            this.txtDocumentsLocation.Size = new System.Drawing.Size(386, 22);
            this.txtDocumentsLocation.TabIndex = 3;
            // 
            // btnBrowseDB
            // 
            this.btnBrowseDB.Location = new System.Drawing.Point(550, 33);
            this.btnBrowseDB.Name = "btnBrowseDB";
            this.btnBrowseDB.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDB.TabIndex = 4;
            this.btnBrowseDB.Text = "Buscar";
            this.btnBrowseDB.UseVisualStyleBackColor = true;
            this.btnBrowseDB.Click += new System.EventHandler(this.btnBrowseDB_Click);
            // 
            // btnBrowseDocuments
            // 
            this.btnBrowseDocuments.Location = new System.Drawing.Point(550, 70);
            this.btnBrowseDocuments.Name = "btnBrowseDocuments";
            this.btnBrowseDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDocuments.TabIndex = 5;
            this.btnBrowseDocuments.Text = "Buscar";
            this.btnBrowseDocuments.UseVisualStyleBackColor = true;
            this.btnBrowseDocuments.Click += new System.EventHandler(this.btnBrowseDocuments_Click);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 168);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuration_FormClosing);
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowseDocuments;
        private System.Windows.Forms.Button btnBrowseDB;
        private System.Windows.Forms.TextBox txtDocumentsLocation;
        private System.Windows.Forms.TextBox txtDBLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}