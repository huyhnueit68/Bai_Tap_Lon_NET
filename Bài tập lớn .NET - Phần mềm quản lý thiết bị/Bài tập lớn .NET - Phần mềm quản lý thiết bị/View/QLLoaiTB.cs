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
    public partial class QLLoaiTB : Form
    {
        public static string text = "";
        Model.TypeDeviceMng typeDeviceMng = new Model.TypeDeviceMng();
        Controller.TypeDeviceCtrl typeDeviceCtrl = new Controller.TypeDeviceCtrl();

        public QLLoaiTB()
        {
            InitializeComponent();
        }

        private void QLLoaiTB_Load(object sender, EventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                btnXoa.Enabled = false;
                btnThemTK.Enabled = false;
            }
            typeDeviceMng.HienThi(dgvDSLoaiTB);
            HienThiThongTin();
            txtId_Type.Enabled = false;
        }

        private void HienThiThongTin()
        {
            if (dgvDSLoaiTB.CurrentRow != null)
            {
                txtId_Type.Text = dgvDSLoaiTB.CurrentRow.Cells["Id_Type"].Value.ToString();
                txtName_Type.Text = dgvDSLoaiTB.CurrentRow.Cells["Name_Device"].Value.ToString();
            }
        }

        private void dgvDSLoaiTB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSLoaiTB_MouseClick(object sender, MouseEventArgs e)
        {
            HienThiThongTin();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            typeDeviceMng.HienThi(dgvDSLoaiTB);
            HienThiThongTin();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (checkNullTextBox() == false)
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                Object.ObjTypeDevice objTypeDevice = new Object.ObjTypeDevice();
                SetDataTypeDeivce(objTypeDevice);

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn đổi dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dlg == DialogResult.Yes)
                {
                    switch (typeDeviceCtrl.Update(objTypeDevice))
                    {
                        case -1:
                            {
                                MessageBox.Show("Id Type không tồn tại hoặc đã tồn tại tên loại thiết bị, vui lòng thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                typeDeviceMng.HienThi(dgvDSLoaiTB);
                                HienThiThongTin();
                                break;
                            }
                    }
                }
            }
        }

        private void SetDataTypeDeivce(Object.ObjTypeDevice objTypeDevice)
        {
            objTypeDevice.Id_Type = txtId_Type.Text;
            objTypeDevice.Name_Device = txtName_Type.Text;
        }

        private bool checkNullTextBox()
        {
            if (txtId_Type.Text.Trim() == "")
            {
                errIdType.SetError(txtId_Type, "Nhập vào mã loại");
                return false;
            }
            if (txtName_Type.Text.Trim() == "")
            {
                errNameType.SetError(txtName_Type, "Nhập vào tên loại");
                return false;
            }
            else
            {
                errIdType.SetError(txtId_Type, "");
                errNameType.SetError(txtName_Type, "");
                return true;
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            AddNewTypeDevice typeDevice = new AddNewTypeDevice();
            typeDevice.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!checkNullTextBox())
            {
                MessageBox.Show("Xin mời nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string id_customer = dgvDSLoaiTB.CurrentRow.Cells[0].Value.ToString();

                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dlg == DialogResult.Yes)
                {
                    //delete in table customer detail
                    if (typeDeviceCtrl.Xoa(id_customer) != -9999)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        typeDeviceMng.HienThi(dgvDSLoaiTB);
                        HienThiThongTin();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa loại thiết bị này khi đang có thiết bị thuộc loại này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tieuchi = "";
            if (rdbName_Type.Checked)
            {
                tieuchi = "Name_Device";
                if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                {
                    typeDeviceCtrl.HienThiLoaiTB(dgvDSLoaiTB, txtTimKiem.Text, tieuchi);
                }
            }
            else if (rdbId_Type.Checked)
            {
                tieuchi = "Id_Type";
                int value;
                if (int.TryParse(txtTimKiem.Text.Trim(), out value))
                {
                    if (txtTimKiem.Text.Length != 0 && tieuchi != "")
                    {
                        typeDeviceCtrl.HienThiLoaiTB(dgvDSLoaiTB, txtTimKiem.Text, tieuchi);
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

        private void ThongBao(string text)
        {
            MessageBox.Show(text, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
