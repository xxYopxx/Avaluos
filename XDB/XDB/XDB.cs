using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XData
{
    public class XDB
    {
        public enum Filters { Equals, Contains, Between, GreatherThan, LesserThan }
        public enum Operation { Insert, Update, Search }

        #region XML elements

        internal const string _xmlManifest = "manifest";
        internal const string _xmlMetadata = "metadata";
        internal const string _xmlRoot = "table";
        internal const string _xmlItem = "item";
        internal const string _xmlColumn = "column";
        internal const string _attName = "name";
        internal const string _attLastRow = "lastrow";
        internal const string _attRownum = "rownum";
        internal const string _attColumns = "columns";
        internal const string _attType = "type";

        #endregion

        #region Private members

        const string _MANIFEST = "Manifest.xdb";
        const string _TABLE_EXT = ".dat";
        
        /// <summary>
        /// Database structure location
        /// </summary>
        string _source;

        /// <summary>
        /// Manifest full path with filename
        /// </summary>
        string _manifest_dir;
        
        /// <summary>
        /// Indicator of manifest presence
        /// </summary>
        bool _hasManifest;

        /// <summary>
        /// Indicator of database structural integrity
        /// </summary>
        bool _isStructureComplete;

        List<XTable> _tables;

        #endregion

        #region Public properties

        /// <summary>
        /// Database's directory
        /// </summary>
        public string Source
        {
            get { return _source; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Instantiates the XDB object given a location for the database
        /// </summary>
        /// <param name="location">string: Directory where database files are located</param>
        public XDB(string location)
        {
            _source = location;
            _manifest_dir = _source + "\\" + _MANIFEST;
            _tables = new List<XTable>();
            if (_hasManifest = File.Exists(_manifest_dir))
            {
                _isStructureComplete = ScanSource();
            }
        }

        #endregion

        #region Initialization
        
        /// <summary>
        /// Reads the database manifest to verify the structural integrity
        /// </summary>
        private bool ScanSource()
        {
            bool result = true;
            // Load manifest
            XmlDocument manifest = new XmlDocument();
            manifest.Load(_manifest_dir);
            // Load tables and their definition
            XmlNode root = manifest.FirstChild;
            XmlNode metadata = root.FirstChild;
            foreach(XmlNode nodeTable in metadata.ChildNodes)
            {
                DataTable strucTable = new DataTable(nodeTable.Attributes[_attName].Value);
                foreach(XmlNode nodeColumn in nodeTable.ChildNodes)
                {
                    strucTable.Columns.Add(new DataColumn(nodeColumn.Attributes[_attName].Value, Type.GetType(nodeColumn.Attributes[_attType].Value)));
                }
                XTable table = new XTable(strucTable);
                table.Directory = _source + "\\" + table.Tablename + _TABLE_EXT;
                if (result && !File.Exists(table.Directory))
                    result = false;
                _tables.Add(table);
            }

            return result;
        }

        #endregion

        #region Create database

        /// <summary>
        /// Scans an object's properties and creates a table
        /// </summary>
        public void ScanObject(object item)
        {
            PropertyInfo[] metadata = item.GetType().GetProperties();
            DataTable table = new DataTable();
            table.TableName = item.GetType().ToString();
            foreach(PropertyInfo property in metadata)
                table.Columns.Add(new DataColumn(property.Name, property.PropertyType));
            XTable xtable = new XTable(table);
            xtable.Directory = _source + "\\" + xtable.Tablename + _TABLE_EXT;
            xtable.CreateTable();
            _tables.Add(xtable);
        }

        /// <summary>
        /// After all tables are created, creates a manifest with the metadata
        /// </summary>
        public void FinishTablesInitialization()
        {
            CreateManifest();
        }

        private void CreateDatabase(List<DataTable> tables)
        {
            // Create list of tables
            foreach(DataTable table in tables)
            {
                XTable t = new XTable(table);
                t.Directory = _source + "\\" + t.Tablename + _TABLE_EXT;
                t.CreateTable();
                _tables.Add(t);
            }
            // Create Manifest
            CreateManifest();
        }

        /// <summary>
        /// Creates a manifest for the database
        /// </summary>
        private void CreateManifest()
        {
            XmlDocument manifest = new XmlDocument();
            XmlElement root = manifest.CreateElement(_xmlManifest);
            XmlElement metadata = manifest.CreateElement(_xmlMetadata);
            foreach(XTable table in _tables)
            {
                metadata.AppendChild(manifest.ImportNode(table.GetManifestInfo().CloneNode(true), true));
            }
            root.AppendChild(metadata);
            manifest.AppendChild(root);
            manifest.Save(_manifest_dir);
        }

        #endregion

        #region Query
        
        public bool CreateRecord(object item)
        {

            return false;
        }

        #endregion

    }
}
