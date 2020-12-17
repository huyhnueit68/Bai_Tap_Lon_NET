using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    public partial class BieuDoTBThanhLy : Form
    {
        Model.StatisticalMng statisticalMng = new Model.StatisticalMng();
        public BieuDoTBThanhLy()
        {
            InitializeComponent();
        }

        private void BieuDoTBThanhLy_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        //fillChart method  
        private void fillChart()
        {
            DataSet ds = new DataSet();
            ds = statisticalMng.getDeviceToChar();
            chartThanhLy.DataSource = ds;
            chartThanhLy.Series["Total"].XValueMember = "Year";
            chartThanhLy.Series["Total"].YValueMembers = "Total";
            chartThanhLy.Titles.Add("Total Device Chart");
        }
    }
}
