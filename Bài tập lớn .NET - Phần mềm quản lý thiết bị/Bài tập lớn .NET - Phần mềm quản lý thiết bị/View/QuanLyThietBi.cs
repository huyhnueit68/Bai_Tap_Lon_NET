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
    public partial class QuanLyThietBi : Form
    {
        public static string text = "";
        Model.DeviceManage deviceMng = new Model.DeviceManage();
        Controller.DeviceCtrl deviceCtrl = new Controller.DeviceCtrl();
        public QuanLyThietBi()
        {
            InitializeComponent();
        }

        private void QuanLyThietBi_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            deviceMng.HienThi(dgvDSThietBi);
            HienThiThongTin();
            txtId_Device.Enabled = false;
            txtId_Type.Enabled = false;
        }

        //Hàm xử lý load dữ liệu từ dgv lên các text.
        private void HienThiThongTin()
        {
            if (dgvDSThietBi.CurrentRow != null)
            {
                txtId_Device.Text = dgvDSThietBi.CurrentRow.Cells["Id_Device"].Value.ToString();
                txtName_Device.Text = dgvDSThietBi.CurrentRow.Cells["Name_Device"].Value.ToString();
                txtQty_Device.Text = dgvDSThietBi.CurrentRow.Cells["Qty_Device"].Value.ToString();
                txtPrice.Text = dgvDSThietBi.CurrentRow.Cells["Price"].Value.ToString();
                txtFunction_Device.Text = dgvDSThietBi.CurrentRow.Cells["Function_Device"].Value.ToString();
                txtRoom.Text = dgvDSThietBi.CurrentRow.Cells["Room"].Value.ToString();
                txtId_Type.Text = dgvDSThietBi.CurrentRow.Cells["Id_Type"].Value.ToString();
                txtStatus.Text = dgvDSThietBi.CurrentRow.Cells["Status_Device"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            deviceMng.HienThi(dgvDSThietBi);
            txtId_Device.Clear();
            txtName_Device.Clear();
            txtQty_Device.Clear();
            txtPrice.Clear();
            txtFunction_Device.Clear();
            txtRoom.Clear();
            txtId_Type.Clear();
            txtStatus.Clear();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjDevice objDevice = new Object.ObjDevice();
                SetDataDevice(objDevice);

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    if (deviceCtrl.Update(objDevice) > 0)
                    {
                        MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deviceMng.HienThi(dgvDSThietBi);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Id Customer hoặc Id Group không tồn tại, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            View.AddNewDevice addNewDevice = new View.AddNewDevice();
            addNewDevice.Show();
        }

        private void dgvDSThietBi_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private bool checkNullTextBox()
        {
            if (txtId_Device.Text.Trim() == "")
            {
                errId_Device.SetError(txtId_Device, "Nhập vào mã thiết bị");
                return false;
            }
            if (txtName_Device.Text.Trim() == "")
            {
                errName_Device.SetError(txtName_Device, "Nhập vào tên thiết bị");
                return false;
            }
            if (txtQty_Device.Text.Trim() == "")
            {
                errQty_Device.SetError(txtQty_Device, "Nhập vào số lượng thiết bị");
                return false;
            }
            if (txtPrice.Text.Trim() == "")
            {
                errPrice.SetError(txtPrice, "Nhập vào giá thiết bị");
                return false;
            }
            if (txtFunction_Device.Text.Trim() == "")
            {
                errFunction_Group.SetError(txtFunction_Device, "Nhập vào chức năng");
                return false;
            }
            if (txtRoom.Text.Trim() == "")
            {
                errRoom.SetError(txtRoom, "Nhập vào phòng cho thiết bị");
                return false;
            }
            if (txtId_Type.Text.Trim() == "")
            {
                errId_Type.SetError(txtId_Type, "Nhập vào mã nhóm thiết bị");
                return false;
            }
            if (txtStatus.Text.Trim() == "")
            {
                errStatus_Device.SetError(txtStatus, "Nhập vào trạng thái thiết bị");
                return false;
            }
            else
            {
                errId_Device.SetError(txtId_Device, "");
                errName_Device.SetError(txtName_Device, "");
                errQty_Device.SetError(txtQty_Device, "");
                errPrice.SetError(txtPrice, "");
                errFunction_Group.SetError(txtFunction_Device, "");
                errRoom.SetError(txtRoom, "");
                errId_Type.SetError(txtId_Type, "");
                errStatus_Device.SetError(txtStatus, "");
                return true;
            }
        }

        private void SetDataDevice(Object.ObjDevice objDevice)
        {
            objDevice.Id_Device = txtId_Device.Text;
            objDevice.Name_Device = txtName_Device.Text;
            objDevice.Qty_Device = txtQty_Device.Text;
            objDevice.Price = txtPrice.Text;
            objDevice.Function_Device = txtFunction_Device.Text;
            objDevice.Room = txtRoom.Text;
            objDevice.Id_Type = txtId_Type.Text;
            objDevice.Status_Device = txtStatus.Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvDSThietBi.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (deviceCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        deviceCtrl.HienThi(dgvDSThietBi, id_customer);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông thiết bị này khi đang có người mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (cbbLoaiTimKiem.Text.Trim() == "Tên Thiết Bị")
            {
                tieuchi = "Name_Device";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
                }
            }
            else if (cbbLoaiTimKiem.Text.Trim() == "Mã Loại Thiết Bị")
            {
                tieuchi = "Id_Type";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
                    }
                }
                else
                {
                    text = "Vui lòng nhập vào một số nếu tìm kiếm theo id!";
                    ThongBao(text);
                }
            }
            else if (cbbLoaiTimKiem.Text.Trim() == "Mã Thiết Bị")
            {
                tieuchi = "Id_Device";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        deviceCtrl.HienThiNguoiDung(dgvDSThietBi, txtTimKiem.Text, tieuchi);
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
