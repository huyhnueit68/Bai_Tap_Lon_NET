using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class RentDeviceCtrl
    {
        Model.RentDeviceManage rentDeviceMng = new Model.RentDeviceManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Update(Object.ObjRentDevice rentDevice)
        {
            return rentDeviceMng.Update(rentDevice);
        }

        public int UpdatePay(Object.ObjRentDevice rentDevice)
        {
            return rentDeviceMng.UpdatePay(rentDevice);
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbbThietBi(ComboBox cbo)
        {
            cbo.DataSource = rentDeviceMng.LayDSThietBi().Tables[0];
            cbo.DisplayMember = "Name_Device";
            cbo.ValueMember = "Id_Device";
        }

        public int Them(Object.ObjRentDevice rentDevice)
        {
            if (!KTMaThietBi(Convert.ToInt32(rentDevice.Id_Device)))
                return 1;
            if(Login.resultLogin == 1)
            {
                if (!KTMaNguoiDung(Convert.ToInt32(rentDevice.Id_Customer)))
                    return 0;
            }
            return rentDeviceMng.Save(rentDevice);
        }

        public bool KTMaThietBi(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Device WHERE Id_Device = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã thiết bị: " + e.Message);
                return false;
            }

        }

        public bool KTMaNguoiDung(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer_Detail WHERE Id_Customer = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã người dùng: " + e.Message);
                return false;
            }
        }

        public void HienThiMuonTra(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = rentDeviceMng.getListRent(tukhoa, tieuchi).Tables[0];
        }
    }
}
