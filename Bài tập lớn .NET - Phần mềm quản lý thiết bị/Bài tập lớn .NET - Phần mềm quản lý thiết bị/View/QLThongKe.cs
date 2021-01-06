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
    public partial class QLThongKe : Form
    {
        Model.StatisticalMng StatisticalMng = new Model.StatisticalMng();
        Controller.StaisticalCtr staisticalCtr = new Controller.StaisticalCtr();
        public static string totalUsed;
        public static string totalLiqui;

        public QLThongKe()
        {
            InitializeComponent();
            loadThongKe.Start();
        }

        private void loadThongKe_Tick(object sender, EventArgs e)
        {
            //load tong thiet bi dang su dung
            DataTable dataTable1 = StatisticalMng.HTTongTBDung();
            lblTongTBSuDung.Text = "0" + dataTable1.Rows[0]["Total_Device"].ToString();
            //load tong so thiet bi thanh ly
            DataTable dataTable2 = StatisticalMng.HTTongThanhLy();
            lblTongTBThanhLy.Text = "0" + dataTable2.Rows[0]["Total_Liqui"].ToString();

        }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemThanhLy_Click(object sender, EventArgs e)
        {
            if (CheckDateTimeQuery())
            {
                staisticalCtr.ThongKeTheoTime(dgvThongKe, dtpStart.Value, dtpEnd.Value);
            }
            else
            {
                MessageBox.Show("Chọn thời gian kết thúc lớn hơn thời gian bắt đầu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckDateTimeQuery()
        {

            TimeSpan value = dtpEnd.Value.Subtract(dtpStart.Value);

            if (value.TotalSeconds >= 0)
            {
                return true;
            }
            else return false;
        }

        private void dgvThongKe_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Xem thôi chứ đừng nghịch bạn ơi :v ", "Sad :((", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            if(txtName_Customer.Text == "")
            {
                MessageBox.Show("Nhập vào tên người dùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                staisticalCtr.ThongKeTheoTen(dgvThongKe, txtName_Customer.Text.Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BieuDoTBThanhLy bieuDoTBThanhLy = new BieuDoTBThanhLy();
            bieuDoTBThanhLy.Show();
        }

        private void QLThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < dgvThongKe.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgvThongKe.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvThongKe.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvThongKe.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvThongKe.Rows[i].Cells[j].Value.ToString();
                }
            }
            try
            {
                workbook.SaveAs("C:\\Users\\Administrator\\Desktop\\ExportStatistical.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageBox.Show("Xuất file excel thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ce)
            {
                MessageBox.Show("Đã tồn tại file cho trước!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            app.Quit();
        }
    }
}
