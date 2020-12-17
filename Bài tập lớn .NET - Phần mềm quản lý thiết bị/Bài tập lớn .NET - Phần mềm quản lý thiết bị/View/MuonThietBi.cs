using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    public partial class MuonThietBi : Form
    {
        public static string text = "";
        Controller.RentDeviceCtrl rentDeviceCtrl = new Controller.RentDeviceCtrl();
        public MuonThietBi()
        {
            InitializeComponent();
        }

        private void btnNgayMuon_Click(object sender, EventArgs e)
        {
            mntNgayMuon.Visible = true;
        }

        private void btnNgayTra_Click(object sender, EventArgs e)
        {
            mntNgayTra.Visible = true;
        }

        private void MuonThietBi_Load(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;

            if (Login.resultLogin != 1)
            {
                txtId_Customer.Enabled = false;
                txtId_Customer.Text = Login.idCustomerLogin;
            }
            rdbMuon.Checked = true;
            rdbTra.Enabled = false;
            txtDate_Rent.Enabled = false;
            txtDate_Pay.Enabled = false;
            mntNgayMuon.MinDate = new System.DateTime(datetime.Year, datetime.Month, datetime.Day);
            mntNgayTra.MinDate = new System.DateTime(datetime.Year, datetime.Month, datetime.Day);
            rentDeviceCtrl.HienThiCbbThietBi(cbbThietBi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mntNgayMuon_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate_Rent.Text = mntNgayMuon.SelectionStart.ToShortDateString();
            mntNgayMuon.Visible = false;
        }

        private void mntNgayTra_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDate_Pay.Text = mntNgayTra.SelectionStart.ToShortDateString();
            mntNgayTra.Visible = false;
        }

        private void btnTraTB_Click(object sender, EventArgs e)
        {
            Object.ObjRentDevice rentDevice = new Object.ObjRentDevice();
            if (checkNullItem())
            {
                if (CheckDateTimeRent())
                {
                    GanDuLieu(rentDevice);
                    {
                        switch (rentDeviceCtrl.Them(rentDevice))
                        {
                            case 0:
                                text = "Vui lòng chọn mã người dùng khác!";
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
                    MessageBox.Show("Vui lòng chọn ngày trả lớn hơn ngày mượn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkNullItem()
        {
            if (txtDate_Pay.Text == "" || txtDate_Rent.Text == "" || txtId_Customer.Text == "")
                return false;
            else
                return true;
        }

        private bool CheckDateTimeRent()
        {

            TimeSpan value = mntNgayTra.SelectionStart.Subtract(mntNgayMuon.SelectionStart);
            
            if (value.TotalSeconds > 0)
            {
                return true;
            }
            else return false;
        }

        //Hàm xử lý thông báo lỗi.
        private void ThongBao(string text)
        {
            MessageBox.Show(text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LamMoi()
        {
            txtDate_Rent.Clear();
            txtDate_Pay.Clear();
            txtId_Customer.Clear();
            cbbThietBi.Text = "";
        }

        //Hàm xử lý lưu dữ liệu.
        private void GanDuLieu(Object.ObjRentDevice rentDevice)
        {
            rentDevice.Day_Rent = txtDate_Rent.Text.Trim();
            rentDevice.Day_Pay = txtDate_Pay.Text.Trim();

            string value = cbbThietBi.SelectedValue.ToString();
            rentDevice.Id_Device = value;

            rentDevice.Qty_Device = txtQty_Device.Text.Trim();
            rentDevice.Id_Customer = txtId_Customer.Text.Trim();
            rentDevice.Status_Device = "Đang sử dụng";
        }

        private void txtId_Customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQty_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
