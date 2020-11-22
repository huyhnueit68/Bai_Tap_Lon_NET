using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị
{
    class ConnectDatabase
    {
        public static SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-E5TVMPK\MSSQLSERVER01;Initial Catalog=QuanLyThietBi;Integrated Security=True");
    }
}
