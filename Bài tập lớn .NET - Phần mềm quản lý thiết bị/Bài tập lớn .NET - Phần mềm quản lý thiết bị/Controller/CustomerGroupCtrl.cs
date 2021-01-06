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
    class CustomerGroupCtrl
    {
        Model.CustomerGroupManage customerGroupMng = new Model.CustomerGroupManage();
        HelperData.DataConfig helperData = new HelperData.DataConfig();

        public int Xoa(string id)
        {
            return customerGroupMng.Xoa(id);
        }

        public void HienThi(DataGridView dgv, string id_group)
        {
            dgv.DataSource = customerGroupMng.GetDataCustomer(id_group).Tables[0];
        }

        public int Update(Object.ObjCustomerGroup customerGroup)
        {
            if (!checkCustomerGroup(customerGroup.Name_Group))
            {
                return -1;
            }
            else
            {
                return customerGroupMng.Update(customerGroup);
            }
        }

        public bool checkCustomerGroup(string nameGroup)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer_Group WHERE Name_Group = @name";
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = nameGroup;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
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

        public int Them(Object.ObjCustomerGroup customerGroup)
        {
            if (!KTTenNhom(customerGroup.Name_Group))
                return 2;
            return customerGroupMng.Save(customerGroup);
        }

        public bool KTTenNhom(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM Customer_Group WHERE Name_Group = @name";
                cmd.Parameters.Add("name", SqlDbType.NVarChar).Value = name;
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
                    return false;
                else
                    return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Tên Nhóm: " + e.Message);
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
                if (helperData.LayDuLieu(cmd).Tables[0].Rows.Count > 0)
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

        public void HienThiNhomNguoiDung(DataGridView dgv, string tukhoa, string tieuchi)
        {
            dgv.DataSource = customerGroupMng.getListCustomerGroup(tukhoa, tieuchi).Tables[0];
        }
    }
}
