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
    class CustomerGroupManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataCustomer(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Customer_Group");
            return cls.LayDuLieu(sqlcmd);
        }
        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataCustomer(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Customer_Group WHERE Id_Group = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjCustomerGroup customerGroup)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Customer_Group SET Name_Group = @name WHERE Id_Group = @idGroup;";

            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = customerGroup.Name_Group;
            cmd.Parameters.Add("idGroup", SqlDbType.Int).Value = customerGroup.Id_Group;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjCustomerGroup ctg)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Customer_Group (Name_Group) VALUES (@name)";

            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = ctg.Name_Group;
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListCustomerGroup(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Customer_Group WHERE ";

            switch (tieuchi)
            {
                case "Id_Group":
                    sql += "Id_Group = " + key + "";
                    break;
                default:
                    sql += "Name_Group like '%" + key + "%'";
                    break;
            }
            try
            {
                SqlCommand sqlcmd = new SqlCommand(sql);
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception ce)
            {
                MessageBox.Show("Null " + ce.Message);
                return null;
            }

        }
    }
}
