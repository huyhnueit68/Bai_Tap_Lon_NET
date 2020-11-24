using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller;
using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Model;
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
    public partial class QuanLyTaiKhoan : Form
    {
        string text = "";
        AccountManage acc = new AccountManage();
        AccountCtrl accCtrl = new AccountCtrl();
        public static bool loginAcc = false;
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            txtId_Customer.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            if(Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            acc.HienThi(dgvDSTaiKhoan);
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            acc.HienThi(dgvDSTaiKhoan);
            ResetTextBox();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if(checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                ObjAccount objAcc = new ObjAccount();
                SetDataAccount(objAcc);


                string Id_Customer = dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    try
                    {
                       
                        if (accCtrl.Luu(objAcc) > 0)
                        {
                            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            acc.HienThi(dgvDSTaiKhoan);
                            HienThiThongTin();
                        }
                        else
                        {
                            MessageBox.Show("Không tại mã người dùng này, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(Exception ce)
                    {
                        MessageBox.Show("Đã tồn tại tên tài khoản tương tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(ce.Message);
                    }
                }
            }
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSTaiKhoan.CurrentRow != null)
            {
                txtId_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Id_Customer"].Value.ToString();
                txtUsername.Text = dgvDSTaiKhoan.CurrentRow.Cells["User_Name_Customer"].Value.ToString();
                txtMaTK.Text = dgvDSTaiKhoan.CurrentRow.Cells["PassWord_Customer"].Value.ToString();
            }
        }

        private void dgvDSTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            acc.HienThi(dgvDSTaiKhoan);
            AddNewAcc formAddAcc = new AddNewAcc();
            formAddAcc.Show();
        }

        private void ResetTextBox()
        {
            txtId_Customer.Text = "";
            txtUsername.Text = "";
            txtMaTK.Text = "";
            txtTimKiem.Text = "";
        }

        private bool checkNullTextBox()
        {
            if(txtId_Customer.Text.Trim() == "")
            {
                errId_Customer.SetError(txtId_Customer, "Nhập vào mã khách hàng");
                return false;
            }
            if (txtUsername.Text.Trim() == "")
            {
                errUser_Name.SetError(txtUsername, "Nhập vào mật khẩu khách hàng");
                return false;
            }
            if (txtMaTK.Text.Trim() == "")
            {
                errPass_Word.SetError(txtMaTK, "Nhập vào mật khẩu khách hàng");
                return false;
            }
            else
            {
                errId_Customer.SetError(txtId_Customer, "");
                errId_Customer.SetError(txtMaTK, "");
                errId_Customer.SetError(txtUsername, "");
                return true;
            }

        }

        //Hàm xử lý lưu dữ liệu.
        private void SetDataAccount(ObjAccount tk)
        {
            tk.Id_Customer = txtId_Customer.Text;
            tk.UserName_Customer = txtUsername.Text;
            tk.PassWord_Customer = txtMaTK.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvDSTaiKhoan.CurrentRow.Cells[0].Value.ToString();
                string user_name = dgvDSTaiKhoan.CurrentRow.Cells[1].Value.ToString();
                string pass = dgvDSTaiKhoan.CurrentRow.Cells[2].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    accCtrl.Xoa(id_customer, user_name, pass);
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        accCtrl.HienThi(dgvDSTaiKhoan, id_customer);
                    }
                    if (!MainControl.onLoadCheckAccLogin())
                    {
                        loginAcc = true;
                        MessageBox.Show("Đăng xuất do bạn đã xóa tài khoản của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbUserName.Checked)
            {
                tieuchi = "User_Name_Customer";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    accCtrl.HienThiTK(dgvDSTaiKhoan, txtTimKiem.Text, tieuchi);
                }
            }
            else if (rdbId_Customer.Checked)
            {
                tieuchi = "Id_Customer";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        accCtrl.HienThiTK(dgvDSTaiKhoan, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            }
            else
            {
                text = "Vui lòng chọn loại tìm kiếm!";
                ThongBao(text);
            }
        }
    }
}
