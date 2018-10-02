using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
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
        
        public string BaseDirectory
        {
            get { return _baseDirectory; }
        }

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

        public bool AddToCollection(Document document)
        {
            return Add(document);
        }

        public void CreateBaseDirectory()
        {
            if (!Directory.Exists(_baseDirectory))
            {
                Directory.CreateDirectory(_baseDirectory);
            }
        }

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

        private bool Add(Document doc)
        {
            bool documentSaved = false;
            // Move original file to file structure
            File.Copy(doc.Directory, _baseDirectory + "\\" + Path.GetFileName(doc.Directory));
            // Change directory in object
            doc.Directory = _baseDirectory + "\\" + Path.GetFileName(doc.Directory);
            // Save document record
            documentSaved = doc.Save();
            if (documentSaved)
            {
                // Save document-service xref record
                SQLiteLink db = new SQLiteLink();
                db.Query = "INSERT INTO SERVICE_DOCS(SAK_SERVICE, SAK_DOCUMENT) VALUES(?,?)";
                db.AddParameter("@SAK_SERVICE", _serviceSak, OdbcType.Int);
                db.AddParameter("@SAK_DOCUMENT", doc.Sak, OdbcType.Int);
                documentSaved = db.ExecuteCommand() == 1;
                if (!documentSaved)
                    doc.Remove();
            }
            return documentSaved;
        }

        #endregion
    }
}
