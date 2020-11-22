using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.HelperData;
using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class AccountCtrl
    {
        DataConfig helperData = new DataConfig();
        SqlConnection connect = ConnectDatabase.connect;
        AccountManage accMng = new AccountManage();
        
        public int Luu(ObjAccount ac)
        {
            return accMng.Update(ac);
        }

        private bool CheckCustomer(string name)
        {
            //query data
            string query = "SELECT Id_Customer FROM Account WHERE User_Name_Customer = '" + name + "' ";
            //action get database
            SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
            DataTable result = new DataTable();
            sqldata.Fill(result);
            // check database
            if (name == Login.user)
            {
                return false;
            }
            if (result.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public int Xoa(string id, string user, string pass)
        {
            return accMng.Xoa(id, user, pass);
        }

        public void HienThi(DataGridView dgv, string id_customer)
        {
            dgv.DataSource = accMng.GetDataAccount(id_customer).Tables[0];
        }

        public int Them(ObjAccount acc)
        {
            if (KiemTraMatk(Convert.ToInt32(acc.Id_Customer)) == false)
                return 0;
            if (!KiemTraTenTK(acc.UserName_Customer))
                return 2;
            return accMng.Save(acc);
        }

        public void HienThiTK(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = accMng.getListAcc(tukhoa, tieuchi).Tables[0];
        }

        public bool KiemTraMatk(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer_Detail WHERE Id_Customer = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("Mã tài khoản: " + e.Message);
                return false;
            }
            
        }

        public bool KiemTraTenTK(string username)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Account WHERE User_Name_Customer = @user";
                cmd.Parameters.Add("user", SqlDbType.NVarChar).Value = username;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }
    }
}
