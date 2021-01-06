using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.Controller
{
    class TypeDeviceCtrl
    {
        HelperData.DataConfig helperData = new HelperData.DataConfig();
        Model.TypeDeviceMng TypeDeviceMng = new Model.TypeDeviceMng();

        public int Update(Object.ObjTypeDevice typeDevice)
        {
            if (!KiemTraTenLoai(typeDevice.Name_Device))
                return -1;
            return TypeDeviceMng.Update(typeDevice);
        }

        public int Them(Object.ObjTypeDevice objTypeDevice)
        {
            if (!KiemTraTenLoai(objTypeDevice.Name_Device))
                return 0;
            return TypeDeviceMng.Save(objTypeDevice);
        }

        public bool KiemTraTenLoai(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Type_Device WHERE Name_Device = @nameDevice";
                cmd.Parameters.Add("nameDevice", SqlDbType.NVarChar).Value = name;

                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public int Xoa(string id)
        {
            return TypeDeviceMng.Xoa(id);
        }

        public void HienThiLoaiTB(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = TypeDeviceMng.getListTypeDevice(tukhoa, tieuchi).Tables[0];
        }
    }
}
