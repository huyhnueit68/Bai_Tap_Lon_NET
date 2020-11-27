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
    public partial class AddNewDevice : Form
    {
        Controller.DeviceCtrl deviceCtrl = new Controller.DeviceCtrl();
        public static string text = "";
        public AddNewDevice()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtName_Device.Clear();
            txtQty_Device.Clear();
            txtPrice.Clear();
            txtFunction_Device.Clear();
            txtRoom.Clear();
            txtId_Type.Clear();
            txtStatus_Device.Clear();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            Object.ObjDevice objDevice = new Object.ObjDevice();
            GanDuLieu(objDevice);
            {
                switch (deviceCtrl.Them(objDevice))
                {
                    case 0:
                        text = "Vui lòng chọn mã tài khoản khác!";
                        ThongBao(text);
                        break;
                    case 1:
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoi();
                        break;
                    case 2:
                        text = "Vui lòng mã loại thiết bị khác!";
                        ThongBao(text);
                        break;

                }
            }
        }

        private void LamMoi()
        {
            txtName_Device.Clear();
            txtQty_Device.Clear();
            txtPrice.Clear();
            txtFunction_Device.Clear();
            txtRoom.Clear();
            txtId_Type.Clear();
            txtStatus_Device.Clear();
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjDevice objDevice)
        {
            objDevice.Name_Device = txtName_Device.Text.Trim();
            objDevice.Qty_Device = txtQty_Device.Text.Trim();
            objDevice.Price = txtPrice.Text.Trim();
            objDevice.Function_Device = txtFunction_Device.Text.Trim();
            objDevice.Room = txtRoom.Text.Trim();
            objDevice.Id_Type = txtId_Type.Text.Trim();
            objDevice.Status_Device = txtStatus_Device.Text.Trim();
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
