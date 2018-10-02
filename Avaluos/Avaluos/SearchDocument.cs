using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaluos
{
    public partial class SearchDocument : Form
    {
        #region Private members

        private Document _document;

        #endregion

        #region Public properties

        public Document AddedDocument { get { return _document; } }

        #endregion
        public SearchDocument()
        {
            InitializeComponent();
        }

        #region Functionality

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Title = "Buscar documento";
            browse.Filter = "Todos los archivos (*.*)|*.*";
            browse.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (browse.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(browse.FileName))
                {
                    txtDocumentDirectory.Text = browse.FileName;
                    _document.Directory = browse.FileName;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _document.DocumentType = _document.ConvertFromInt(Convert.ToInt32(ddlDocumentType.SelectedValue));
            Close();
        }

        private void FillDocumentTypeList()
        {
            ddlDocumentType.DataSource = new BindingSource(_document.DocumentTypeList, null);
            ddlDocumentType.DisplayMember = "Value";
            ddlDocumentType.ValueMember = "Key";
        }


        #endregion

        private void SearchDocument_Load(object sender, EventArgs e)
        {
            _document = new Document();
            FillDocumentTypeList();
        }
    }
}
