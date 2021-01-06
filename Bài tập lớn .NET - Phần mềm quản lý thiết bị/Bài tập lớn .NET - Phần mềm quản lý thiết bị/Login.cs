using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị
{
    public partial class Login : Form
    {
        public static int resultLogin = -1;
        public static string nameLogin = "Unknown";
        public static string idCustomerLogin = "NULL";
        public static string user = "NULL";
        public static string pass = "NULL";


        //connection database
        SqlConnection connect = ConnectDatabase.connect;

        public Login()
        {
            InitializeComponent();
        }

        private void lbmini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbexit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
                this.Close();
        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            txtUserName.Clear();
        }

        private void txtPassWord_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassWord.Clear();
        }

        private void getMainControl()
        {
            MainControl mainMenu = new MainControl();
            mainMenu.Show();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //query data
            user = MainControl.checkInjectionSQL(txtUserName.Text.Trim());
            pass = MainControl.checkInjectionSQL(txtPassWord.Text.Trim());

            string query = "SELECT Customer_Detail.Id_Group, Customer_Detail.Name_Customer " +
                "FROM Account " +
                "INNER JOIN Customer_Detail " +
                "ON Account.Id_Customer = Customer_Detail.Id_Customer " +
                "WHERE Account.User_Name_Customer = '" + user + "' " +
                "AND Account.PassWord_Customer = '" + pass + "'; ";

            //action get database
            DataTable result = new DataTable();
            try
            {
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                result = new DataTable();
                sqldata.Fill(result);
            }
            catch(Exception ce)
            {
                MessageBox.Show(ce.Message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // check database
            if (rdbAdmin.Checked)
            {
                try
                {
                    if (result.Rows[0]["Id_Group"].ToString() == "1")
                    {
                        nameLogin = result.Rows[0]["Name_Customer"].ToString();
                        resultLogin = 1;
                        getMainControl();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!\n" + ce.Message);
                }

            }
            else
            {
                try
                {
                    if (result.Rows.Count > 0 && result.Rows[0]["Id_Group"].ToString() != "1")
                    {
                        nameLogin = result.Rows[0]["Name_Customer"].ToString();
                        resultLogin = 0;
                        getMainControl();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!\nKiểm tra lại quyền đăng nhập!");
                    }
                }
                catch (Exception ce)
                {
                    MessageBox.Show(ce.Message);
                }
            }
        }

        public static string getIdCustomerLogin()
        {
            //query data
            try
            {
                string query = "SELECT Id_Customer FROM Account WHERE User_Name_Customer = '" + user + "' AND PassWord_Customer = '" + pass + "'";
                //action get database
                SqlConnection connect = ConnectDatabase.connect;
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                DataTable result = new DataTable();
                sqldata.Fill(result);
                // check database
                idCustomerLogin = result.Rows[0]["Id_Customer"].ToString();
                return result.Rows[0]["Id_Customer"].ToString();
            }
            catch
            {
                return "NULL";
            }
            
        }
    }
}
