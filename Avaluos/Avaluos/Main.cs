﻿using System;
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
        enum Window { Contacts, svcAC, svcEstimate, svcMAI, svcPrint };
        WindowManager openedWindows;

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

        private void subApplication_Settings_Click(object sender, EventArgs e)
        {
            Configuration window = new Configuration();
            window.ShowDialog();
        }

        private void DisplayWindow(object sender, EventArgs e)
        {
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
                case "subServices_New_AC":
                    currentWindow = new svcAC();
                    index = -2;
                    item.Text = "Nuevo Avaluo Cat";
                    break;
                case "subServices_New_Estimate":
                    currentWindow = new svcEstimate();
                    index = -3;
                    item.Text = "Nueva Estimacion";
                    break;
                case "subServices_New_MAI":
                    currentWindow = new svcMAI();
                    index = -4;
                    item.Text = "Nuevo MAI";
                    break;
                case "subServices_New_Print":
                    currentWindow = new svcPrint();
                    index = -5;
                    item.Text = "Nuevo Plano";
                    break;
            }
            if (currentWindow != null)
            {
                currentWindow.TopLevel = false;
                currentWindow.AutoScroll = true;
                if (!openedWindows.Exists(index))
                {
                    openedWindows.Add(currentWindow, index);
                    pnlCurrent.Controls.Clear();
                    pnlCurrent.Controls.Add(currentWindow);
                    currentWindow.Show();
                    item.Name = index.ToString();
                    if (isContact)
                        treeCurrent.Nodes[CONTACTS_NODE].Nodes.Add(item);
                    else
                        treeCurrent.Nodes[SERVICES_NODE].Nodes.Add(item);
                }
                else
                {
                    pnlCurrent.Controls.Clear();
                    currentWindow = (Form)openedWindows.GetWindow(index);
                    pnlCurrent.Controls.Add(currentWindow);
                    currentWindow.Show();
                }
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