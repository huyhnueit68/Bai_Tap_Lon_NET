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
    public partial class Default : Form
    {
        public Default()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbtGio.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThang.Text = datetime.ToString("dd/MM/yyyy");
            this.lbThu.Text = datetime.ToString("dddd");
        }
    }
}
