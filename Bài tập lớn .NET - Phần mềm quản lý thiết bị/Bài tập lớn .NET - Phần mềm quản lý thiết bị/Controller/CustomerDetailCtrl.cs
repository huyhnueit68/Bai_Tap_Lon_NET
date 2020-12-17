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
    class CustomerDetailCtrl
    {
        Model.CustomerManage customerDetailMng = new Model.CustomerManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return customerDetailMng.Xoa(id);
        }

        public void HienThi(DataGridView dgv, string id_customer)
        {
            dgv.DataSource = customerDetailMng.GetDataCustomer(id_customer).Tables[0];
        }

        public int Update(Object.ObjCustomerDetail customerDetail)
        {
            return customerDetailMng.Update(customerDetail);
        }

        public int Them(Object.ObjCustomerDetail customerDetail)
        {
            if (!KTMaNguoiDung(Convert.ToInt32(customerDetail.Id_Customer)))
                return 0;
            if (!KTMaNhom(Convert.ToInt32(customerDetail.Id_Group)))
                return 2;
            return customerDetailMng.Save(customerDetail);
        }

        public bool KTMaNguoiDung(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer_Detail WHERE Id_Customer = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã tài khoản: " + e.Message);
                return false;
            }

        }

        public bool KTMaNhom(int id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer_Group WHERE Id_Group = @id";
                cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count <= 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Mã nhóm: " + e.Message);
                return false;
            }

        }

        public void HienThiNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = customerDetailMng.getListCustomerDetail(tukhoa, tieuchi).Tables[0];
        }
    }
}
