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
    public partial class QLThanhLyTB : Form
    {
        public static string text;
        Model.LiquiManage liquiMng = new Model.LiquiManage();
        Controller.LiquiCtrl liquiCtrl = new Controller.LiquiCtrl();

        public QLThanhLyTB()
        {
            InitializeComponent();
        }

        private void QLThanhLyTB_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThanhLyTB.Enabled = false;
                btnTimKiem.Enabled = false;
            }
            liquiMng.HienThi(dgvListLiqui);
            HienThiThongTin();
        }

        public int Xoa(string id)
        {
            return liquiMng.Xoa(id);
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvListLiqui.CurrentRow != null)
            {
                txtId_Liqui.Text = dgvListLiqui.CurrentRow.Cells["Id_Liqui"].Value.ToString();
                txtName_Liqui.Text = dgvListLiqui.CurrentRow.Cells["Name_Liqui"].Value.ToString();
                txtId_Device.Text = dgvListLiqui.CurrentRow.Cells["Id_Device"].Value.ToString();
                txtQty_Device.Text = dgvListLiqui.CurrentRow.Cells["Qty_Device"].Value.ToString();
                txtDate_Liqui.Text = dgvListLiqui.CurrentRow.Cells["Date_Liqui"].Value.ToString();
            }
        }

        private void btnDate_Liqui_Click(object sender, EventArgs e)
        {
            mntNgayTL.Visible = true;
        }

        private void mntNgayTL_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate_Liqui.Text = mntNgayTL.SelectionStart.ToShortDateString();
            mntNgayTL.Visible = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            liquiMng.HienThi(dgvListLiqui);
            txtDate_Liqui.Clear();
            txtId_Liqui.Clear();
            txtName_Liqui.Clear();
            txtQty_Device.Clear();
            txtTimKiem.Clear();
            txtId_Device.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvListLiqui.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (liquiCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        liquiCtrl.HienThi(dgvListLiqui, id_customer);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông thiết bị này khi đang có người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool checkNullTextBox()
        {
            if (txtId_Liqui.Text.Trim() == "")
            {
                errId_Liqui.SetError(txtId_Liqui, "Nhập vào mã thanh lý");
                return false;
            }
            if (txtName_Liqui.Text.Trim() == "")
            {
                errName_Liqui.SetError(txtName_Liqui, "Nhập vào tên thanh lý");
                return false;
            }
            if (txtQty_Device.Text.Trim() == "")
            {
                errQty_Device.SetError(txtQty_Device, "Nhập vào số lượng thiết bị");
                return false;
            }
            if (txtId_Device.Text.Trim() == "")
            {
                errId_Device.SetError(txtId_Device, "Nhập thiết bị");
                return false;
            }
            if (txtDate_Liqui.Text.Trim() == "")
            {
                errDate_Liqui.SetError(txtDate_Liqui, "Nhập vào ngày thanh lý");
                return false;
            }
            else
            {
                errId_Liqui.SetError(txtId_Liqui, "");
                errId_Device.SetError(txtId_Device, "");
                errName_Liqui.SetError(txtName_Liqui, "");
                errDate_Liqui.SetError(txtDate_Liqui, "");
                errQty_Device.SetError(txtQty_Device, "");
               
                return true;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjLiqui objLiqui = new Object.ObjLiqui();
                SetDataLiqui(objLiqui);

                string Id_Customer = dgvListLiqui.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (liquiCtrl.Update(objLiqui) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        liquiMng.HienThi(dgvListLiqui);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetDataLiqui(Object.ObjLiqui objLiqui)
        {
            objLiqui.Id_Liqui = txtId_Liqui.Text;
            objLiqui.Name_Liqui = txtId_Liqui.Text;
            objLiqui.Id_Device = txtId_Liqui.Text;
            objLiqui.Qty_Device = txtQty_Device.Text;
            objLiqui.Date_Liqui = txtDate_Liqui.Text;
            
        }

        private void dgvListLiqui_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbId_Liqui.Checked)
            {
                tieuchi = "Id_Liqui";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        liquiCtrl.HienThiThanhLy(dgvListLiqui, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            }
            else if (rdbName_Liqui.Checked)
            {
                tieuchi = "Name_Device";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    liquiCtrl.HienThiThanhLy(dgvListLiqui, txtTimKiem.Text, tieuchi);
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

        private void btnThanhLyTB_Click(object sender, EventArgs e)
        {
            View.AddThanhLy thanhLy = new AddThanhLy();
            thanhLy.Show();
        }
    }
}
