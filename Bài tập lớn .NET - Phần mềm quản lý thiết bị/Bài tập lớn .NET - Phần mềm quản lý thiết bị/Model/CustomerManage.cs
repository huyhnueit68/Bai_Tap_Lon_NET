using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model
{
    class CustomerManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataCustomer(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Customer_Detail");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Customer_Detail WHERE Id_Customer  = " + Login.getIdCustomerLogin() + "");
            }
            return cls.LayDuLieu(sqlcmd);
        }
        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataCustomer(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Customer_Detail WHERE Id_Customer = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }
    }
}
