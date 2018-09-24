using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XData
{
    class XRecordSet
    {
        #region Private members
        List<string> _columns;
        List<XRecord> _dataset;

        #endregion

        #region Public properties

        #endregion

        #region Constructor

        public XRecordSet(List<string> columns)
        {
            _columns = columns;
        }

        #endregion

    }
}
