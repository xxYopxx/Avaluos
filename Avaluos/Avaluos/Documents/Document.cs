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
    public class Document
    {
        #region Private members

        int _sak;
        DocType _type;
        string _directory;
        string _baseDirectory;
        Dictionary<int, string> _docTypeList;
        #endregion

        #region Public properties

        public enum DocType { Escritura = 1, Recibo_Agua = 2, Recibo_Predial = 3, Plano_Catastral = 4, Plano = 5 };

        public int Sak { get { return _sak; } }
        public string Directory { get { return _directory; } set { _directory = value; } }
        public DocType DocumentType { get { return _type; } set { _type = value; } }
        public Dictionary<int,string> DocumentTypeList { get { return _docTypeList; } }
        
        #endregion

        #region Constructor

        public Document()
        {
            _sak = -1;
            FillDocTypeList();
        }

        public Document(int sak)
        {
            _sak = sak;
            LoadDocument();
            FillDocTypeList();
        }

        #endregion

        #region Functionality
        
        public bool Save()
        {
            bool result = false;
            if (_sak == -1)
                result = AddDocument();
            return result;
        }

        public bool Remove()
        {
            bool result = false;
            if (_sak != -1)
            {
                result = RemoveDocument();
            }
            return result;
        }
        
        public DocType ConvertFromInt(int type)
        {
            DocType result = DocType.Escritura;
            switch (type)
            {
                case 1: result = DocType.Escritura; break;
                case 2: result = DocType.Recibo_Agua; break;
                case 3: result = DocType.Recibo_Predial; break;
                case 4: result = DocType.Plano_Catastral; break;
                case 5: result = DocType.Plano; break;
                default: result = DocType.Escritura; break;
            }
            return result;
        }

        public string ConvertFromType(DocType type)
        {
            string result = string.Empty;
            switch (type)
            {
                case DocType.Escritura: result = _docTypeList[1]; break;
                case DocType.Recibo_Agua: result = _docTypeList[2]; break;
                case DocType.Recibo_Predial: result = _docTypeList[3]; break;
                case DocType.Plano_Catastral: result = _docTypeList[4]; break;
                case DocType.Plano: result = _docTypeList[5]; break;
            }
            return result;
        }

        #endregion

        #region Data operations
        
        private bool AddDocument()
        {
            GetLastID();
            SQLiteLink db = new SQLiteLink();
            db.Query= "INSERT INTO DOCUMENTS(SAK_DOCUMENT, SAK_DOCUMENTTYPE, DIRECTORY) VALUES(?, ?, ?);";
            db.AddParameter("@SAK", _sak, OdbcType.Int);
            db.AddParameter("@SAK_TYPE", _type, OdbcType.Text);
            db.AddParameter("@DIRECTORY", _directory, OdbcType.Text);
            return db.ExecuteCommand() == 1;
        }

        private bool RemoveDocument()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "DELETE FROM DOCUMENTS WHERE SAK_DOCUMENT=?";
            db.AddParameter("@SAK", _sak, OdbcType.Int);
            return db.ExecuteCommand() == 1;
        }

        private void LoadDocument()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT * FROM DOCUMENTS WHERE SAK_DOCUMENT = ?";
            db.AddParameter("@SAK", _sak, OdbcType.Int);
            DataTable results = db.ExecuteReader();
            if (results!=null && results.Rows.Count > 0)
            {
                foreach(DataRow row in results.Rows)
                {
                    _sak = Convert.ToInt32(row["SAK_DOCUMENT"]);
                    _type = ConvertFromInt(Convert.ToInt32(row["SAK_DOCUMENTTYPE"]));
                    _directory = row["DIRECTORY"].ToString();
                }
            }

        }

        private OdbcParameter CreateParameter(string name, object value, OdbcType type)
        {
            OdbcParameter parameter = new OdbcParameter();
            parameter.ParameterName = name;
            parameter.OdbcType = type;
            parameter.Value = value;
            return parameter;
        }

        private void GetLastID()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT MAX(SAK_DOCUMENT) as LAST FROM DOCUMENTS";
            DataTable results = db.ExecuteReader();
            if (results!=null && results.Rows.Count > 0)
            {
                foreach(DataRow row in results.Rows)
                {
                    _sak = row["LAST"] != DBNull.Value ? Convert.ToInt32(row["LAST"]) : 1;
                }   
            }
            else
            {
                _sak = 1;
            }
        }

        private void FillDocTypeList()
        {
            _docTypeList = new Dictionary<int, string>();
            _docTypeList.Add(1, "Escritura");
            _docTypeList.Add(2, "Recibo de Agua");
            _docTypeList.Add(3, "Recibo de Predial");
            _docTypeList.Add(4, "Plano Catastral");
            _docTypeList.Add(5, "Plano");
        }

        #endregion
    }
}
