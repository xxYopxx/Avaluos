using System;
using System.Collections.Generic;
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

        public bool Search()
        {
            bool result = false;
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
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
                    sentence += parameter.Key + " like ? AND ";
                }
                sentence = sentence.Substring(0, sentence.Length - 4);
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
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
