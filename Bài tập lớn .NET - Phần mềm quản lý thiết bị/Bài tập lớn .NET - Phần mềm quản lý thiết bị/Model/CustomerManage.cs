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

        public int Update(Object.ObjCustomerDetail customerDetail)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Customer_Detail SET Name_Customer = @name, Address_Customer = @address, Grender_Customer = @gt, Birthday_Customer = @birthday, Identity_Card = @identity, Id_Group = @idGroup WHERE Id_Customer = @idCustomer;";

            cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = customerDetail.Name_Customer;
            cmd.Parameters.Add("address", SqlDbType.NVarChar).Value = customerDetail.Address_Customer;
            cmd.Parameters.Add("gt", SqlDbType.NVarChar).Value = customerDetail.Grender_Customer;
            cmd.Parameters.Add("birthday", SqlDbType.DateTime).Value = customerDetail.Birthday_Customer;
            cmd.Parameters.Add("identity", SqlDbType.VarChar).Value = customerDetail.Identity_Card;
            cmd.Parameters.Add("idGroup", SqlDbType.Int).Value = customerDetail.Id_Group;
            cmd.Parameters.Add("idCustomer", SqlDbType.Int).Value = customerDetail.Id_Customer;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjCustomerDetail cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO " +
                "Customer_Detail(Name_Customer, Address_Customer, Grender_Customer, Birthday_Customer, Identity_Card, Id_Group) " +
                "VALUES (@name_customer, @address_customer, @grender_customer, @birthday_customer, @identity_card, @id_group)";

            cmd.Parameters.Add("name_customer", SqlDbType.NVarChar).Value = cdt.Name_Customer;
            cmd.Parameters.Add("address_customer", SqlDbType.NVarChar).Value = cdt.Address_Customer;
            cmd.Parameters.Add("grender_customer", SqlDbType.NVarChar).Value = cdt.Grender_Customer;
            cmd.Parameters.Add("birthday_customer", SqlDbType.DateTime).Value = cdt.Birthday_Customer;
            cmd.Parameters.Add("identity_card", SqlDbType.VarChar).Value = cdt.Identity_Card;
            cmd.Parameters.Add("id_group", SqlDbType.Int).Value = cdt.Id_Group;

            return cls.CapNhatDL(cmd);
        }

        public DataSet getListCustomerDetail(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Customer_Detail WHERE ";

            switch (tieuchi)
            {
                case "Id_Customer":
                    sql += "Id_Customer = " + key + "";
                    break;
                default:
                    sql += "Name_Customer like '%" + key + "%'";
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
