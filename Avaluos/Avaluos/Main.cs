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
    public partial class Main : Form
    {
        const string SERVICES_NODE = "servicesNode";
        const string CONTACTS_NODE = "contactsNode";
        const string SERVICES_TEXT = "Servicios";
        const string CONTACTS_TEXT = "Contactos";

        #region Private members

        WindowManager openedWindows;
        int _selectedContact;
        int _selectedService;

        #endregion
        
        #region Initialization

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            openedWindows = new WindowManager();
            TreeNode services = new TreeNode();
            TreeNode contacts = new TreeNode();
            services.Name = SERVICES_NODE;
            services.Text = SERVICES_TEXT;
            contacts.Name = CONTACTS_NODE;
            contacts.Text = CONTACTS_TEXT;
            treeCurrent.Nodes.Add(services);
            treeCurrent.Nodes.Add(contacts);
        }

        #endregion

        #region Window Management

        private void subApplication_Settings_Click(object sender, EventArgs e)
        {
            Configuration window = new Configuration();
            window.ShowDialog();
        }

        private void DisplayWindow(object sender, EventArgs e)
        {
            bool dontDisplay = false;
            bool isContact = false;
            int index = 0;
            Form currentWindow = null;
            TreeNode item = new TreeNode();

            switch ((sender as ToolStripMenuItem).Name)
            {
                case "subContacts_New":
                    currentWindow = new Contacts();
                    index = -1;
                    item.Text = "Nuevo Contacto";
                    isContact = true;
                    break;
                case "subContacts_Search":
                    currentWindow = new ContactSearch();
                    index = -2;
                    item.Text = "Buscar Contacto";
                    isContact = true;
                    break;
                case "OpenContact":
                    currentWindow = new Contacts(_selectedContact);
                    index = _selectedContact;
                    item.Text = (currentWindow as Contacts).ContactName;
                    isContact = true;
                    break;
                case "subServices_New":
                    ContactCollection contacts = new ContactCollection();
                    currentWindow = contacts.HasContacts() ? new ServiceForm() : null;
                    if (currentWindow == null)
                        MessageBox.Show("No hay contactos registrados. Es necesario tener al menos un contacto para poder dar de alta un servicio.","Sin Contactos",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    index = -3;
                    item.Text = "Nuevo Servicio";
                    break;
                case "subServices_Search":
                    currentWindow = new ServiceSearch();
                    index = -4;
                    item.Text = "Buscar Servicio";
                    break;
                case "OpenService":
                    currentWindow = new ServiceForm(_selectedService);
                    index = _selectedService;
                    item.Text = (currentWindow as ServiceForm).Title;
                    break;
            }
            if (currentWindow != null)
            {
                currentWindow.TopLevel = false;
                currentWindow.AutoScroll = true;
                if (!openedWindows.Exists(index))
                {
                    openedWindows.Add(currentWindow, index);
                    pnlCurrent.Controls.Add(currentWindow);
                    item.Name = index.ToString();
                    if (isContact)
                        treeCurrent.Nodes[CONTACTS_NODE].Nodes.Add(item);
                    else
                        treeCurrent.Nodes[SERVICES_NODE].Nodes.Add(item);
                    treeCurrent.ExpandAll();
                    treeCurrent.SelectedNode = item;
                }
                else
                {
                    if (isContact)
                        treeCurrent.SelectedNode = treeCurrent.Nodes[CONTACTS_NODE].Nodes[index.ToString()];
                    else
                        treeCurrent.SelectedNode = treeCurrent.Nodes[SERVICES_NODE].Nodes[index.ToString()];
                }
            }
        }

        private void treeCurrent_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeCurrent.SelectedNode != treeCurrent.Nodes[CONTACTS_NODE] && treeCurrent.SelectedNode != treeCurrent.Nodes[SERVICES_NODE])
            {
                pnlCurrent.Controls.Clear();
                Form currentWindow = (Form)openedWindows.GetWindow(Convert.ToInt32(treeCurrent.SelectedNode.Name));
                pnlCurrent.Controls.Add(currentWindow);
                currentWindow.Show();
            }
        }

        #endregion

        #region External Modification

        internal void UpdateStatus(string status)
        {
            lblCurrentStatus.Text = status;
        }

        internal void OpenContact(int sak)
        {
            _selectedContact = sak;
            ToolStripMenuItem dummy = new ToolStripMenuItem();
            dummy.Name = "OpenContact";
            DisplayWindow(dummy, null);
        }

        internal void OpenService(int sak)
        {
            _selectedService = sak;
        }

        #endregion

        private void contextListWindows_Remove_Click(object sender, EventArgs e)
        {
            if(treeCurrent.SelectedNode != treeCurrent.Nodes[CONTACTS_NODE] && treeCurrent.SelectedNode != treeCurrent.Nodes[SERVICES_NODE])
            {
                pnlCurrent.Controls.Clear();
                openedWindows.Remove(Convert.ToInt32(treeCurrent.SelectedNode.Name));
                treeCurrent.SelectedNode.Remove();
                treeCurrent.SelectedNode = treeCurrent.Nodes[SERVICES_NODE];
            }
        }
    }

    class WindowManager
    {
        List<int> _identifiers;
        List<object> _windows;
        List<int> _indexes;
        int _count;
        public WindowManager()
        {
            _count = -1;
            _identifiers = new List<int>();
            _windows = new List<object>();
            _indexes = new List<int>();
        }

        public void Add(object window, int ID)
        {
            _count += 1;
            _indexes.Add(_count);
            _windows.Add(window);
            _identifiers.Add(ID);
        }

        public void Remove(int ID)
        {
            int index = _identifiers.IndexOf(ID);
            _indexes.RemoveAt(index);
            _windows.RemoveAt(index);
            _identifiers.RemoveAt(index);
        }

        public object GetWindow(int ID)
        {
            return _windows[_identifiers.IndexOf(ID)];
        }

        public bool Exists(int ID)
        {
            return _identifiers.Contains(ID);
        }
    }
}
