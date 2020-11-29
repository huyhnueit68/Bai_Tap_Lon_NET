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
    public partial class TraThietBi : Form
    {
        Model.RentDeviceManage rentDeviceManage = new Model.RentDeviceManage();
        Controller.RentDeviceCtrl rentDeviceCtrl = new Controller.RentDeviceCtrl();

        public TraThietBi()
        {
            InitializeComponent();
        }

        private void TraThietBi_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {

            }
            rentDeviceManage.HienThiTra(dgvListRentDevice);
            HienThiThongTin();
            txtDate_Pay.Enabled = false;
            txtDate_Rent.Enabled = false;
            txtId_Device.Enabled = false;
            txtId_Rent.Enabled = false;
            txtId_Customer.Enabled = false;
            txtQty_Device.Enabled = false;
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
                if (tg == "Đang sử dụng")
                {
                    rdbMuon.Checked = true;
                }
                else
                {
                    rdbTra.Checked = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnTraTB_Click(object sender, EventArgs e)
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
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn trả thiết bị này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (rentDeviceCtrl.UpdatePay(objRentDevice) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        rentDeviceManage.HienThiTra(dgvListRentDevice);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Device không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetDataRentDetail(Object.ObjRentDevice objRentDevice)
        {
            objRentDevice.Id_Rent = txtId_Rent.Text;
            objRentDevice.Day_Rent = txtDate_Rent.Text;
            objRentDevice.Day_Pay = txtDate_Pay.Text;
            objRentDevice.Id_Device = txtId_Device.Text;
            objRentDevice.Qty_Device = txtQty_Device.Text;
            objRentDevice.Id_Customer = txtId_Customer.Text;
            if (rdbMuon.Checked == true)
            {
                objRentDevice.Status_Device = "Đang sử dụng";
            }
            else
            {
                objRentDevice.Status_Device = "Không sử dụng";
            }
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
            if (rdbMuon.Checked == false && rdbTra.Checked == false)
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

        private void dgvListRentDevice_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }
    }
}
