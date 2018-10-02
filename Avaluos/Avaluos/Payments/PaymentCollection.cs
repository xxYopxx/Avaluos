using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class PaymentCollection
    {
        #region Private members

        int _sakService;
        List<Payment> _payments;

        #endregion
        
        #region Public properties

        public List<Payment> Payments { get { return _payments; } }

        #endregion

        #region Constructor

        public PaymentCollection(int sak)
        {
            _sakService = sak;
            _payments = new List<Payment>();
        }

        #endregion

        #region Data operations

        private void RetrievePayments()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT * FROM PAYMENTS WHERE SAK_SERVICE = ?";
            db.AddParameter("@SAK", _sakService, System.Data.Odbc.OdbcType.Int);
            DataTable results = db.ExecuteReader();
            if (results!=null && results.Rows.Count > 0)
            {
                foreach(DataRow row in results.Rows)
                {
                    Payment item = new Payment(Convert.ToInt32(row["SAK_PAYMENT"]));
                    _payments.Add(item);
                }
            }
        }

        #endregion
    }
}
