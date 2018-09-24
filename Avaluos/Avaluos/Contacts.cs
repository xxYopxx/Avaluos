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
        bool _isNew;
        #endregion

        #region Public properties

        public int ID
        {
            get { return _sak; }
            set { _sak = value; }
        }

        #endregion

        #region Constructor

        public Contacts()
        {
            _isNew = true;
            InitializeComponent();
        }

        public Contacts(int sak)
        {
            _isNew = false;
            _sak = sak;
            InitializeComponent();
        }

        #endregion

        #region Data Operations

        public void LoadContactData()
        {

        }

        public void SaveContactData()
        {

        }

        #endregion


    }
}
