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
    public partial class AddNewTypeDevice : Form
    {
        public static string text;
        Controller.TypeDeviceCtrl TypeDeviceCtrl = new Controller.TypeDeviceCtrl();

        public AddNewTypeDevice()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtName_Device.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            Object.ObjTypeDevice objTypeDevice = new Object.ObjTypeDevice();
            if (checkNullItem())
            {
                GanDuLieu(objTypeDevice);
                {
                    switch (TypeDeviceCtrl.Them(objTypeDevice))
                    {
                        case 0:
                            text = "Vui lòng chọn tên loại thiết bị khác!";
                            ThongBao(text);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thôn tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoi()
        {
            txtName_Device.Clear();
        }

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void GanDuLieu(Object.ObjTypeDevice objType)
        {
            objType.Name_Device = txtName_Device.Text.Trim();
        }

        private bool checkNullItem()
        {
            if (txtName_Device.Text == "")
            {
                return false;
            }
            return true;
        }
    }
}
