using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace XData
{
    class XRecord
    {
        #region Private members

        Dictionary<string, object> _data;

        #endregion

        #region Public properties


        #endregion

        #region Constructor

        /// <summary>
        /// Instantiates the XRecord with the required columns
        /// </summary>
        /// <param name="columns">List[string]: List of record columns</param>
        public XRecord(List<string> columns)
        {
            _data = new Dictionary<string, object>();
            foreach(string column in columns)
            {
                _data.Add(column, null);
            }
        }

        #endregion
    }
}
