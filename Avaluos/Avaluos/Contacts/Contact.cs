using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class Contact
    {
        #region Private Members

        /// <summary>
        /// Contact's unique system assigned key
        /// </summary>
        int _sak;

        /// <summary>
        /// Contact's name
        /// </summary>
        string _name;

        /// <summary>
        /// Contact's physical address
        /// </summary>
        string _address;

        /// <summary>
        /// Contact's RFC
        /// </summary>
        string _RFC;

        /// <summary>
        /// Contact's NSS
        /// </summary>
        string _NSS;

        /// <summary>
        /// Contact's phone number
        /// </summary>
        string _phone;

        /// <summary>
        /// Contact's electronic mail address
        /// </summary>
        string _email;

        OdbcConnection sqlConnection;

        #endregion

        #region Public properties

        public int SAK_Contact
        {
            get { return _sak; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        public string NSS
        {
            get { return _NSS; }
            set { _NSS = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        #endregion

        #region Constructor

        public Contact()
        {
            _sak = -1;
        }

        public Contact(int Sak)
        {
            _sak = Sak;
            LoadContact();
        }

        #endregion

        #region Functionality

        public bool Save()
        {
            bool result = false;
            if (_sak==-1)
            {
                result = AddContact();
            }
            else
            {
                ModifyContact();
            }
            return result;
        }

        #endregion

        #region Data operations

        private bool AddContact()
        {
            bool result = false;
            GetLastID();
            SQLiteLink db = new SQLiteLink();
            db.Query = "INSERT INTO CONTACTS(SAK_CONTACT, NAME, ADDRESS, RFC,NSS,PHONE,EMAIL) VALUES(?, ?, ?, ?, ?, ?, ?);";
            db.AddParameter("@SAK", _sak, OdbcType.Int);
            db.AddParameter("@NAME", _name, OdbcType.Text);
            db.AddParameter("@ADDRESS", _address, OdbcType.Text);
            db.AddParameter("@RFC", _RFC, OdbcType.Text);
            db.AddParameter("@NSS", _NSS, OdbcType.Text);
            db.AddParameter("@PHONE", _phone, OdbcType.Text);
            db.AddParameter("@EMAIL", _email, OdbcType.Text);
            result = db.ExecuteCommand() == 1;
            return result;
        }

        private bool ModifyContact()
        {
            bool result = false;
            SQLiteLink db = new SQLiteLink();
            db.Query = "UPDATE CONTACTS SET NAME = ?, ADDRESS = ?, RFC = ?, NSS = ?, PHONE = ?, EMAIL = ? WHERE SAK_CONTACT = ?";
            db.AddParameter("@NAME", _name, OdbcType.Text);
            db.AddParameter("@ADDRESS", _address, OdbcType.Text);
            db.AddParameter("@RFC", _RFC, OdbcType.Text);
            db.AddParameter("@NSS", _NSS, OdbcType.Text);
            db.AddParameter("@PHONE", _phone, OdbcType.Text);
            db.AddParameter("@EMAIL", _email, OdbcType.Text);
            result = db.ExecuteCommand() == 1;
            return result;
        }
        
        private void LoadContact()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT * FROM CONTACTS WHERE SAK_CONTACT = ?";
            db.AddParameter("@SAK", _sak, OdbcType.Int);
            DataTable result = db.ExecuteReader();
            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    _sak = Convert.ToInt32(row["SAK_CONTACT"]);
                    _name = row["NAME"].ToString();
                    _address = row["ADDRESS"].ToString();
                    _RFC = row["RFC"].ToString();
                    _NSS = row["NSS"].ToString();
                    _phone = row["PHONE"].ToString();
                    _email = row["EMAIL"].ToString();
                }
            }
        }

        private void GetLastID()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT MAX(SAK_CONTACT) as LAST FROM CONTACTS";
            DataTable results = db.ExecuteReader();
            if (results != null && results.Rows.Count > 0)
            {
                foreach (DataRow row in results.Rows)
                {
                    _sak = row["LAST"] != DBNull.Value ? Convert.ToInt32(row["LAST"]) + 1 : 1;
                }
            }
        }

        #endregion

    }
}
