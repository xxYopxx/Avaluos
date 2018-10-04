namespace Avaluos
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.subApplication_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.subApplication_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.subServices_New = new System.Windows.Forms.ToolStripMenuItem();
            this.subServices_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.subContacts_New = new System.Windows.Forms.ToolStripMenuItem();
            this.subContacts_Search = new System.Windows.Forms.ToolStripMenuItem();
            this.treeCurrent = new System.Windows.Forms.TreeView();
            this.pnlCurrent = new System.Windows.Forms.Panel();
            this.barStatus = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextListWindows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextListWindows_Remove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.barStatus.SuspendLayout();
            this.contextListWindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApplication,
            this.menuServices,
            this.menuContacts});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1059, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuApplication
            // 
            this.menuApplication.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subApplication_Settings,
            this.subApplication_Exit});
            this.menuApplication.Name = "menuApplication";
            this.menuApplication.Size = new System.Drawing.Size(75, 20);
            this.menuApplication.Text = "Aplicacion";
            // 
            // subApplication_Settings
            // 
            this.subApplication_Settings.Name = "subApplication_Settings";
            this.subApplication_Settings.Size = new System.Drawing.Size(150, 22);
            this.subApplication_Settings.Text = "Configuracion";
            this.subApplication_Settings.Click += new System.EventHandler(this.subApplication_Settings_Click);
            // 
            // subApplication_Exit
            // 
            this.subApplication_Exit.Name = "subApplication_Exit";
            this.subApplication_Exit.Size = new System.Drawing.Size(150, 22);
            this.subApplication_Exit.Text = "Salir";
            // 
            // menuServices
            // 
            this.menuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subServices_New,
            this.subServices_Search});
            this.menuServices.Name = "menuServices";
            this.menuServices.Size = new System.Drawing.Size(65, 20);
            this.menuServices.Text = "Servicios";
            // 
            // subServices_New
            // 
            this.subServices_New.Name = "subServices_New";
            this.subServices_New.Size = new System.Drawing.Size(180, 22);
            this.subServices_New.Text = "Nuevo";
            this.subServices_New.Click += new System.EventHandler(this.DisplayWindow);
            // 
            // subServices_Search
            // 
            this.subServices_Search.Name = "subServices_Search";
            this.subServices_Search.Size = new System.Drawing.Size(180, 22);
            this.subServices_Search.Text = "Buscar";
            this.subServices_Search.Click += new System.EventHandler(this.DisplayWindow);
            // 
            // menuContacts
            // 
            this.menuContacts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subContacts_New,
            this.subContacts_Search});
            this.menuContacts.Name = "menuContacts";
            this.menuContacts.Size = new System.Drawing.Size(73, 20);
            this.menuContacts.Text = "Contactos";
            // 
            // subContacts_New
            // 
            this.subContacts_New.Name = "subContacts_New";
            this.subContacts_New.Size = new System.Drawing.Size(109, 22);
            this.subContacts_New.Text = "Nuevo";
            this.subContacts_New.Click += new System.EventHandler(this.DisplayWindow);
            // 
            // subContacts_Search
            // 
            this.subContacts_Search.Name = "subContacts_Search";
            this.subContacts_Search.Size = new System.Drawing.Size(109, 22);
            this.subContacts_Search.Text = "Buscar";
            this.subContacts_Search.Click += new System.EventHandler(this.DisplayWindow);
            // 
            // treeCurrent
            // 
            this.treeCurrent.ContextMenuStrip = this.contextListWindows;
            this.treeCurrent.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeCurrent.HideSelection = false;
            this.treeCurrent.Location = new System.Drawing.Point(0, 24);
            this.treeCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.treeCurrent.Name = "treeCurrent";
            this.treeCurrent.Size = new System.Drawing.Size(139, 472);
            this.treeCurrent.TabIndex = 1;
            this.treeCurrent.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeCurrent_AfterSelect);
            // 
            // pnlCurrent
            // 
            this.pnlCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCurrent.Location = new System.Drawing.Point(139, 24);
            this.pnlCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCurrent.Name = "pnlCurrent";
            this.pnlCurrent.Size = new System.Drawing.Size(920, 472);
            this.pnlCurrent.TabIndex = 2;
            // 
            // barStatus
            // 
            this.barStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblCurrentStatus});
            this.barStatus.Location = new System.Drawing.Point(139, 474);
            this.barStatus.Name = "barStatus";
            this.barStatus.Size = new System.Drawing.Size(920, 22);
            this.barStatus.TabIndex = 3;
            this.barStatus.Text = "Barra de estado";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 17);
            this.lblStatus.Text = "Status: ";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(32, 17);
            this.lblCurrentStatus.Text = "Listo";
            // 
            // contextListWindows
            // 
            this.contextListWindows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextListWindows_Remove});
            this.contextListWindows.Name = "contextListWindows";
            this.contextListWindows.Size = new System.Drawing.Size(181, 48);
            // 
            // contextListWindows_Remove
            // 
            this.contextListWindows_Remove.Name = "contextListWindows_Remove";
            this.contextListWindows_Remove.Size = new System.Drawing.Size(180, 22);
            this.contextListWindows_Remove.Text = "Cerrar";
            this.contextListWindows_Remove.Click += new System.EventHandler(this.contextListWindows_Remove_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 496);
            this.Controls.Add(this.barStatus);
            this.Controls.Add(this.pnlCurrent);
            this.Controls.Add(this.treeCurrent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barStatus.ResumeLayout(false);
            this.barStatus.PerformLayout();
            this.contextListWindows.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuApplication;
        private System.Windows.Forms.ToolStripMenuItem subApplication_Exit;
        private System.Windows.Forms.TreeView treeCurrent;
        private System.Windows.Forms.Panel pnlCurrent;
        private System.Windows.Forms.ToolStripMenuItem subApplication_Settings;
        private System.Windows.Forms.ToolStripMenuItem menuServices;
        private System.Windows.Forms.ToolStripMenuItem subServices_New;
        private System.Windows.Forms.ToolStripMenuItem subServices_Search;
        private System.Windows.Forms.ToolStripMenuItem menuContacts;
        private System.Windows.Forms.ToolStripMenuItem subContacts_New;
        private System.Windows.Forms.ToolStripMenuItem subContacts_Search;
        private System.Windows.Forms.StatusStrip barStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentStatus;
        private System.Windows.Forms.ContextMenuStrip contextListWindows;
        private System.Windows.Forms.ToolStripMenuItem contextListWindows_Remove;
    }
}

