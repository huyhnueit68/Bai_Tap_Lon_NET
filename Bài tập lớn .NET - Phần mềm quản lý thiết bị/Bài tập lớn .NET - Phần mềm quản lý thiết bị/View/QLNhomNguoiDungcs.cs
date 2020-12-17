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
    public partial class QLNhomNguoiDungcs : Form
    {
        public static string text = "";
        Model.CustomerGroupManage CustomerGroupManage = new Model.CustomerGroupManage();
        Controller.CustomerGroupCtrl cutomerGroupCtrl = new Controller.CustomerGroupCtrl();

        public QLNhomNguoiDungcs()
        {
            InitializeComponent();
        }

        private void QLNhomNguoiDungcs_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            CustomerGroupManage.HienThi(dgvListCustomerGroup);
            HienThiThongTin();
            txtId_Group.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvListCustomerGroup.CurrentRow != null)
            {
                txtId_Group.Text = dgvListCustomerGroup.CurrentRow.Cells["Id_Group"].Value.ToString();
                txtName_Group.Text = dgvListCustomerGroup.CurrentRow.Cells["Name_Group"].Value.ToString();
            }
        }

        private void dgvListCustomerGroup_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            CustomerGroupManage.HienThi(dgvListCustomerGroup);
            txtId_Group.Clear();
            txtName_Group.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjCustomerGroup objCustomerGroup = new Object.ObjCustomerGroup();
                SetDataCustomerGroup(objCustomerGroup);

                string Id_Customer = dgvListCustomerGroup.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (cutomerGroupCtrl.Update(objCustomerGroup) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CustomerGroupManage.HienThi(dgvListCustomerGroup);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool checkNullTextBox()
        {
            if (txtId_Group.Text.Trim() == "")
            {
                errorId_Group.SetError(txtId_Group, "Nhập vào mã nhóm");
                return false;
            }
            if (txtName_Group.Text.Trim() == "")
            {
                errorName_Group.SetError(txtName_Group, "Nhập vào tên nhóm");
                return false;
            }
            else
            {
                errorId_Group.SetError(txtId_Group, "");
                errorName_Group.SetError(txtName_Group, "");
                return true;
            }

        }

        private void SetDataCustomerGroup(Object.ObjCustomerGroup customerGroup)
        {
            customerGroup.Id_Group = txtId_Group.Text;
            customerGroup.Name_Group = txtName_Group.Text;
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewCustomerGroup customerGroup = new View.AddNewCustomerGroup();
            customerGroup.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvListCustomerGroup.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (cutomerGroupCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cutomerGroupCtrl.HienThi(dgvListCustomerGroup, id_customer);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin nhóm này khi có người dùng thuộc nhóm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbName_Group.Checked)
            {
                tieuchi = "Name_Group";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    cutomerGroupCtrl.HienThiNhomNguoiDung(dgvListCustomerGroup, txtTimKiem.Text, tieuchi);
                }
            }
            else if (rdbId_Group.Checked)
            {
                tieuchi = "Id_Group";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        cutomerGroupCtrl.HienThiNhomNguoiDung(dgvListCustomerGroup, txtTimKiem.Text, tieuchi);
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
    }
}
