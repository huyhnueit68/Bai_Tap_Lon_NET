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
    class DeviceCtrl
    {
        Model.DeviceManage deviceMng = new Model.DeviceManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return deviceMng.Xoa(id);
        }

        public int Update(Object.ObjDevice objDevice)
        {
            return deviceMng.Update(objDevice);
        }

        public void HienThi(DataGridView dgv, string id_group)
        {
            dgv.DataSource = deviceMng.GetDataDevice(id_group).Tables[0];
        }

        public int Them(Object.ObjDevice objDevice)
        {
            if (!KiemTraMaLoai(Convert.ToInt32(objDevice.Id_Type)))
                return 2;
            return deviceMng.Save(objDevice);
        }

        public bool KiemTraMaTB(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Device WHERE Id_Device = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
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

        public bool KiemTraMaLoai(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Type_Device WHERE Id_Type = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã loại thiết bị: " + e.Message);
                return false;
            }

        }

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = deviceMng.getListDevice(tukhoa, tieuchi).Tables[0];
        }
    }
}
