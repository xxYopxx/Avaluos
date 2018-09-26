using System;
using System.Collections.Generic;
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
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                GetLastID();
                sqlConnection.Open();
                string sentence = "INSERT INTO CONTACTS(SAK_CONTACT, NAME, ADDRESS, RFC,NSS,PHONE,EMAIL) VALUES(?, ?, ?, ?, ?, ?, ?);";
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
                query.Parameters.Add(CreateParameter("@SAK", _sak, OdbcType.Int));
                query.Parameters.Add(CreateParameter("@NAME", _name, OdbcType.Text));
                query.Parameters.Add(CreateParameter("@ADDRESS", _address, OdbcType.Text));
                query.Parameters.Add(CreateParameter("@RFC", _RFC, OdbcType.Text));
                query.Parameters.Add(CreateParameter("@NSS", _NSS, OdbcType.Text));
                query.Parameters.Add(CreateParameter("@PHONE", _phone, OdbcType.Text));
                query.Parameters.Add(CreateParameter("@EMAIL", _email, OdbcType.Text));
                result = query.ExecuteNonQuery() == 1;
                query.Dispose();
                sqlConnection.Close();
                
            }
            catch(Exception ex)
            {
                // Log errors
            }
            return result;
        }

        private void ModifyContact()
        {

        }

        private OdbcParameter CreateParameter(string name, object value, OdbcType type)
        {
            OdbcParameter parameter = new OdbcParameter();
            parameter.ParameterName = name;
            parameter.OdbcType = type;
            parameter.Value = value;
            return parameter;
        }

        private void LoadContact()
        {
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
                string sentence = "SELECT * FROM CONTACT WHERE SAK_CONTACT = " + _sak.ToString();
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
                OdbcDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    _sak = Convert.ToInt32(reader["SAK_CONTACT"]);
                    _name = reader["NAME"].ToString();
                    _address = reader["ADDRESS"].ToString();
                    _RFC = reader["RFC"].ToString();
                    _NSS = reader["NSS"].ToString();
                    _phone = reader["PHONE"].ToString();
                    _email = reader["EMAIL"].ToString();
                }
                reader.Close();
                query.Dispose();
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                // Log errors
            }
            
        }

        private void GetLastID()
        {
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
                string sentence = "SELECT MAX(SAK_CONTACT) as LAST FROM CONTACTS";
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
                OdbcDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _sak = reader["LAST"] != DBNull.Value ? Convert.ToInt32(reader["LAST"]) : 1;
                    }
                }
                else
                {
                    _sak = 1;
                }
                
                reader.Close();
                query.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                // Log errors
            }
        }

        #endregion

    }
}
