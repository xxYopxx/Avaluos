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
    public partial class Contacts : Form
    {
        #region Private members

        int _sak;
        Contact _currentContact;

        #endregion

        #region Public properties

        public int ID
        {
            get { return _sak; }
            set { _sak = value; }
        }

        public string ContactName
        {
            get { return _currentContact.Name; }
        }

        #endregion

        #region Constructor

        public Contacts()
        {
            _currentContact = new Contact();
            InitializeComponent();
        }

        public Contacts(int sak)
        {
            _sak = sak;
            _currentContact = new Contact(_sak);
            InitializeComponent();
            LoadContactData();
        }

        #endregion

        #region Initialization

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Data Operations

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveContactData();
        }

        private void LoadContactData()
        {
            txtID.Text = _currentContact.SAK_Contact.ToString();
            txtName.Text = _currentContact.Name;
            txtAddress.Text = _currentContact.Address;
            txtRFC.Text = _currentContact.RFC;
            txtNSS.Text = _currentContact.NSS;
            txtPhone.Text = _currentContact.Phone;
            txtEmail.Text = _currentContact.Email;
        }

        private void SaveContactData()
        {
            _currentContact.Name = txtName.Text;
            _currentContact.Address = txtAddress.Text;
            _currentContact.RFC = txtRFC.Text;
            _currentContact.NSS = txtNSS.Text;
            _currentContact.Phone = txtPhone.Text;
            _currentContact.Email = txtEmail.Text;
            if (_currentContact.Save())
            {
                (Parent.Parent as Main).UpdateStatus("Guardado!");
            }
            txtID.Text = _currentContact.SAK_Contact.ToString();
        }

        private void ClearFields()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtNSS.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        #endregion
        
    }
}
