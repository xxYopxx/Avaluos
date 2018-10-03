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
    public partial class svcAC : Form
    {
        #region Private members

        bool _isNew = false;
        int _sakService;
        Service _service;
        List<Document> _newDocuments;
        List<Payment> _newPayments;

        #endregion

        #region Constructor

        public svcAC()
        {
            _isNew = true;
            _service = new Service();
            InitializeComponent();
        }

        public svcAC(int sak)
        {
            _sakService = sak;
            _service = new Service(sak);
            
        }

        #endregion

        #region Initialization

        private void svcAC_Load(object sender, EventArgs e)
        {
            // Load Contact list and fill dropdown lists
            ContactCollection contacts = new ContactCollection();
            contacts.Search();
            ddlContact_Client.DataSource = contacts.Results;
            ddlContact_Client.DisplayMember = "Name";
            ddlContact_Client.ValueMember = "SAK_Contact";

            ddlContact_Seller.DataSource = contacts.Results;
            ddlContact_Seller.DisplayMember = "Name";
            ddlContact_Seller.ValueMember = "SAK_Contact";

            // Fill status dropdown list
            ddlStatus.DataSource = new BindingSource(_service.StatusList, null);
            ddlStatus.DisplayMember = "Value";
            ddlStatus.ValueMember = "Key";

            ddlServiceType.DataSource = new BindingSource(_service.ServiceTypeList, null);
            ddlServiceType.DisplayMember = "Value";
            ddlServiceType.ValueMember = "Key";

            _newDocuments = new List<Document>();
            _newPayments = new List<Payment>();
            
            // If it's not a new record then load documents and payments
            if (_isNew)
            {
                // disable status dropdown since it's a new record
                ddlStatus.Enabled = false;
                btnOpenFolder.Enabled = false;
            }
            else
            {
                ddlServiceType.Enabled = false;
                LoadDocuments();
                LoadPayments();
            }
        }

        #endregion

        #region Document Operations

        private void LoadDocuments()
        {
            foreach(Document document in _service.Documents.Documents)
            {
                ListViewItem item = new ListViewItem();
                Document.DocType type = document.DocumentType;
                item.Text = document.Sak.ToString();
                item.SubItems.Add(document.ConvertFromType(type));
                listDocuments.Items.Add(item);
            }
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            SearchDocument window = new SearchDocument();
            window.ShowDialog();
            if (window.AddedDocument.Directory != string.Empty)
            {
                _newDocuments.Add(window.AddedDocument);
                ListViewItem newDocument = new ListViewItem();
                Document.DocType type = _newDocuments.Last().DocumentType;
                newDocument.Text = "-1";
                newDocument.SubItems.Add(_newDocuments.Last().ConvertFromType(type));
                listDocuments.Items.Add(newDocument);
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (_service.sak != -1)
                System.Diagnostics.Process.Start(_service.Documents.BaseDirectory);
        }

        #endregion

        #region Payment Operations

        private void LoadPayments()
        {
            foreach(Payment payment in _service.Payments.Payments)
            {
                ListViewItem item = new ListViewItem();
                item.Text = payment.Amount.ToString();
                item.SubItems.Add(payment.DatePaid.ToString("dd/MMM/yyyy"));
                listPayments.Items.Add(item);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            string text = txtNewPayment.Text;
            if (ValidateNumber(ref text) && ValidateAmountTotal())
            {
                Payment payment = new Payment();
                payment.Amount = Convert.ToInt32(txtNewPayment.Text);
                payment.DatePaid = DateTime.Today;
                payment.SakService = _service.sak;
                ListViewItem item = new ListViewItem();
                item.Text = txtNewPayment.Text;
                item.SubItems.Add(DateTime.Today.ToString("dd/MMM/yyyy"));
                _newPayments.Add(payment);
                listPayments.Items.Add(item);
                UpdateRemainingPayment();
            }
        }

        private void AllowOnlyNumbers(object sender, EventArgs e)
        {
            string text = (sender as TextBox).Text;
            ValidateNumber(ref text);
            (sender as TextBox).Text = text;
        }

        private void UpdateRemainingPayment()
        {
            decimal paid = 0;
            // Gather payments total
            foreach (ListViewItem item in listPayments.Items)
            {
                paid = Convert.ToDecimal(item.Text);
            }
            if (txtAmountTotal.Text != string.Empty)
                txtToPay.Text = (Convert.ToDecimal(txtAmountTotal.Text) - paid).ToString();

        }

        private bool ValidateNumber(ref string text)
        {
            bool result = true;
            if (System.Text.RegularExpressions.Regex.Match(text, "\\d*\\.?\\d*").Value != text)
            {
                MessageBox.Show("Solo numeros en este campo.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                text = text.Remove(text.Length - 1);
                result = false;
            }
            return result;
        }

        private bool ValidateAmountTotal()
        {
            bool result = true;
            if (txtAmountTotal.Text == string.Empty)
            {
                MessageBox.Show("Cantidad total no debe estar vacio.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                result = false;
            }
            return result;
        }

        #endregion

        #region Functionality

        private void ClearFields()
        {
            _service = new Service();
            // Select default value in Dropdown lists
            ddlStatus.SelectedIndex = 0;
            ddlContact_Client.SelectedIndex = 0;
            ddlContact_Seller.SelectedIndex = 0;
            dteVisit.Value = DateTime.Today;
            dteVisit.Refresh();

            // Clear lists
            listDocuments.Items.Clear();
            listPayments.Items.Clear();

            // Clear textboxes
            txtAmountTotal.Text = string.Empty;
            txtNewPayment.Text = string.Empty;
            txtToPay.Text = string.Empty;
            txtNotes.Text = string.Empty;
            
        }

        #endregion

        #region Persist

        private void btnSave_Click(object sender, EventArgs e)
        {
            PrepareToSave();
            Save();
            if (_isNew)
            {
                ClearFields();
            }
        }

        private void PrepareToSave()
        {
            if (_isNew)
            {
                _service.ServiceType = Convert.ToInt32(ddlServiceType.SelectedValue);
                _service.DateStart = DateTime.Today;
                _service.DateEnd = DateTime.ParseExact("99991231", "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                _service.sak = -1;
            }
            else
            {
                if (Convert.ToInt32(ddlStatus.SelectedValue) == 4)
                {
                    _service.DateEnd = DateTime.Today;
                }
            }
            _service.Client = new Contact(Convert.ToInt32(ddlContact_Client.SelectedValue));
            _service.Seller = (_service.ServiceType == 1 || _service.ServiceType == 3) ? new Contact(Convert.ToInt32(ddlContact_Seller.SelectedValue)) : null;
            _service.DateVisit = dteVisit.Value;
            _service.Status = Convert.ToInt32(ddlStatus.SelectedValue);
            _service.AmountTotal = Convert.ToInt32(txtAmountTotal.Text);
            _service.Notes = txtNotes.Text;
        }

        private void Save()
        {
            // Save the service record to generate the sak if it's new
            _service.Save();
            if (_isNew)
                _service.CreateDocumentsAndPayments();
            // If the service and documents directory don't exist then create them
            // Copy the new documents to their final destination
            // Create the documents record
            foreach(Document item in _newDocuments)
                _service.Documents.AddToCollection(item);
            foreach(Payment pay in _newPayments)
            {
                pay.SakService = _service.sak;
                pay.Save();
            }
        }
        
        #endregion

        private void txtNewPayment_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtAmountTotal_Enter(object sender, EventArgs e)
        {
            UpdateRemainingPayment();
        }
    }
}