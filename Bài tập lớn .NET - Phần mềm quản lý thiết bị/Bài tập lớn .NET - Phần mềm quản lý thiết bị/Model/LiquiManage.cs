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
    class LiquiManage
    {
        const int ERRO_LOG = -9999;
        DataConfig cls = new DataConfig();

        public void HienThi(DataGridView dgv)
        {
            dgv.DataSource = GetDataLiqui(Login.getIdCustomerLogin()).Tables[0];
        }

        public int Xoa(string id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Liquidate WHERE Id_Liqui = @id";
            cmd.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(id);
            return cls.CapNhatDL(cmd);
        }

        public DataSet GetDataLiqui(string idCustomer)
        {
            SqlCommand sqlcmd;
            sqlcmd = new SqlCommand("SELECT * FROM Liquidate");
            return cls.LayDuLieu(sqlcmd);
        }

        //Hàm xử lý lấy danh sách.
        public DataSet LayDSThietBi()
        {
            string select = "SELECT * ",
                from = "FROM Device WHERE Status_Device  = N'Không sử dụng'";

            SqlCommand cmd = new SqlCommand(select + from);
            return cls.LayDuLieu(cmd);
        }

        public int Save(Object.ObjLiqui cdt)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO Liquidate(Name_Liqui, Id_Device, Date_Liqui) " +
                    "VALUES (@nameLiqui, @idDevice, @dateLiqui); ";
                cmd.Parameters.Add("nameLiqui", SqlDbType.NVarChar).Value = cdt.Name_Liqui;
                cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
                cmd.Parameters.Add("dateLiqui", SqlDbType.Date).Value = cdt.Date_Liqui;
                //update status device after liquidate
                if (cls.CapNhatDL(cmd) == 1)
                {
                    UpdateStatusDevice(cdt);
                    return 1;
                }
                return ERRO_LOG;
            }
            catch (Exception e)
            {
                return ERRO_LOG;
            }
        }

        public void UpdateStatusDevice(Object.ObjLiqui cdt)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Device SET Status_Device = N'Thanh lý' WHERE Id_Device = @idDevice; ";
            cmd.Parameters.Add("idDevice", SqlDbType.Int).Value = cdt.Id_Device;
            cls.CapNhatDL(cmd);
        }

        public int Update(Object.ObjLiqui objLiqui)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Liquidate " +
                "SET Name_Liqui = @nameLiqui, " +
                "Id_Device = @idDevice, " +
                "Date_Liqui = @date " +
                "WHERE Id_Liqui = @idLiqui";

            cmd.Parameters.Add("nameLiqui", SqlDbType.NVarChar).Value = objLiqui.Name_Liqui;
            cmd.Parameters.Add("idDevice", SqlDbType.NVarChar).Value = objLiqui.Id_Device;
            cmd.Parameters.Add("date", SqlDbType.DateTime).Value = objLiqui.Date_Liqui;
            cmd.Parameters.Add("idLiqui", SqlDbType.VarChar).Value = objLiqui.Id_Liqui;
            
            return cls.CapNhatDL(cmd);
        }

        public DataSet getListLiqui(string key, string tieuchi)
        {
            string sql = "SELECT * FROM Liquidate WHERE ";

            switch (tieuchi)
            {
                case "Id_Liqui":
                    sql += "Id_Liqui = " + key + "";
                    break;
                default:
                    sql += "Name_Liqui like '%" + key + "%'";
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
