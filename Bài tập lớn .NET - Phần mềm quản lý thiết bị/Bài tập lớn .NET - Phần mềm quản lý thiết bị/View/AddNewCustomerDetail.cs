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
    public partial class AddNewCustomerDetail : Form
    {
        public static string text = "";
        Controller.CustomerDetailCtrl customerDetailCtrl = new Controller.CustomerDetailCtrl();
        public AddNewCustomerDetail()
        {
            InitializeComponent();
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            Object.ObjCustomerDetail customerDetail = new Object.ObjCustomerDetail();
            if (checkNullItem())
            {
                GanDuLieu(customerDetail);
                {
                    switch (customerDetailCtrl.Them(customerDetail))
                    {
                        case 0:
                            text = "Vui lòng chọn mã người dùng khác!";
                            ThongBao(text);
                            break;
                        case 1:
                            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LamMoi();
                            break;
                        case 2:
                            text = "Vui lòng chọn mã nhóm khác!";
                            ThongBao(text);
                            break;

                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool checkNullItem()
        {
            if (txtAddress_Customer.Text == "" || txtBirthday_Customer.Text == "" || cbbGrender.Text == "" || txtIdentity_Card.Text == "" || txtId_Customer.Text == "" || txtId_Group.Text == "" || txtName_Customer.Text == "")
            {
                return false;
            }
            else return true;
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
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            cbbGrender.Text = "";
            txtBirthday_Customer.Clear();
            txtIdentity_Card.Clear();
            txtId_Group.Clear();
        }

        private void mntNgaySinh_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtBirthday_Customer.Text = mntNgaySinh.SelectionStart.ToShortDateString();
            mntNgaySinh.Visible = false;
        }

        private void btnNgaySinh_Click(object sender, EventArgs e)
        {
            mntNgaySinh.Visible = true;
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjCustomerDetail customerDetail)
        {
            customerDetail.Id_Customer = txtId_Customer.Text.Trim();
            customerDetail.Name_Customer = txtName_Customer.Text.Trim();
            customerDetail.Address_Customer = txtAddress_Customer.Text.Trim();
            customerDetail.Grender_Customer = cbbGrender.Text.Trim();
            customerDetail.Birthday_Customer = txtBirthday_Customer.Text.Trim();
            customerDetail.Identity_Card = txtIdentity_Card.Text.Trim();
            customerDetail.Id_Group = txtId_Group.Text.Trim();
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtId_Customer.Clear();
            txtName_Customer.Clear();
            txtAddress_Customer.Clear();
            cbbGrender.Text = "";
            txtBirthday_Customer.Clear();
            txtIdentity_Card.Clear();
            txtId_Group.Clear();
        }

        private void txtId_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtIdentity_Card_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtId_Group_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbGrender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            return;
        }

        private void AddNewCustomerDetail_Load(object sender, EventArgs e)
        {
            txtBirthday_Customer.Enabled = false;
        }
    }
}
