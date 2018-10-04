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
    public partial class ContactSearch : Form
    {
        List<Contact> _results;
        public ContactSearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtNSS.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        #region Search

        private void Search()
        {
            _results = new List<Contact>();
            ContactCollection collection = new ContactCollection();
            if (txtName.Text.Trim() != string.Empty)
                collection.AddSearchParameter("NAME", txtName.Text);
            if (txtAddress.Text.Trim() != string.Empty)
                collection.AddSearchParameter("ADDRESS", txtAddress.Text);
            if (txtRFC.Text.Trim() != string.Empty)
                collection.AddSearchParameter("RFC", txtRFC.Text);
            if (txtNSS.Text.Trim() != string.Empty)
                collection.AddSearchParameter("NSS", txtNSS.Text);
            if (txtPhone.Text.Trim() != string.Empty)
            {
                collection.AddSearchParameter("PHONE", txtPhone.Text);
                collection.AddSearchParameter("PHONE2", txtPhone.Text);
            }
            if (txtEmail.Text.Trim() != string.Empty)
                collection.AddSearchParameter("EMAIL", txtEmail.Text);

            if (collection.Search())
            {
                foreach(Contact item in collection.Results)
                {
                    ListViewItem row = new ListViewItem();
                    row.Text = item.Name;
                    row.SubItems.Add(item.Address);
                    row.SubItems.Add(item.RFC);
                    row.SubItems.Add(item.NSS);
                    row.SubItems.Add(item.Phone);
                    row.SubItems.Add(item.Email);
                    row.Tag = item.SAK_Contact;
                    listResults.Items.Add(row);
                }
            }
        }

        #endregion

        private void listResults_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listResults.SelectedItems.Count > 0)
                (Parent.Parent as Main).OpenContact(Convert.ToInt32(listResults.SelectedItems[0].Tag));
        }
    }
}
