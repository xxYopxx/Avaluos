using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaluos
{
    class Contact
    {
        #region Private Members

        /// <summary>
        /// Contact's unique system assigned key
        /// </summary>
        int _sak;

        /// <summary>
        /// Contact's name
        /// </summary>
        string _name;

        /// <summary>
        /// Contact's physical address
        /// </summary>
        string _address;

        /// <summary>
        /// Contact's RFC
        /// </summary>
        string _RFC;

        /// <summary>
        /// Contact's NSS
        /// </summary>
        string _NSS;

        /// <summary>
        /// Contact's phone number
        /// </summary>
        string _phone;

        /// <summary>
        /// Contact's electronic mail address
        /// </summary>
        string _email;

        #endregion

        #region Public properties

        public int SAK_Contact
        {
            get { return _sak; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string RFC
        {
            get { return _RFC; }
            set { _RFC = value; }
        }

        public string NSS
        {
            get { return _NSS; }
            set { _NSS = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        #endregion

        #region Constructor

        public Contact()
        {

        }

        public Contact(int Sak)
        {

        }

        #endregion

    }
}
