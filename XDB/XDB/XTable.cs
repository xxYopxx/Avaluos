using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XData
{
    class XTable
    {
        #region Private Members

        /// <summary>
        /// Table name
        /// </summary>
        string _name = string.Empty;

        /// <summary>
        /// Table full path with filename
        /// </summary>
        string _source = string.Empty;

        /// <summary>
        /// Last generated row
        /// </summary>
        int _lastRow = 0;

        /// <summary>
        /// List of table columns with datatype
        /// </summary>
        Dictionary<string, string> _columns;

        /// <summary>
        /// Table file reference
        /// </summary>
        XmlDocument _file;
        #endregion
        
        #region Internal Members

        internal string Directory
        {
            get { return _source; }
            set { _source = value; }
        }

        #endregion
        
        #region Public Properties

        public string Tablename
        {
            get { return _name; }
        }

        public int LastRow
        {
            get { return _lastRow; }
        }
        
        #endregion
        
        #region Constructor
        public XTable()
        {

        }

        /// <summary>
        /// Initializes the table based on a given structure
        /// </summary>
        /// <param name="structure">DataTable: No data is necessary, only the table's metadata</param>
        public XTable(DataTable structure)
        {
            _name = structure.TableName;
            _columns = structure.Columns.Cast<DataColumn>()
                .Select(column => new { column.ColumnName, column.DataType })
                .ToDictionary(column => column.ColumnName, column2 => column2.DataType.ToString());
            
        }
        #endregion

        #region Create Table
        
        /// <summary>
        /// Creates the table file using the current object's properties
        /// </summary>
        internal void CreateTable()
        {
            _file = new XmlDocument();
            XmlNode root = _file.CreateElement("table");
            XmlAttribute name = _file.CreateAttribute(XDB._attName);
            XmlAttribute lastrow = _file.CreateAttribute(XDB._attRownum);
            name.Value = _name;
            lastrow.Value = _lastRow.ToString();
            root.Attributes.Append(name);
            root.Attributes.Append(lastrow);
            _file.AppendChild(root);
            _file.Save(_source);
            _file = null;
        }

        internal XmlElement GetManifestInfo()
        {
            _file = new XmlDocument();
            XmlElement table = _file.CreateElement(XDB._xmlRoot);
            XmlAttribute tablename = _file.CreateAttribute(XDB._attName);
            XmlAttribute tablecols = _file.CreateAttribute(XDB._attColumns);
            XmlAttribute name = _file.CreateAttribute(XDB._attName);
            XmlAttribute columns = _file.CreateAttribute(XDB._attColumns);
            List<XmlElement> items = new List<XmlElement>();
            tablename.Value = _name;
            tablecols.Value = _columns.Count.ToString();
            table.Attributes.Append(tablename);
            table.Attributes.Append(tablecols);
            foreach(KeyValuePair<string,string> column in _columns)
            {
                XmlElement col = _file.CreateElement(XDB._xmlColumn);
                XmlAttribute attname = _file.CreateAttribute(XDB._attName);
                XmlAttribute atttype = _file.CreateAttribute(XDB._attType);
                attname.Value = column.Key;
                atttype.Value = column.Value;
                col.Attributes.Append(attname);
                col.Attributes.Append(atttype);
                items.Add(col);
            }
            foreach (XmlElement item in items)
                table.AppendChild(item);
            return table;
        }

        #endregion

    }
}
