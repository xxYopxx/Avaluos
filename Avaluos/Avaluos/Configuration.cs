using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaluos
{
    public partial class Configuration : Form
    {
        public Configuration()
        {
            InitializeComponent();
        }
        
        private void Configuration_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            txtDBLocation.Text = Properties.Settings.Default.sqliteFile;
            txtDocumentsLocation.Text = Properties.Settings.Default.documentRepo;
        }

        private void Configuration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.sqliteFile = txtDBLocation.Text;
            Properties.Settings.Default.documentRepo = txtDocumentsLocation.Text;
            Properties.Settings.Default.sqliteConnection = "Data Source=" + txtDBLocation.Text + ";Version=3;";
            Properties.Settings.Default.Save();
        }

        private void btnBrowseDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            browse.Title = "Buscar archivo de base de datos";
            browse.Filter = "Archivos DB (*.db)|*.db";
            browse.DefaultExt = "db";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                txtDBLocation.Text = browse.FileName;
            }
        }

        private void btnBrowseDocuments_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browse = new FolderBrowserDialog();
            browse.ShowNewFolderButton = true;
            if (browse.ShowDialog() == DialogResult.OK)
            {
                txtDocumentsLocation.Text = browse.SelectedPath;
            }
        }
    }
}
