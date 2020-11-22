using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị
{
    class ObjAccount
    {
        private string _id;

        public string Id_Customer
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _userName;

        public string UserName_Customer
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _passWord;

        public string PassWord_Customer
        {
            get { return _passWord; }
            set { _passWord = value; }
        }

    }
}
