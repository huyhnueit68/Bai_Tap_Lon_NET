using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.HelperData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model
{
    class StatisticalMng
    {
        DataConfig cls = new DataConfig();

        public DataTable HTTongTBDung()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT COUNT(*) AS Total_Device FROM Device WHERE Status_Device = N'Đang sử dụng'";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                sqldata.Fill(result);
            }
            catch (Exception ce)
            {
                
            }
            return result;
        }

        public DataTable HTTongThanhLy()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT COUNT(*) AS Total_Liqui FROM Liquidate";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
                sqldata.Fill(result);
            }
            catch (Exception ce)
            {

            }
            return result;
        }

        public DataSet getListDeviceByTime(DateTime start, DateTime end)
        {
            SqlCommand sqlcmd = new SqlCommand("SELECT D.Id_Device AS 'MÃ THIẾT BỊ', " +
                "D.Name_Device AS 'TÊN THIẾT BỊ', " +
                "RD.Qty_Device AS 'SỐ LƯỢNG MƯỢN', " +
                "RD.Id_Rent AS 'MÃ MƯỢN', " +
                "RD.Date_Rent AS 'NGÀY MƯỢN', " +
                "CD.Name_Customer AS 'TÊN NGƯỜI DÙNG' FROM Rent_Device AS RD, " +
                "Device AS D, " +
                "Customer_Detail AS CD " +
                "WHERE Date_Rent >= '" + start.ToString() + "' " +
                "AND Date_Rent <= '" + end.ToString() + "' " +
                "AND RD.Id_Device = D.Id_Device " +
                "AND RD.Id_Customer = CD.Id_Customer");
            try
            {
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception ce)
            {
                return null;
            }
        }

        public DataSet getListDeviceByName(string name)
        {
            SqlCommand sqlcmd = new SqlCommand("SELECT D.Id_Device as 'MÃ THIẾT BỊ', " +
                "D.Name_Device as 'TÊN THIẾT BỊ', " +
                "RD.Qty_Device as 'SỐ LƯỢNG MƯỢN', " +
                "RD.Date_Rent as 'NGÀY MƯỢN', " +
                "CD.Name_Customer AS 'TÊN NGƯỜI DÙNG' " +
                "FROM Rent_Device as RD, Device as D, Customer_Detail as CD " +
                "WHERE CD.Name_Customer LIKE '%"+name+"%' " +
                "AND RD.Id_Device = D.Id_Device " +
                "AND RD.Id_Customer = CD.Id_Customer");
            try
            {
                return cls.LayDuLieu(sqlcmd);
            }
            catch (Exception ce)
            {
                return null;
            }

        }

        public DataSet getDeviceToChar()
        {
            SqlConnection connect = ConnectDatabase.connect;
            string query = "SELECT DATEPART(yyyy, Date_Liqui) AS 'Year', SUM(Qty_Device) AS 'Total' FROM Liquidate GROUP BY DATEPART(yyyy, Date_Liqui)";

            //action get database
            DataSet result = new DataSet();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                sqldata.Fill(result);
            }
            catch (Exception ce)
            {

            }
            return result;
        }
    }
}
