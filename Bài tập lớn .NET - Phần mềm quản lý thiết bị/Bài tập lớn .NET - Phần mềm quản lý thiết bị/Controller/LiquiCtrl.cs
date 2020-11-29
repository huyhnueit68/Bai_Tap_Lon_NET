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
    class LiquiCtrl
    {
        Model.LiquiManage liquiMng = new Model.LiquiManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return liquiMng.Xoa(id);
        }

        //Hàm xử lý hiển thị thiết bị lên combox.
        public void HienThiCbbThietBi(ComboBox cbo)
        {
            cbo.DataSource = liquiMng.LayDSThietBi().Tables[0];
            cbo.DisplayMember = "Name_Device";
            cbo.ValueMember = "Id_Device";
        }

        public void HienThi(DataGridView dgv, string id_liqui)
        {
            dgv.DataSource = liquiMng.GetDataLiqui(id_liqui).Tables[0];
        }

        public int Update(Object.ObjLiqui objLiqui)
        {
            return liquiMng.Update(objLiqui);
        }

        public int Them(Object.ObjLiqui objLiqui)
        {
            if (!KTMaThanhLy(Convert.ToInt32(objLiqui.Id_Liqui)))
                return 0;
            return liquiMng.Save(objLiqui);
        }

        public bool KTMaThanhLy(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Liquidate WHERE Id_Liqui = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã thanh lý: " + e.Message);
                return false;
            }

        }

        public void HienThiThanhLy(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = liquiMng.getListLiqui(tukhoa, tieuchi).Tables[0];
        }
    }
}
