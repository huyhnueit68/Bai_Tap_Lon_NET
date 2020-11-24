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
    public partial class QuanLyNguoiDung : Form
    {
        Model.CustomerManage CustomerManage = new Model.CustomerManage();
        Controller.CustomerDetailCtrl cutomerDetailCtrl = new Controller.CustomerDetailCtrl();
        private object accCtrl;

        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_QLTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void txtId_Customer_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaTK_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            if(Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            CustomerManage.HienThi(dgvDSTaiKhoan);
            HienThiThongTin();
            txtId_Customer.Enabled = false;
            txtBirthday_Customer.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSTaiKhoan.CurrentRow != null)
            {
                txtId_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Id_Customer"].Value.ToString();
                txtName_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Name_Customer"].Value.ToString();
                txtAddress_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Address_Customer"].Value.ToString();
                txtGender_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Grender_Customer"].Value.ToString();
                txtBirthday_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Birthday_Customer"].Value.ToString();
                txtIdentity_Customer.Text = dgvDSTaiKhoan.CurrentRow.Cells["Identity_Card"].Value.ToString();
                txtId_Group.Text = dgvDSTaiKhoan.CurrentRow.Cells["Id_Group"].Value.ToString();
            }
        }

        private void dgvDSTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            txtGender_Customer.Clear();
            txtBirthday_Customer.Clear();
            txtIdentity_Customer.Clear();
            txtId_Group.Clear();
        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mntNgaySinh.Visible = true;
        }

        private void mntNgaySinh_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

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

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (cutomerDetailCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cutomerDetailCtrl.HienThi(dgvDSTaiKhoan, id_customer);
                        HienThiThongTin();
                        if (!MainControl.onLoadCheckAccLogin())
                        {
                            MessageBox.Show("Đăng xuất do bạn đã xóa tài khoản của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin người dùng này khi có mã tài khoản, các khoản thuê mượn máy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool checkNullTextBox()
        {
            if (txtId_Customer.Text.Trim() == "")
            {
                errId_Customer.SetError(txtId_Customer, "Nhập vào mã người dùng");
                return false;
            }
            if (txtName_Customer.Text.Trim() == "")
            {
                errName.SetError(txtName_Customer, "Nhập vào tên người dùng");
                return false;
            }
            if (txtAddress_Customer.Text.Trim() == "")
            {
                errAddress_Customer.SetError(txtAddress_Customer, "Nhập vào địa chỉ người dùng");
                return false;
            }
            if (txtGender_Customer.Text.Trim() == "")
            {
                errorGrender.SetError(txtGender_Customer, "Nhập vào giới tính người dùng");
                return false;
            }
            if (txtBirthday_Customer.Text.Trim() == "")
            {
                errorBirthday_Customer.SetError(txtBirthday_Customer, "Nhập vào ngày sinh người dùng");
                return false;
            }
            if (txtIdentity_Customer.Text.Trim() == "")
            {
                errorIdentity_Card.SetError(txtIdentity_Customer, "Nhập vào chứng mình thư người dùng");
                return false;
            }
            if (txtIdentity_Customer.Text.Trim() == "")
            {
                errorId_Group.SetError(txtIdentity_Customer, "Nhập vào mã nhóm người dùng");
                return false;
            }
            else
            {
                errId_Customer.SetError(txtId_Customer, "");
                errName.SetError(txtName_Customer, "");
                errAddress_Customer.SetError(txtAddress_Customer, "");
                errorGrender.SetError(txtGender_Customer, "");
                errorBirthday_Customer.SetError(txtBirthday_Customer, "");
                errorIdentity_Card.SetError(txtIdentity_Customer, "");
                errorId_Group.SetError(txtId_Group, "");
                return true;
            }

        }

    }
}
