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
    public partial class svcAC : Form
    {
        public svcAC()
        {
            InitializeComponent();
        }

        #region Initialization

        private void svcAC_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Document Search

        private void btnAddDocument_Click(object sender, EventArgs e)
        {
            SearchDocument window = new SearchDocument();
            window
        }

        #endregion


    }
}