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
    public partial class QuanLyThietBi : Form
    {
        Model.DeviceManage deviceMng = new Model.DeviceManage();
        public QuanLyThietBi()
        {
            InitializeComponent();
        }

        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            deviceMng.HienThi(dgvDSThietBi);
            HienThiThongTin();
            txtId_Device.Enabled = false;
            txtId_Type.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSThietBi.CurrentRow != null)
            {
                txtId_Device.Text = dgvDSThietBi.CurrentRow.Cells["Id_Device"].Value.ToString();
                txtName_Device.Text = dgvDSThietBi.CurrentRow.Cells["Name_Device"].Value.ToString();
                txtQty_Device.Text = dgvDSThietBi.CurrentRow.Cells["Qty_Device"].Value.ToString();
                txtPrice.Text = dgvDSThietBi.CurrentRow.Cells["Price"].Value.ToString();
                txtFunction_Device.Text = dgvDSThietBi.CurrentRow.Cells["Function_Device"].Value.ToString();
                txtRoom.Text = dgvDSThietBi.CurrentRow.Cells["Room"].Value.ToString();
                txtId_Type.Text = dgvDSThietBi.CurrentRow.Cells["Id_Type"].Value.ToString();
                txtStatus.Text = dgvDSThietBi.CurrentRow.Cells["Status_Device"].Value.ToString();
            }
        }
    }
}
