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
    class AccountManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataAccount(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Account");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Account WHERE Id_Customer = '" + Login.getIdCustomerLogin() + "'");
            }
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataAccount(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Update(ObjAccount acc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Account SET User_Name_Customer = @ten, PassWord_Customer = @pass WHERE Id_Customer = @id; ";

            cmd.Parameters.Add("ten", SqlDbType.NVarChar).Value = acc.UserName_Customer;
            cmd.Parameters.Add("pass", SqlDbType.NVarChar).Value = acc.PassWord_Customer;
            cmd.Parameters.Add("id", SqlDbType.Int).Value = acc.Id_Customer;

            return cls.CapNhatDL(cmd);
        }

        public int Save(ObjAccount acc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Account VALUES (@id, @user, @pass)";

            cmd.Parameters.Add("user", SqlDbType.NVarChar).Value = acc.UserName_Customer;
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = acc.PassWord_Customer;
            cmd.Parameters.Add("id", SqlDbType.Int).Value = acc.Id_Customer;

            return cls.CapNhatDL(cmd);
        }

        public int Xoa(string id, string user, string pass)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Account WHERE Id_Customer= @id AND User_Name_Customer = @user AND PassWord_Customer = @pass;";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            cmd.Parameters.Add("user", SqlDbType.NVarChar).Value = user;
            cmd.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListAcc(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Account WHERE ";

            switch (tieuchi)
            {
                case "Id_Customer":
                    sql += "Id_Customer = " + key + "";
                    break;
                default:
                    sql += "User_Name_Customer like '%" + key + "%'";
                    break;
            }
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sql);
                return cls.LayDuLieu(sqlcmd);
            }
            catch(Exception ce)
            {
                MessageBox.Show("Null " + ce.Message);
                return null;
            }
            
        }
    }
}
