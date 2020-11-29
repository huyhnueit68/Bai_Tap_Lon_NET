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
    public partial class AddThanhLy : Form
    {
        public static string text = "";
        Controller.LiquiCtrl liquiCtrl = new Controller.LiquiCtrl();

        public AddThanhLy()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnNgaySinh_Click(object sender, EventArgs e)
        {
            mntNgayThanhLy.Visible = true;
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
            txtDate_Liqui.Clear();
            txtId_Liqui.Clear();
            txtName_Liqui.Clear();
            txtQty_Device.Clear();
            cbbThietBi.Text = "";
        }

        private void btnThemThanhLy_Click(object sender, EventArgs e)
        {
            Object.ObjLiqui objLiqui = new Object.ObjLiqui();
            if (checkNullItem())
            {
                GanDuLieu(objLiqui);
                {
                    switch (liquiCtrl.Them(objLiqui))
                    {
                        case 0:
                            text = "Vui lòng chọn mã thanh lý khác!";
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
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamMoi()
        {
            txtDate_Liqui.Clear();
            txtId_Liqui.Clear();
            txtName_Liqui.Clear();
            txtQty_Device.Clear();
            cbbThietBi.Text = "";
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjLiqui objLiqui)
        {
            objLiqui.Id_Liqui = txtId_Liqui.Text.Trim();
            objLiqui.Name_Liqui = txtName_Liqui.Text.Trim();
            objLiqui.Qty_Device = txtQty_Device.Text.Trim();
            objLiqui.Date_Liqui = txtQty_Device.Text.Trim();

            string value = cbbThietBi.SelectedValue.ToString();
            objLiqui.Id_Device = value;
        }


        private bool checkNullItem()
        {
            if (txtId_Liqui.Text == "" || txtName_Liqui.Text == "" || txtQty_Device.Text == "" || cbbThietBi.Text == "" || txtDate_Liqui.Text == "")
            {
                return false;
            }
            else return true;
        }

        private void AddThanhLy_Load(object sender, EventArgs e)
        {
            liquiCtrl.HienThiCbbThietBi(cbbThietBi);
            txtDate_Liqui.Enabled = false;
        }

        private void mntNgayThanhLy_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate_Liqui.Text = mntNgayThanhLy.SelectionStart.ToShortDateString();
            mntNgayThanhLy.Visible = false;
        }
    }
}
