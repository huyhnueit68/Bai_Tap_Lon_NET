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
    class RentDeviceManage
    {
        DataConfig cls = new DataConfig();

        public DataSet GetDataRentDevice(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device WHERE Id_Customer  = " + Login.getIdCustomerLogin() + "");
            }
            return cls.LayDuLieu(sqlcmd);
        }

        public DataSet GetDataRentDevicePay(string idCustomer)
        {
            SqlCommand sqlcmd;
            if (cls.CheckStatusLogin() == true)
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device WHERE Status_Rent = N'Đang sử dụng'");
            }
            else
            {
                sqlcmd = new SqlCommand("SELECT * FROM Rent_Device WHERE Status_Rent = N'Đang sử dụng'AND Id_Customer  = " + Login.getIdCustomerLogin() + "");
            }
            return cls.LayDuLieu(sqlcmd);
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataRentDevice(Login.getIdCustomerLogin()).Tables[0];
        }

        public void HienThiTra(DataGridView dgv)
        {
            dgv.DataSource = GetDataRentDevicePay(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Update(Object.ObjRentDevice objRentDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Rent_Device " +
                "SET Date_Rent = @dayRent, Date_Pay = @dayPay, " +
                "Id_Device = @idDevice, " +
                "Qty_Device = @qtyDevice, " +
                "Id_Customer = @idCustomer, " +
                "Status_Rent = @status " +
                "WHERE Id_Rent = @idRent; ";

            cmd.Parameters.Add("dayRent", SqlDbType.DateTime).Value = objRentDevice.Day_Rent;
            cmd.Parameters.Add("dayPay", SqlDbType.DateTime).Value = objRentDevice.Day_Pay;
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = objRentDevice.Id_Device;
            cmd.Parameters.Add("qtyDevice", SqlDbType.Int).Value = objRentDevice.Qty_Device;
            cmd.Parameters.Add("idCustomer", SqlDbType.Int).Value = objRentDevice.Id_Customer;
            cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = objRentDevice.Status_Device;
            cmd.Parameters.Add("idRent", SqlDbType.Int).Value = objRentDevice.Id_Rent;

            return cls.CapNhatDL(cmd);
        }

        public int UpdatePay(Object.ObjRentDevice objRentDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Rent_Device " +
                "SET Status_Rent = N'Không sử dụng' " +
                "WHERE Id_Rent = @idRent; ";

            cmd.Parameters.Add("idRent", SqlDbType.Int).Value = objRentDevice.Id_Rent;
            UpdateStatusDevicePay(objRentDevice);
            return cls.CapNhatDL(cmd);
        }

        public void UpdateStatusDevicePay(Object.ObjRentDevice objRentDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device SET Status_Device = N'Không sử dụng' WHERE Id_Device = @idDevice; ";
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = objRentDevice.Id_Device;
            cls.CapNhatDL(cmd);
        }

        //Hàm xử lý lấy danh sách.
        public DataSet LayDSThietBi()
        {
            string select = "SELECT * ",
                from = "FROM Device WHERE Status_Device  = N'Không sử dụng'";

            SqlCommand cmd = new SqlCommand(select + from);
            return cls.LayDuLieu(cmd);
        }

        public int Save(Object.ObjRentDevice cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Rent_Device(Date_Rent, Date_Pay, Id_Device, Qty_Device, Id_Customer, Status_Rent) " +
                "VALUES (@dateRent, @datePay, @idDevice, @qtyDevice, @idCustomer, N'Đang sử dụng'); ";

            cmd.Parameters.Add("dateRent", SqlDbType.DateTime).Value = cdt.Day_Rent;
            cmd.Parameters.Add("datePay", SqlDbType.DateTime).Value = cdt.Day_Pay;
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
            cmd.Parameters.Add("qtyDevice", SqlDbType.Int).Value = cdt.Qty_Device;
            cmd.Parameters.Add("idCustomer", SqlDbType.Int).Value = cdt.Id_Customer;
            UpdateStatusDevice(cdt);
            return cls.CapNhatDL(cmd);
        }

        public void UpdateStatusDevice(Object.ObjRentDevice cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device SET Status_Device = N'Đang sử dụng' WHERE Id_Device = @idDevice; ";
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
            cls.CapNhatDL(cmd);
        }

        public DataSet getListRent(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Rent_Device WHERE ";

            if (Login.resultLogin != 1) {
                sql += "Id_Customer = " + Login.getIdCustomerLogin() + " AND ";
            }

            switch (tieuchi)
            {
                case "Id_Rent":
                    sql += "Id_Rent = " + key + "";
                    break;
                default:
                    sql += "Id_Device = " + key + "";
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
