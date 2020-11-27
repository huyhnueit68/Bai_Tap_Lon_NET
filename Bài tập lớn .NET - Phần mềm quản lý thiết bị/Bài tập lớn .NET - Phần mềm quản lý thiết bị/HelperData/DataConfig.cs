using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.HelperData
{
    class DataConfig
    {
        SqlConnection conn = ConnectDatabase.connect;

        public DataConfig()
        {
            KetNoi();
        }

        void KetNoi()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }


        public DataSet LayDuLieu(SqlCommand sqlcmd)
        {
            DataSet ds = new DataSet();
            sqlcmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(ds);
            return ds;
        }

        public int CapNhatDL(SqlCommand sqlcmd)
        {
            SqlCommand cmd = sqlcmd;
            cmd.Connection = conn;
            int kq = cmd.ExecuteNonQuery();
            return kq;
            /*try
            {
                SqlCommand cmd = sqlcmd;
                cmd.Connection = conn;
                int kq = cmd.ExecuteNonQuery();
                return kq;
            }
            catch(Exception ce)
            {
                Console.Write(ce.Message);
                return -9999;
            }*/

        }

        public bool CheckStatusLogin()
        {
            if(Login.resultLogin == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
