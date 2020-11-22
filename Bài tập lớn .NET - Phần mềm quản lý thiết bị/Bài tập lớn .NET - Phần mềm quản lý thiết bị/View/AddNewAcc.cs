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
    public partial class AddNewAcc : Form
    {
        public static DataGridView dgv = new DataGridView();
        Controller.AccountCtrl AccCtrl = new Controller.AccountCtrl();
        string text = "";
        Model.AccountManage acc = new Model.AccountManage();

        public AddNewAcc()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtPassWord.Clear();
            txtUserName.Clear();
            txtId.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ObjAccount ac = new ObjAccount();
            GanDuLieu(ac);
            {
                switch (AccCtrl.Them(ac))
                {
                    case 0:
                        text = "Không tồn tại mã tài khoản!";
                        ThongBao(text);
                        break;
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

        //Hàm làm mới các text.
        private void LamMoi()
        {
            txtId.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(ObjAccount tk)
        {
            tk.Id_Customer = txtId.Text.Trim();
            tk.UserName_Customer = txtUserName.Text.Trim();
            tk.PassWord_Customer = txtPassWord.Text.Trim();
        }

        private void AddNewAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
