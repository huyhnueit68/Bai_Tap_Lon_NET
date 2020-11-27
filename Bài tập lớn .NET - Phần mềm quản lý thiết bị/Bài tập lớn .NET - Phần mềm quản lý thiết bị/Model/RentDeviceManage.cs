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

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataRentDevice(Login.getIdCustomerLogin()).Tables[0];
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

        public int PayDevice(Object.ObjRentDevice objRentDevice)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Rent_Device SET Status_Rent = N'Không sử dụng' WHERE Id_Rent = @idRent; ";

            cmd.Parameters.Add("idRent", SqlDbType.Int).Value = objRentDevice.Id_Rent;

            return cls.CapNhatDL(cmd);
        }
    }
}
