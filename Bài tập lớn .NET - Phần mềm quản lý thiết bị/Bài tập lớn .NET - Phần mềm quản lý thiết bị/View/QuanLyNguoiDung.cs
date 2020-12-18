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
        public static string text = "";
        Model.CustomerManage CustomerManage = new Model.CustomerManage();
        Controller.CustomerDetailCtrl cutomerDetailCtrl = new Controller.CustomerDetailCtrl();

        public QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        private void QuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            if(Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            CustomerManage.HienThi(dgvDSChiTietNguoiDung);
            HienThiThongTin();
            txtId_Customer.Enabled = false;
            txtBirthday_Customer.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSChiTietNguoiDung.CurrentRow != null)
            {
                txtId_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Id_Customer"].Value.ToString();
                txtName_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Name_Customer"].Value.ToString();
                txtAddress_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Address_Customer"].Value.ToString();
                cbbGioiTinh.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Grender_Customer"].Value.ToString();
                txtBirthday_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Birthday_Customer"].Value.ToString();
                txtIdentity_Customer.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Identity_Card"].Value.ToString();
                txtId_Group.Text = dgvDSChiTietNguoiDung.CurrentRow.Cells["Id_Group"].Value.ToString();
            }
        }

        private void dgvDSTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CustomerManage.HienThi(dgvDSChiTietNguoiDung);
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            cbbGioiTinh.Text = "";
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
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjCustomerDetail objCustoDetail = new Object.ObjCustomerDetail();
                SetDataCustomerDetail(objCustoDetail);

                string Id_Customer = dgvDSChiTietNguoiDung.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (cutomerDetailCtrl.Update(objCustoDetail) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustomerManage.HienThi(dgvDSChiTietNguoiDung);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvDSChiTietNguoiDung.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (cutomerDetailCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cutomerDetailCtrl.HienThi(dgvDSChiTietNguoiDung, id_customer);
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
            if (cbbGioiTinh.Text.Trim() == "")
            {
                errorGrender.SetError(cbbGioiTinh, "Nhập vào giới tính người dùng");
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
                errorGrender.SetError(cbbGioiTinh, "");
                errorBirthday_Customer.SetError(txtBirthday_Customer, "");
                errorIdentity_Card.SetError(txtIdentity_Customer, "");
                errorId_Group.SetError(txtId_Group, "");
                return true;
            }
        }

        private void SetDataCustomerDetail(Object.ObjCustomerDetail customerDetail)
        {
            customerDetail.Id_Customer = txtId_Customer.Text;
            customerDetail.Name_Customer = txtName_Customer.Text;
            customerDetail.Address_Customer = txtAddress_Customer.Text;
            customerDetail.Grender_Customer = cbbGioiTinh.Text;
            customerDetail.Birthday_Customer = txtBirthday_Customer.Text;
            customerDetail.Identity_Card = txtIdentity_Customer.Text;
            customerDetail.Id_Group = txtId_Group.Text;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewCustomerDetail addNewCustomerDetail = new AddNewCustomerDetail();
            addNewCustomerDetail.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbName_Customer.Checked)
            {
                tieuchi = "Name_Customer";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    cutomerDetailCtrl.HienThiNguoiDung(dgvDSChiTietNguoiDung, txtTimKiem.Text, tieuchi);
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
                        cutomerDetailCtrl.HienThiNguoiDung(dgvDSChiTietNguoiDung, txtTimKiem.Text, tieuchi);
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
        //Hàm hiển thị thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cbbGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }
    }
}
