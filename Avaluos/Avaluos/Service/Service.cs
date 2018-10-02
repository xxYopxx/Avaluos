using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class Service
    {
        #region Private members

        string _notes;
        int _sakService;
        int _sakStatus;
        int _sakType;
        int _amountTotal;
        Contact _client;
        Contact _seller;
        DateTime _dateStart;
        DateTime _dateEnd;
        DateTime _dateVisit;
        DocumentCollection _documents;
        PaymentCollection _payments;
        Dictionary<int, string> _statusList;
        Dictionary<int, string> _serviceTypeList;

        #endregion

        #region Public properties

        public int sak { get { return _sakService; } set { _sakService = value; } }
        public int ServiceType { get { return _sakType; } set { _sakType = value; } }
        public int Status { get { return _sakStatus; } set { _sakStatus = value; } }
        public int AmountTotal { get { return _amountTotal; } set { _amountTotal = value; } }
        public string Notes { get { return _notes; } set { _notes = value; } }
        public Contact Client { get { return _client; } set { _client = value; } }
        public Contact Seller { get { return _client; } set { _seller = value; } }
        public DateTime DateStart { get { return _dateStart; } set { _dateStart = value; } }
        public DateTime DateEnd { get { return _dateEnd; } set { _dateEnd = value; } }
        public DateTime DateVisit { get { return _dateVisit; } set { _dateVisit = value; } }
        public DocumentCollection Documents { get { return _documents; } }
        public PaymentCollection Payments { get { return _payments; } }
        public Dictionary<int, string> StatusList { get { return _statusList; } }
        public Dictionary<int, string> ServiceTypeList { get { return _serviceTypeList; } }

        #endregion

        #region Constructor

        public Service()
        {
            FillStatusList();
            FillServiceTypeList();
        }

        public Service(int sak)
        {
            _sakService = sak;
            GetService();
            GetDocuments();
            GetPayments();
            FillStatusList();
            FillServiceTypeList();
        }

        #endregion

        #region Functionality

        public bool Save()
        {
            return Persist();
        }

        private void FillStatusList()
        {
            _statusList = new Dictionary<int, string>();
            _statusList.Add(1, "Solicitud");
            _statusList.Add(2, "En Proceso");
            _statusList.Add(3, "Aprobado");
            _statusList.Add(4, "Entregado");
            _statusList.Add(5, "Sin Documentos");
            _statusList.Add(6, "Detenido");
            _statusList.Add(7, "Pago Pendiente");
        }

        private void FillServiceTypeList()
        {
            _serviceTypeList = new Dictionary<int, string>();
            _serviceTypeList.Add(1, "Avaluo Catastral");
            _serviceTypeList.Add(2, "Estimacion");
            _serviceTypeList.Add(3, "MAI");
            _serviceTypeList.Add(4, "Plano");
        }

        #endregion

        #region DataOperations

        private bool Persist()
        {
            SQLiteLink db = new SQLiteLink();
            if (_sakService == -1)
            {
                GetLastID();
                db.Query = "INSERT INTO SERVICES(SAK_CONTACT,SAK_SERVICE_TYPE, SAK_CONTACT_SELLER, SAK_STATUS, AMOUNT_TOTAL, DTE_START, DTE_END, DTE_VISIT, NOTES, SAK_SERVICE) VALUES(?,?,?,?,?,?,?,?,?,?)";
            }
            else
                db.Query = "UPDATE SERVICES SET SAK_SERVICE_TYPE=?, SAK_CONTACT=?, SAK_CONTACT_SELLER=?, SAK_STATUS=?, AMOUNT_TOTAL=?, DTE_START=?, DTE_END=?, DTE_VISIT=?, NOTES=? WHERE SAK_SERVICE = ?";
            db.AddParameter("@TYPE", _sakType, System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@CONTACT", _client.SAK_Contact, System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@SELLER", (_seller != null ? _seller.SAK_Contact : 0), System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@STATUS", _sakStatus, System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@AMOUNT_TOTAL", _amountTotal, System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@START", Convert.ToInt32(_dateStart.ToString("yyyyMMdd")), System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@END", Convert.ToInt32(_dateEnd.ToString("yyyyMMdd")), System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@VISIT", Convert.ToInt32(_dateEnd.ToString("yyyyMMdd")), System.Data.Odbc.OdbcType.Int);
            db.AddParameter("@NOTES", _notes, System.Data.Odbc.OdbcType.Text);
            db.AddParameter("@SAK", _sakService, System.Data.Odbc.OdbcType.Int);
            return db.ExecuteCommand() == 1;
        }

        private void GetService()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT * FROM SERVICES WHERE SAK_SERVICE = ?";
            db.AddParameter("@SAK", _sakService, System.Data.Odbc.OdbcType.Int);
            DataTable results = db.ExecuteReader();
            if (results !=null && results.Rows.Count>0)
            {
                foreach (DataRow row in results.Rows)
                {
                    _sakType = Convert.ToInt32(row["SAK_SERVICE_TYPE"]);
                    _client = new Contact(Convert.ToInt32(row["SAK_CONTACT"]));
                    _seller = new Contact(Convert.ToInt32(row["SAK_CONTACT_SELLER"]));
                    _sakStatus = Convert.ToInt32(row["SAK_STATUS"]);
                    _amountTotal = Convert.ToInt32(row["AMOUNT_TOTAL"]);
                    _dateStart = DateTime.ParseExact(row["DTE_START"].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    _dateEnd = DateTime.ParseExact(row["DTE_END"].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    _dateVisit = DateTime.ParseExact(row["DTE_VISIT"].ToString(), "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    _notes = row["NOTES"].ToString();
                }
            }
        }

        private void GetLastID()
        {
            SQLiteLink db = new SQLiteLink();
            db.Query = "SELECT MAX(SAK_SERVICE) as LAST FROM SERVICES";
            DataTable results = db.ExecuteReader();
            if (results != null && results.Rows.Count > 0)
            {
                foreach (DataRow row in results.Rows)
                {
                    _sakService = row["LAST"] != DBNull.Value ? Convert.ToInt32(row["LAST"]) + 1 : 1;
                }
            }
        }

        private void GetDocuments()
        {
            _documents = new DocumentCollection(_sakService);
        }

        private void GetPayments()
        {
            _payments = new PaymentCollection(_sakService);
        }

        #endregion

    }
}
