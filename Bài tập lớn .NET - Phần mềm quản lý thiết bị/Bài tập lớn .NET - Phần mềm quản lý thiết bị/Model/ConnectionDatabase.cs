using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model
{
    public class ConnectionDatabase
    {
        string strServerName;
        string strDatabaseName;
        string strUserName;
        string strPassWord;
        SqlConnection sqlConnection;

        //ham tao
        public ConnectionDatabase() { }

        //ham doc thong tin ket noi database
        public void ReadXML()
        {
            string strPath = Path.GetFullPath("Server.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(strPath);
            if ((ds != null) && (ds.Tables[0].Rows.Count > 0))
            {
                strServerName = ds.Tables[0].Rows[0]["ServerName"].ToString().Trim();
                strDatabaseName = ds.Tables[0].Rows[0]["Database"].ToString().Trim();
                strUserName = ds.Tables[0].Rows[0]["UserName"].ToString().Trim();
                strPassWord = ds.Tables[0].Rows[0]["PassWord"].ToString().Trim();
            }
        }

        //ham ket noi toi database
        public void getConnectionDatabase()
        {
            ReadXML();
            string strConn = "Server ='" + strServerName + "';Initial Catalog ='" + strDatabaseName + "';User Id='" + strUserName + "';pwd='" + strPassWord  + "';";
            sqlConnection = new SqlConnection(strConn);
            if ((sqlConnection != null) && (sqlConnection.State == ConnectionState.Closed))
            {
                sqlConnection.Open();
            }
        }

    }
}
