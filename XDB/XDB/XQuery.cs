using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XData
{
    class XQuery
    {
        public enum Filters { Equals, Contains, Between, GreatherThan, LesserThan }
        public enum Operation { Insert, Update, Search }

        #region Private members

        Filters _selectedFilter;
        Operation _selectedOperation;
        XRecordSet _results;

        /// <summary>
        /// Last generated sak number
        /// </summary>
        int _currentRowNumber;

        /// <summary>
        /// Table name
        /// </summary>
        string _selectedTable;

        /// <summary>
        /// Table full path with filename
        /// </summary>
        string _source;

        /// <summary>
        /// List of columns with corresponding value, used for inserting and updating
        /// </summary>
        Dictionary<string, string> _columns;

        #endregion

        #region Public properties

        public string SelectedTable
        {
            get { return _selectedTable; }
            set { _selectedTable = value; }
        }

        

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes the query
        /// </summary>
        /// <param name="source">string: table full path with file name</param>
        public XQuery(string source)
        {
            _columns = new Dictionary<string, string>();
        }

        #endregion

        #region Query Helpers

        internal void AddColumn(string column, string value)
        {
            _columns.Add(column, value);
        }

        #endregion

        #region Insert

        private bool InsertData()
        {

            return false;
        }

        #endregion


        #region Update

        #endregion

        #region Search

        #endregion

    }
}
