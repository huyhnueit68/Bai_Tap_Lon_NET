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
    public partial class AddNewCustomerGroup : Form
    {
        public static string text = "";
        Controller.CustomerGroupCtrl customerGroupCtrl = new Controller.CustomerGroupCtrl();
        public AddNewCustomerGroup()
        {
            InitializeComponent();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtName_Group.Clear();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjCustomerGroup customerGroup)
        {
            customerGroup.Name_Group = txtName_Group.Text.Trim();
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Hàm làm mới các text.
        private void LamMoi()
        {
            txtName_Group.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddNewCustomerGroup_Load(object sender, EventArgs e)
        {

        }

        private void btnThemTaiKhoan_Click_1(object sender, EventArgs e)
        {
            Object.ObjCustomerGroup ctg = new Object.ObjCustomerGroup();
            GanDuLieu(ctg);
            {
                switch (customerGroupCtrl.Them(ctg))
                {
                    case 1:
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LamMoi();
                        break;
                    case 2:
                        text = "Vui lòng chọn tên đăng nhập khác!";
                        ThongBao(text);
                        break;
                }
            }
        }
    }
}
