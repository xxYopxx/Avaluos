using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class ServiceAC : Service
    {
        #region Private members

        int _amountPaid;
        int _amountTotal;
        Contact _client;
        DateTime _dateStart;
        DateTime _dateEnd;

        #endregion

        #region Public properties

        public override int AmountPaid { get { return _amountPaid; } set { _amountPaid = value; } }
        public override int AmountTotal { get { return _amountTotal; } set { _amountTotal = value; } }
        public override Contact Client { get { return _client; } set { _client = value; } }
        public override DateTime DateEnd { get { return _dateEnd; } set { _dateStart = value; } }
        public override DateTime DateStart { get { return _dateStart; } set { _dateStart = value; } }

        #endregion

        #region Constructor

        public ServiceAC(int amountPaid, int amountTotal, Contact client, DateTime dateEnd, DateTime dateStart)
        {

        }

        #endregion

    }
}
