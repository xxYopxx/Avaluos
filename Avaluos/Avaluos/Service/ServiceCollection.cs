using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class ServiceCollection
    {
        #region Private members

        List<Service> _collection;
        Dictionary<string, object> _parameters;

        #endregion

        #region Public properties

        #endregion

        #region Constructor

        public ServiceCollection()
        {
            _collection = new List<Avaluos.Service>();
            _parameters = new Dictionary<string, object>();
        }
        
        #endregion

        #region Search

        public void AddSearchParameters(string field, object value)
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
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT SAK_SERVICE FROM SERVICES WHERE ";
            foreach (KeyValuePair<string, object> parameter in _parameters)
            {
                string parameterName = "@" + parameter.Key;
                object parameterValue = "%" + parameter.Value + "%";
                System.Data.Odbc.OdbcType parameterType = System.Data.Odbc.OdbcType.Text;
                switch (parameter.Value.GetType().ToString())
                {
                    case "System.string":
                        parameterType = System.Data.Odbc.OdbcType.Text;
                        break;

                    case "System.Int32":
                        parameterType = System.Data.Odbc.OdbcType.Int;
                        break;

                    case "System.DateTime":
                        parameterValue = Convert.ToInt32(((DateTime)parameterValue).ToString("YYYYMMdd"));
                        parameterType = System.Data.Odbc.OdbcType.Int;
                        break;
                }
                db.AddParameter(parameterName, parameterValue, parameterType);
                db.Query += parameter.Key + " like ? AND ";
            }
            if (_parameters.Count > 0)
                db.Query = db.Query.Substring(0, db.Query.Length - 4);
            else
                db.Query = db.Query.Replace("WHERE ", "");
            DataTable results = db.ExecuteReader();
            if (results!=null && results.Rows.Count > 0)
            {
                foreach(DataRow row in results.Rows)
                {
                    _collection.Add(new Service(Convert.ToInt32(row["SAK_SERVICE"])));
                }
            }
            return result;
        }

        #endregion
    }
}
