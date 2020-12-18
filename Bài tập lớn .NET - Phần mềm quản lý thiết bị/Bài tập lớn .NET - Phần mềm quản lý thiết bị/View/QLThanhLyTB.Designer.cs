namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QLThanhLyTB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtId_Device = new System.Windows.Forms.TextBox();
            this.mntNgayTL = new System.Windows.Forms.MonthCalendar();
            this.btnDate_Liqui = new System.Windows.Forms.Button();
            this.txtDate_Liqui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId_Liqui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThanhLyTB = new System.Windows.Forms.Button();
            this.txtName_Liqui = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errId_Liqui = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbName_Liqui = new System.Windows.Forms.RadioButton();
            this.rdbId_Liqui = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.errName_Liqui = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvListLiqui = new System.Windows.Forms.DataGridView();
            this.errId_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errQty_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDate_Liqui = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id_Liqui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Liqui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_Liqui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Liqui)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Liqui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLiqui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate_Liqui)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.mntNgayTL);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnDate_Liqui);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDate_Liqui);
            this.grpThongTinTaiKhoan.Controls.Add(this.label3);
            this.grpThongTinTaiKhoan.Controls.Add(this.label6);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Liqui);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThanhLyTB);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtName_Liqui);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(22, 91);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(890, 252);
            this.grpThongTinTaiKhoan.TabIndex = 24;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // txtId_Device
            // 
            this.txtId_Device.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Device.Location = new System.Drawing.Point(121, 102);
            this.txtId_Device.MaxLength = 20;
            this.txtId_Device.Name = "txtId_Device";
            this.txtId_Device.Size = new System.Drawing.Size(129, 20);
            this.txtId_Device.TabIndex = 58;
            // 
            // mntNgayTL
            // 
            this.mntNgayTL.Location = new System.Drawing.Point(277, 26);
            this.mntNgayTL.MaxSelectionCount = 1;
            this.mntNgayTL.Name = "mntNgayTL";
            this.mntNgayTL.TabIndex = 57;
            this.mntNgayTL.Visible = false;
            this.mntNgayTL.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayTL_DateSelected);
            // 
            // btnDate_Liqui
            // 
            this.btnDate_Liqui.ForeColor = System.Drawing.Color.Black;
            this.btnDate_Liqui.Location = new System.Drawing.Point(473, 98);
            this.btnDate_Liqui.Name = "btnDate_Liqui";
            this.btnDate_Liqui.Size = new System.Drawing.Size(27, 23);
            this.btnDate_Liqui.TabIndex = 55;
            this.btnDate_Liqui.Text = "...";
            this.btnDate_Liqui.UseVisualStyleBackColor = true;
            this.btnDate_Liqui.Click += new System.EventHandler(this.btnDate_Liqui_Click);
            // 
            // txtDate_Liqui
            // 
            this.txtDate_Liqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate_Liqui.Location = new System.Drawing.Point(375, 100);
            this.txtDate_Liqui.MaxLength = 20;
            this.txtDate_Liqui.Name = "txtDate_Liqui";
            this.txtDate_Liqui.Size = new System.Drawing.Size(91, 20);
            this.txtDate_Liqui.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày Thanh Lý";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 49;
            this.label6.Text = "Thiết Bị";
            // 
            // txtId_Liqui
            // 
            this.txtId_Liqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Liqui.Location = new System.Drawing.Point(121, 47);
            this.txtId_Liqui.MaxLength = 20;
            this.txtId_Liqui.Name = "txtId_Liqui";
            this.txtId_Liqui.Size = new System.Drawing.Size(129, 20);
            this.txtId_Liqui.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Thanh Lý";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(527, 38);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(127, 37);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(527, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 37);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(704, 38);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(128, 37);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThanhLyTB
            // 
            this.btnThanhLyTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThanhLyTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhLyTB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThanhLyTB.Location = new System.Drawing.Point(705, 129);
            this.btnThanhLyTB.Name = "btnThanhLyTB";
            this.btnThanhLyTB.Size = new System.Drawing.Size(127, 37);
            this.btnThanhLyTB.TabIndex = 19;
            this.btnThanhLyTB.Text = "Thanh Lý TB";
            this.btnThanhLyTB.UseVisualStyleBackColor = false;
            this.btnThanhLyTB.Click += new System.EventHandler(this.btnThanhLyTB_Click);
            // 
            // txtName_Liqui
            // 
            this.txtName_Liqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Liqui.Location = new System.Drawing.Point(375, 47);
            this.txtName_Liqui.MaxLength = 20;
            this.txtName_Liqui.Name = "txtName_Liqui";
            this.txtName_Liqui.Size = new System.Drawing.Size(129, 20);
            this.txtName_Liqui.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(277, 52);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(81, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Thanh Lý";
            // 
            // errId_Liqui
            // 
            this.errId_Liqui.ContainerControl = this;
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.rdbName_Liqui);
            this.grp_TimKiem.Controls.Add(this.rdbId_Liqui);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(22, 470);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(890, 69);
            this.grp_TimKiem.TabIndex = 26;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(744, 18);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(101, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbName_Liqui
            // 
            this.rdbName_Liqui.AutoSize = true;
            this.rdbName_Liqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbName_Liqui.Location = new System.Drawing.Point(514, 28);
            this.rdbName_Liqui.Name = "rdbName_Liqui";
            this.rdbName_Liqui.Size = new System.Drawing.Size(97, 19);
            this.rdbName_Liqui.TabIndex = 2;
            this.rdbName_Liqui.TabStop = true;
            this.rdbName_Liqui.Text = "Tên Thanh Lí";
            this.rdbName_Liqui.UseVisualStyleBackColor = true;
            // 
            // rdbId_Liqui
            // 
            this.rdbId_Liqui.AutoSize = true;
            this.rdbId_Liqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Liqui.Location = new System.Drawing.Point(358, 29);
            this.rdbId_Liqui.Name = "rdbId_Liqui";
            this.rdbId_Liqui.Size = new System.Drawing.Size(96, 19);
            this.rdbId_Liqui.TabIndex = 1;
            this.rdbId_Liqui.TabStop = true;
            this.rdbId_Liqui.Text = "Mã Thanh Lý";
            this.rdbId_Liqui.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(251, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(3, 7);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(651, 61);
            this.lbl_QLTaiKhoan.TabIndex = 23;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Thanh Lý Thiết Bị";
            // 
            // errName_Liqui
            // 
            this.errName_Liqui.ContainerControl = this;
            // 
            // dgvListLiqui
            // 
            this.dgvListLiqui.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvListLiqui.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListLiqui.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Liqui,
            this.Name_Liqui,
            this.Id_Device,
            this.Date_Liqui});
            this.dgvListLiqui.Location = new System.Drawing.Point(107, 290);
            this.dgvListLiqui.Name = "dgvListLiqui";
            this.dgvListLiqui.RowHeadersWidth = 51;
            this.dgvListLiqui.Size = new System.Drawing.Size(662, 174);
            this.dgvListLiqui.TabIndex = 27;
            this.dgvListLiqui.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListLiqui_MouseClick);
            // 
            // errId_Device
            // 
            this.errId_Device.ContainerControl = this;
            // 
            // errQty_Device
            // 
            this.errQty_Device.ContainerControl = this;
            // 
            // errDate_Liqui
            // 
            this.errDate_Liqui.ContainerControl = this;
            // 
            // Id_Liqui
            // 
            this.Id_Liqui.DataPropertyName = "Id_Liqui";
            this.Id_Liqui.HeaderText = "Mã Thanh Lý";
            this.Id_Liqui.MinimumWidth = 6;
            this.Id_Liqui.Name = "Id_Liqui";
            this.Id_Liqui.Width = 120;
            // 
            // Name_Liqui
            // 
            this.Name_Liqui.DataPropertyName = "Name_Liqui";
            this.Name_Liqui.HeaderText = "Tên Thanh Lý";
            this.Name_Liqui.MinimumWidth = 6;
            this.Name_Liqui.Name = "Name_Liqui";
            this.Name_Liqui.Width = 170;
            // 
            // Id_Device
            // 
            this.Id_Device.DataPropertyName = "Id_Device";
            this.Id_Device.HeaderText = "Mã Thiết Bị";
            this.Id_Device.MinimumWidth = 6;
            this.Id_Device.Name = "Id_Device";
            this.Id_Device.Width = 150;
            // 
            // Date_Liqui
            // 
            this.Date_Liqui.DataPropertyName = "Date_Liqui";
            this.Date_Liqui.HeaderText = "Ngày Thanh Lý";
            this.Date_Liqui.MinimumWidth = 6;
            this.Date_Liqui.Name = "Date_Liqui";
            this.Date_Liqui.Width = 160;
            // 
            // QLThanhLyTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 551);
            this.Controls.Add(this.dgvListLiqui);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Controls.Add(this.grp_TimKiem);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLThanhLyTB";
            this.Text = "QLThanhLyTB";
            this.Load += new System.EventHandler(this.QLThanhLyTB_Load);
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Liqui)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName_Liqui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListLiqui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDate_Liqui)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtId_Liqui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThanhLyTB;
        private System.Windows.Forms.TextBox txtName_Liqui;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errId_Liqui;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbName_Liqui;
        private System.Windows.Forms.RadioButton rdbId_Liqui;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.ErrorProvider errName_Liqui;
        private System.Windows.Forms.DataGridView dgvListLiqui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDate_Liqui;
        private System.Windows.Forms.TextBox txtDate_Liqui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar mntNgayTL;
        private System.Windows.Forms.ErrorProvider errId_Device;
        private System.Windows.Forms.ErrorProvider errQty_Device;
        private System.Windows.Forms.ErrorProvider errDate_Liqui;
        private System.Windows.Forms.TextBox txtId_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Liqui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Liqui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Device;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_Liqui;
    }
}