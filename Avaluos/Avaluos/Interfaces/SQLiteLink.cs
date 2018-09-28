using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class SQLiteLink
    {
        #region Private members

        string _sentence;
        OdbcConnection _sqlConnection;
        OdbcCommand _query;
        OdbcDataReader _reader;

        #endregion

        #region Public properties

        public string Query
        {
            get { return _sentence; }
            set { _sentence = value; }
        }

        #endregion

        #region Constructor

        internal SQLiteLink()
        {
            _sqlConnection = new OdbcConnection(Properties.Settings.Default.sqliteConnection);
            _query = new OdbcCommand();
        }

        #endregion

        #region Methods

        internal void AddParameter(string name, object value, OdbcType type)
        {
            OdbcParameter parameter = new OdbcParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.OdbcType = type;
            _query.Parameters.Add(parameter);
        }

        internal int ExecuteCommand()
        {
            int rowsAffected = 0;
            try
            {
                _sqlConnection.Open();
                _query.Connection = _sqlConnection;
                _query.CommandText = _sentence;
                rowsAffected = _query.ExecuteNonQuery();
                _query.Dispose();
                _sqlConnection.Close();
            }
            catch(Exception ex)
            {
                // Log errors
            }
            return rowsAffected;
        }

        internal DataTable ExecuteReader()
        {
            DataTable result = null;
            try
            {
                _sqlConnection.Open();
                _query.Connection = _sqlConnection;
                _query.CommandText = _sentence;
                _reader = _query.ExecuteReader();
                result = new DataTable();
                for(int index=0; index<_reader.FieldCount; index++)
                {
                    DataColumn column = new DataColumn();
                    column.ColumnName = _reader.GetName(index);
                    column.DataType = _reader.GetFieldType(index);
                    result.Columns.Add(column);
                }
                while (_reader.Read())
                {
                    DataRow row = result.NewRow();
                    for (int index = 0; index < _reader.FieldCount; index++)
                    {
                        row[index] = _reader[index];
                    }
                    result.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                // Log errors
            }
            return result;
        }

        #endregion
    }
}
