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
    class TypeDeviceMng
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataTypeDevice(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Type_Device");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataTypeDevice(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Update(Object.ObjTypeDevice objType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Type_Device SET Name_Device = @nameDevcie WHERE Id_Type = @id; ";

            cmd.Parameters.Add("nameDevcie", SqlDbType.NVarChar).Value = objType.Name_Device;
            cmd.Parameters.Add("id", SqlDbType.Int).Value = objType.Id_Type;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjTypeDevice objType)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Type_Device(Name_Device) VALUES (@nameDevice);";

            cmd.Parameters.Add("nameDevice", SqlDbType.NVarChar).Value = objType.Name_Device;

            return cls.CapNhatDL(cmd);
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Type_Device WHERE Id_Type = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListTypeDevice(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Type_Device WHERE ";

            switch (tieuchi)
            {
                case "Id_Type":
                    sql += "Id_Type = " + key + "";
                    break;
                default:
                    sql += "Name_Device like '%" + key + "%'";
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
