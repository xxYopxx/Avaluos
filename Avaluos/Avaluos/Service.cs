using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    abstract class Service
    {
        #region Public properties

        public abstract int AmountPaid { get; set; }
        public abstract int AmountTotal { get; set; }
        public abstract Contact Client { get; set; }
        public abstract DateTime DateStart { get; set; }
        public abstract DateTime DateEnd { get; set; }

        #endregion

    }
}
