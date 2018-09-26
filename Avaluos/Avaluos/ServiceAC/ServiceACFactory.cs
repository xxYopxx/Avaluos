using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class ServiceACFactory: ServiceFactory
    {
        int _amountPaid;
        int _amountTotal;
        Contact _client;
        DateTime _dateStart;
        DateTime _dateEnd;

        #region Constructor

        public ServiceACFactory(int amountPaid, int amountTotal, Contact client, DateTime dateStart, DateTime dateEnd)
        {
            _amountPaid = amountPaid;
            _amountTotal = amountTotal;
            _client = client;
            _dateStart = dateStart;
            _dateEnd = dateEnd;
        }

        public override Service GetService()
        {
            return new ServiceAC(_amountPaid, _amountTotal, _client, _dateEnd, _dateStart);
        }

        #endregion
    }
}
