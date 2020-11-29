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
    class DeviceManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataDevice(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Device");
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataDevice(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Device WHERE Id_Device = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjDevice objDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device " +
                "SET Name_Device = @nameDevice, " +
                "Price = @price, Function_Device = @function, " +
                "Qty_Device = @qtyDevice, " +
                "Room = @room, Id_Type = @idType, " +
                "Status_Device = @status " +
                "WHERE Id_Device = @idDevice; ";

            cmd.Parameters.Add("nameDevice", SqlDbType.NVarChar).Value = objDevice.Name_Device;
            cmd.Parameters.Add("price", SqlDbType.Float).Value = objDevice.Price;
            cmd.Parameters.Add("qtyDevice", SqlDbType.Int).Value = objDevice.Qty_Device;
            cmd.Parameters.Add("function", SqlDbType.NVarChar).Value = objDevice.Function_Device;
            cmd.Parameters.Add("room", SqlDbType.VarChar).Value = objDevice.Room;
            cmd.Parameters.Add("idType", SqlDbType.Int).Value = objDevice.Id_Type;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = objDevice.Status_Device;
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = objDevice.Id_Device;

            return cls.CapNhatDL(cmd);
        }

        public int Save(Object.ObjDevice objDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Device(Name_Device, Price, ,Qty_Device, Function_Device, Room, Id_Type, Status_Device) " +
                "VALUES (@nameDevice, @price, @qtyDevice,@function, @room, @idType, @status);";

            cmd.Parameters.Add("nameDevice", SqlDbType.NVarChar).Value = objDevice.Name_Device;
            cmd.Parameters.Add("price", SqlDbType.NVarChar).Value = objDevice.Price;
            cmd.Parameters.Add("qtyDevice", SqlDbType.Int).Value = objDevice.Qty_Device;
            cmd.Parameters.Add("function", SqlDbType.NVarChar).Value = objDevice.Function_Device;
            cmd.Parameters.Add("room", SqlDbType.NVarChar).Value = objDevice.Room;
            cmd.Parameters.Add("idType", SqlDbType.NVarChar).Value = objDevice.Id_Type;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = objDevice.Status_Device;

            return cls.CapNhatDL(cmd);
        }

        public DataSet getListDevice(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Device WHERE ";

            switch (tieuchi)
            {
                case "Id_Device":
                    sql += "Id_Device = " + key + "";
                    break;
                case "Name_Device":
                    sql += "Name_Device like '%" + key + "%'";
                    break;
                case "Room":
                    sql += "Room like '%" + key + "%'";
                    break;
                default:
                    sql += "Id_Type = " + key + "";
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
