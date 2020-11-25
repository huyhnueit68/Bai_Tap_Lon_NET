using Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị
{
    public partial class MainControl : Form
    {

        public MainControl()
        {
            InitializeComponent();
            timer1.Start();
            lblNameUser.Text = Login.nameLogin;
            if(Login.resultLogin == 1)
            {
                btnQLTaiKhoan.Visible = true;
                btnQLNguoiDung.Visible = true;
                btnQLNhomNguoiDung.Visible = true;
                btnQLThietBi.Visible = true;
                btnQLMuonTra.Visible = true;
                btnQLThanhLy.Visible = true;
                btnThongKe.Visible = true;
            }
            else
            {
                btnQLTaiKhoan.Visible = true;
                btnQLNguoiDung.Visible = true;
                btnQLNhomNguoiDung.Enabled = false;
                btnQLThietBi.Visible = true;
                btnQLMuonTra.Visible = true;
                btnQLThanhLy.Enabled = false;
                btnThongKe.Enabled = false;
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát chương trình?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(kq == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnQLNhomNguoiDung_MouseClick(object sender, MouseEventArgs e)
        {
            if(Login.resultLogin != 1)
            {
                MessageBox.Show("Chức năng không khả dụng với bạn", "Cảnh báo");
            }
        }

        private void btnQLThanhLy_MouseClick(object sender, MouseEventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                MessageBox.Show("Chức năng không khả dụng với bạn", "Cảnh báo");
            }
        }

        private void btnThongKe_MouseClick(object sender, MouseEventArgs e)
        {
            if (Login.resultLogin != 1)
            {
                MessageBox.Show("Chức năng không khả dụng với bạn", "Cảnh báo");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if(!onLoadCheckAccLogin())
            {
                this.Close();
            }
            DateTime datetime = DateTime.Now;
            this.lbtGio.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThang.Text = datetime.ToString("dd/MM/yyyy");
            this.lbThu.Text = datetime.ToString("dddd");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn đăng xuất?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //set form
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelformularios.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelformularios.Controls.Add(formulario);
                panelformularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["QuanLyTaiKhoan"] == null)
                btnQLTaiKhoan.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyNguoiDung"] == null)
                btnQLNguoiDung.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyNhomNguoiDung"] == null)
                btnQLNhomNguoiDung.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyThietBi"] == null)
                btnQLThanhLy.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyMuonTra"] == null)
                btnQLMuonTra.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyThanhLy"] == null)
                btnQLThanhLy.BackColor = Color.FromArgb(4, 41, 68);
            if (Application.OpenForms["QuanLyThongKe"] == null)
                btnThongKe.BackColor = Color.FromArgb(4, 41, 68);
        }

        //reset color for button
        private void resetColorForButton()
        {
            btnQLTaiKhoan.BackColor = Color.FromArgb(4, 41, 68);
            btnQLNguoiDung.BackColor = Color.FromArgb(4, 41, 68);
            btnQLNhomNguoiDung.BackColor = Color.FromArgb(4, 41, 68);
            btnQLThietBi.BackColor = Color.FromArgb(4, 41, 68);
            btnQLMuonTra.BackColor = Color.FromArgb(4, 41, 68);
            btnQLThanhLy.BackColor = Color.FromArgb(4, 41, 68);
            btnThongKe.BackColor = Color.FromArgb(4, 41, 68);
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            //form quan ly tai khoan
            resetColorForButton();
            AbrirFormulario<QuanLyTaiKhoan>();
            btnQLTaiKhoan.BackColor = Color.FromArgb(0, 154, 205);
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            resetColorForButton();
            AbrirFormulario<Default>();
        }

        private void panelformularios_Paint(object sender, PaintEventArgs e)
        {

        }

        public static bool onLoadCheckAccLogin()
        {
            //query data
            try
            {
                string query = "SELECT * FROM Account WHERE Id_Customer = " + Login.getIdCustomerLogin() + "";
                //action get database
                SqlConnection connect = ConnectDatabase.connect;
                SqlDataAdapter sqldata = new SqlDataAdapter(query, connect);
                DataTable result = new DataTable();
                sqldata.Fill(result);
                // check database
                if (result.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ce)
            {
                MessageBox.Show(ce.Message);
                return false;
            }
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            //form quan ly nguoi dung
            resetColorForButton();
            AbrirFormulario<QuanLyNguoiDung>();
            btnQLNguoiDung.BackColor = Color.FromArgb(0, 154, 205);
        }

        private void btnQLNhomNguoiDung_Click(object sender, EventArgs e)
        {
            //form quan ly nhom nguoi dung
            resetColorForButton();
            AbrirFormulario<QLNhomNguoiDungcs>();
            btnQLNhomNguoiDung.BackColor = Color.FromArgb(0, 154, 205);
        }

        private void btnQLThietBi_Click(object sender, EventArgs e)
        {
            //form quan ly nhom nguoi dung
            resetColorForButton();
            AbrirFormulario<QuanLyThietBi>();
            btnQLThietBi.BackColor = Color.FromArgb(0, 154, 205);
        }
    }
}
