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
    public partial class QLMuonTra : Form
    {
        public static string text;
        Model.RentDeviceManage rentDeviceManage = new Model.RentDeviceManage();
        Controller.RentDeviceCtrl rentDeviceCtrl = new Controller.RentDeviceCtrl();
        public QLMuonTra()
        {
            InitializeComponent();
        }

        private void QLMuonTra_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                
            }
            rentDeviceManage.HienThi(dgvListRentDevice);
            HienThiThongTin();
            txtDate_Pay.Enabled = false;
            txtDate_Rent.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvListRentDevice.CurrentRow != null)
            {
                txtId_Rent.Text = dgvListRentDevice.CurrentRow.Cells["Id_Rent"].Value.ToString();
                txtDate_Rent.Text = dgvListRentDevice.CurrentRow.Cells["Date_Rent"].Value.ToString();
                txtDate_Pay.Text = dgvListRentDevice.CurrentRow.Cells["Date_Pay"].Value.ToString();
                txtId_Device.Text = dgvListRentDevice.CurrentRow.Cells["Id_Device"].Value.ToString();
                txtQty_Device.Text = dgvListRentDevice.CurrentRow.Cells["Qty_Device"].Value.ToString();
                txtId_Customer.Text = dgvListRentDevice.CurrentRow.Cells["Id_Customer"].Value.ToString();
                string tg = dgvListRentDevice.CurrentRow.Cells["Status_Rent"].Value.ToString();
                if(tg == "Đang sử dụng")
                {
                    rdbMuon.Checked = true;
                }
                else if(tg == "Không sử dụng")
                {
                    rdbTra.Checked = true;
                }
                else
                {
                    rdbTra.Checked = true;
                }
            }
        }

        private void grp_TimKiem_Enter(object sender, EventArgs e)
        {

        }

        private void grpThongTinTaiKhoan_Enter(object sender, EventArgs e)
        {

        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            MuonThietBi muon = new MuonThietBi();
            muon.Show();
        }

        private void btnNgayMuon_Click(object sender, EventArgs e)
        {
            mntNgayMuon.Visible = true;
        }

        private void btnNgayTra_Click(object sender, EventArgs e)
        {
            mntNgayTra.Visible = true;
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

        private void dgvListRentDevice_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            rentDeviceManage.HienThi(dgvListRentDevice);
            txtId_Rent.Clear();
            txtDate_Rent.Clear();
            txtDate_Pay.Clear();
            txtId_Device.Clear();
            txtQty_Device.Clear();
            txtId_Customer.Clear();
            rdbMuon.Checked = false;
            rdbTra.Checked = false;
        }

        private void SetDataRentDetail(Object.ObjRentDevice objRentDevice)
        {
            objRentDevice.Id_Rent = txtId_Rent.Text;
            objRentDevice.Day_Rent = txtDate_Rent.Text;
            objRentDevice.Day_Pay = txtDate_Pay.Text;
            objRentDevice.Id_Device = txtId_Device.Text;
            objRentDevice.Qty_Device = txtQty_Device.Text;
            objRentDevice.Id_Customer = txtId_Customer.Text;
            if(rdbMuon.Checked == true)
            {
                objRentDevice.Status_Device = "Đang sử dụng";
            }
            else
            {
                objRentDevice.Status_Device = "Không sử dụng";
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
                Object.ObjRentDevice objRentDevice = new Object.ObjRentDevice();
                SetDataRentDetail(objRentDevice);

                string Id_Customer = dgvListRentDevice.CurrentRow.Cells[0].Value.ToString();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (rentDeviceCtrl.Update(objRentDevice) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rentDeviceManage.HienThi(dgvListRentDevice);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Device không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetDataCustomerDetail(Object.ObjRentDevice objRentDevice)
        {
            objRentDevice.Id_Customer = txtId_Customer.Text;
        }

        private bool checkNullTextBox()
        {
            if (txtId_Rent.Text.Trim() == "")
            {
                errId_Rent.SetError(txtId_Rent, "Nhập vào mã mượn");
                return false;
            }
            if (txtDate_Rent.Text.Trim() == "")
            {
                errDay_Rent.SetError(txtDate_Rent, "Nhập vào ngày mượn");
                return false;
            }
            if (txtDate_Pay.Text.Trim() == "")
            {
                errDay_Pay.SetError(txtDate_Pay, "Nhập vào ngày trả");
                return false;
            }
            if (txtId_Device.Text.Trim() == "")
            {
                errId_Device.SetError(txtId_Device, "Nhập vào mã thiết bị");
                return false;
            }
            if (txtId_Customer.Text.Trim() == "")
            {
                errId_Customer.SetError(txtId_Customer, "Nhập vào mã khách hàng");
                return false;
            }
            if(rdbMuon.Checked == false && rdbTra.Checked == false)
            {
                errStatus_Rent.SetError(rdbMuon, "Xin mời chọn trạng thái");
                return false;
            }
            else
            {
                errId_Rent.SetError(txtId_Rent, "");
                errDay_Rent.SetError(txtDate_Rent, "");
                errDay_Pay.SetError(txtDate_Pay, "");
                errId_Device.SetError(txtId_Device, "");
                errId_Customer.SetError(txtId_Customer, "");
                errStatus_Rent.SetError(rdbMuon, "");
                return true;
            }
        }

        private void btnTraTB_Click(object sender, EventArgs e)
        {
            View.TraThietBi traThietBi = new TraThietBi();
            traThietBi.Show();
        }

        private void txtQty_Device_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbId_Rent.Checked)
            {
                tieuchi = "Id_Rent";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        rentDeviceCtrl.HienThiMuonTra(dgvListRentDevice, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            }
            else if (rdbId_Device.Checked)
            {
                tieuchi = "Id_Device";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        rentDeviceCtrl.HienThiMuonTra(dgvListRentDevice, txtTimKiem.Text, tieuchi);
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
