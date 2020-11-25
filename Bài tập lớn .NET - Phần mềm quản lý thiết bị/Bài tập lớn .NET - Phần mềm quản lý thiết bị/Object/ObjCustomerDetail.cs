using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Object
{
    class ObjCustomerDetail
    {
        private string _id;

        public string Id_Customer
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nameCustomer;

        public string Name_Customer
        {
            get { return _nameCustomer; }
            set { _nameCustomer = value; }
        }

        private string _addressCustomer;

        public string Address_Customer
        {
            get { return _addressCustomer; }
            set { _addressCustomer = value; }
        }
        private string _grenderCustomer;

        public string Grender_Customer
        {
            get { return _grenderCustomer; }
            set { _grenderCustomer = value; }
        }
        private string _birthdayCustomer;

        public string Birthday_Customer
        {
            get { return _birthdayCustomer; }
            set { _birthdayCustomer = value; }
        }
        private string _identityCard;

        public string Identity_Card
        {
            get { return _identityCard; }
            set { _identityCard = value; }
        }
        private string _idGroup;

        public string Id_Group
        {
            get { return _idGroup; }
            set { _idGroup = value; }
        }
    }
}
