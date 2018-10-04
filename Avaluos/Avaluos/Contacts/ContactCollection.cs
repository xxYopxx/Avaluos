using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class ContactCollection
    {
        #region Private members

        List<Contact> _collection;
        Dictionary<string, object> _parameters;
        OdbcConnection sqlConnection;
        #endregion

        #region Public properties

        public List<Contact> Results
        {
            get { return _collection; }
        }

        #endregion

        #region Constructor

        public ContactCollection()
        {
            _parameters = new Dictionary<string, object>();
            _collection = new List<Contact>();
        }

        #endregion

        #region Search

        public void AddSearchParameter(string field, object value)
        {
            _parameters.Add(field, value);
        }

        public void ClearSearchParameters()
        {
            _parameters.Clear();
        }

        public bool HasContacts()
        {
            bool result = false;
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT 1 AS FLAG FROM CONTACTS WHERE SAK_CONTACT>0";
            DataTable results = db.ExecuteReader();
            if (results != null && results.Rows.Count > 0)
            {
                foreach (DataRow row in results.Rows)
                    result = row["FLAG"] != DBNull.Value ? true : false;
            }
            else
                result = false;
            return result;
        }

        public bool Search()
        {
            bool result = false;
            _collection = new List<Contact>();
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
                OdbcCommand query = new OdbcCommand();
                string sentence = "SELECT SAK_CONTACT FROM CONTACTS WHERE ";
                foreach(KeyValuePair<string,object> parameter in _parameters)
                {
                    OdbcParameter filter = new OdbcParameter();
                    filter.ParameterName = "@" + parameter.Key;
                    filter.Value = "%" + parameter.Value + "%";
                    switch (parameter.Value.GetType().ToString())
                    {
                        case "System.string":
                            filter.OdbcType = OdbcType.Text;
                            break;
                            
                        case "System.Int32":
                            filter.OdbcType = OdbcType.Int;
                            break;

                        case "System.DateTime":
                            filter.Value = Convert.ToInt32(((DateTime)filter.Value).ToString("YYYYMMdd"));
                            filter.OdbcType = OdbcType.Int;
                            break;
                    }
                    query.Parameters.Add(filter);
                    sentence += parameter.Key + " like ? AND ";
                }
                if (_parameters.Count > 0)
                    sentence = sentence.Substring(0, sentence.Length - 4);
                else
                    sentence = sentence.Replace("WHERE ", "");
                query.Connection = sqlConnection;
                query.CommandText = sentence;
                OdbcDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    result = true;
                    while (reader.Read())
                    {
                        Contact item = new Contact(Convert.ToInt32(reader["SAK_CONTACT"]));
                        _collection.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log errors
            }

            return result;
        }
        #endregion
        }
}
