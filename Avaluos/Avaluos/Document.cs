using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class Document
    {
        #region Private members

        int _sak;
        DocType _type;
        string _directory;
        string _baseDirectory;
        OdbcConnection sqlConnection;

        #endregion

        #region Public properties

        public enum DocType { Escritura = 1, Recibo_Agua = 2, Recibo_Predial = 3, Plano_Catastral = 4, Plano = 5 };
        
        #endregion

        #region Constructor

        public Document()
        {
            
        }

        public Document(int sak)
        {

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

        #endregion

        #region Data operations
        
        private bool AddDocument()
        {
            bool result = false;
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                GetLastID();
                sqlConnection.Open();
                string sentence = "INSERT INTO DOCUMENTS(SAK_DOCUMENT, SAK_DOCUMENTTYPE, DIRECTORY) VALUES(?, ?, ?);";
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
                query.Parameters.Add(CreateParameter("@SAK", _sak, OdbcType.Int));
                query.Parameters.Add(CreateParameter("@SAK_TYPE", _type, OdbcType.Text));
                query.Parameters.Add(CreateParameter("@DIRECTORY", _directory, OdbcType.Text));
                result = query.ExecuteNonQuery() == 1;
                query.Dispose();
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                // Log errors
            }
            return result;
        }

        private bool RemoveDocument()
        {
            bool result = false;
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
                string sentence = "DELETE FROM DOCUMENTS WHERE SAK_DOCUMENT=?";
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
                query.Parameters.Add(CreateParameter("@SAK", _sak, OdbcType.Int));
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

        private void LoadDocument()
        {
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
                string sentence = "SELECT * FROM DOCUMENTS WHERE SAK_DOCUMENT = ?";
                OdbcCommand query = new OdbcCommand(sentence, sqlConnection);
                query.Parameters.Add(CreateParameter("@SAK", _sak, OdbcType.Int));
                OdbcDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    _sak = Convert.ToInt32(reader["SAK_DOCUMENT"]);
                    _type = ConvertFromInt(Convert.ToInt32(reader["SAK_DOCUMENTTYPE"]));
                    _directory = reader["DIRECTORY"].ToString();
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
            sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            try
            {
                sqlConnection.Open();
                string sentence = "SELECT MAX(SAK_CONTACT) as LAST FROM DOCUMENTS";
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
