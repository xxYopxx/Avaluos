using System;
using System.Collections.Generic;
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
        string _serviceType;
        int _baseDirectory;
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
            _collection = new List<Document>();
        }

        #endregion

        #region Document Handling

        private void RetrieveDocuments()
        {
            // Get list of documents for the service
            // Instantiate Document for each item
            // Add Document to the collection
        }

        private void GetDocumentList()
        {
            _sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                _sqlConnection.Open();
                string sentence = "SELECT * FROM SERVICE_DOCS WHERE SAK_SERVICE = ?";
                OdbcCommand query = new OdbcCommand(sentence, _sqlConnection);
                //query.Parameters.Add()
            }
            catch(Exception ex)
            {

            }
        }

        #endregion
    }
}
