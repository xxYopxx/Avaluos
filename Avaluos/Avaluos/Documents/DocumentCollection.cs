using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class DocumentCollection
    {
        #region Private members

        int _serviceSak;
        string _baseDirectory;
        List<Document> _collection;
        OdbcConnection _sqlConnection;

        #endregion

        #region Public properties

        public List<Document> Documents
        {
            get { return _collection; }
        }

        #endregion

        #region Constructor

        public DocumentCollection(int sak)
        {
            _serviceSak = sak;
            _baseDirectory = Properties.Settings.Default.documentRepo + "\\Avaluos\\" + _serviceSak.ToString();
            _collection = new List<Document>();
        }

        #endregion

        #region Document Handling

        private void RetrieveDocuments()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT SAK_DOCUMENT FROM SERVICE_DOCS WHERE SAK_SERVICE = ?";
            db.AddParameter("@SAK", _serviceSak, OdbcType.Int);
            DataTable results = db.ExecuteReader();
            if (results != null && results.Rows.Count > 0)
            {
                foreach (DataRow row in results.Rows)
                {
                    Document doc = new Document(Convert.ToInt32(row["SAK_DOCUMENT"]));
                    _collection.Add(doc);
                }
            }
        }

        #endregion
    }
}
