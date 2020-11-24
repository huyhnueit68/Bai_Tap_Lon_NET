using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class CustomerDetailCtrl
    {
        Model.CustomerManage customerDetailMng = new Model.CustomerManage();
        public int Xoa(string id)
        {
            return customerDetailMng.Xoa(id);
        }

        public void HienThi(DataGridView dgv, string id_customer)
        {
            dgv.DataSource = customerDetailMng.GetDataCustomer(id_customer).Tables[0];
        }
    }
}
