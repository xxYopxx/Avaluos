using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class Payment
    {
        #region Private members

        int _sakPayment;
        int _sakService;
        int _amount;
        DateTime _datePaid;

        #endregion

        #region Public properties

        public int SakService
        {
            get { return _sakService; }
            set { _sakService = value; }
        }

        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public DateTime DatePaid
        {
            get { return _datePaid; }
            set { _datePaid = value; }
        }

        #endregion

        #region Constructor

        public Payment()
        {
            
        }

        public Payment(int sak)
        {
            _sakService = sak;
        }

        #endregion

        #region Functionality

        public bool Save()
        {
            return AddPayment();
        }

        #endregion

        #region Data operations

        private bool AddPayment()
        {
            GetLastID();
            SQLiteLink db = new SQLiteLink();
            db.Query = "INSERT INTO PAYMENTS(SAK_PAYMENT,SAK_SERVICE,AMOUNT,DTE_PAYMENT) VALUES(?,?,?,?)";
            db.AddParameter("@SAK", _sakPayment, System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@SAKSERVICE", _sakService, System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@AMOUNT", _amount, System.Data.Odbc.OdbcType.Numeric);
            db.AddParameter("@DATEPAID", Convert.ToInt32(_datePaid.ToString("yyyyMMdd")), System.Data.Odbc.OdbcType.Int);
            return db.ExecuteCommand() == 1;   
        }

        private void GetLastID()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT MAX(SAK_) as LAST FROM CONTACTS";
            DataTable results = db.ExecuteReader();
            if (results != null && results.Rows.Count > 0)
            {
                foreach (DataRow row in results.Rows)
                {
                    _sakPayment = row["LAST"] != DBNull.Value ? Convert.ToInt32(row["LAST"]) + 1 : 1;
                }
            }
        }
        

        #endregion
    }
}
