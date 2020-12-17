namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QLNhomNguoiDungcs
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
            this.errorId_Group = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId_Group = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbId_Group = new System.Windows.Forms.RadioButton();
            this.rdbName_Group = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.errorName_Group = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtName_Group = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvListCustomerGroup = new System.Windows.Forms.DataGridView();
            this.Id_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorId_Group)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomerGroup)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorId_Group
            // 
            this.errorId_Group.ContainerControl = this;
            // 
            // txtId_Group
            // 
            this.txtId_Group.Location = new System.Drawing.Point(177, 54);
            this.txtId_Group.MaxLength = 20;
            this.txtId_Group.Name = "txtId_Group";
            this.txtId_Group.Size = new System.Drawing.Size(176, 21);
            this.txtId_Group.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Nhóm:";
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(10, 7);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(670, 61);
            this.lbl_QLTaiKhoan.TabIndex = 19;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Nhóm Người Dùng";
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
            // rdbId_Group
            // 
            this.rdbId_Group.AutoSize = true;
            this.rdbId_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Group.Location = new System.Drawing.Point(514, 28);
            this.rdbId_Group.Name = "rdbId_Group";
            this.rdbId_Group.Size = new System.Drawing.Size(80, 19);
            this.rdbId_Group.TabIndex = 2;
            this.rdbId_Group.TabStop = true;
            this.rdbId_Group.Text = "Mã Nhóm";
            this.rdbId_Group.UseVisualStyleBackColor = true;
            // 
            // rdbName_Group
            // 
            this.rdbName_Group.AutoSize = true;
            this.rdbName_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbName_Group.Location = new System.Drawing.Point(358, 29);
            this.rdbName_Group.Name = "rdbName_Group";
            this.rdbName_Group.Size = new System.Drawing.Size(83, 19);
            this.rdbName_Group.TabIndex = 1;
            this.rdbName_Group.TabStop = true;
            this.rdbName_Group.Text = "Tên Nhóm";
            this.rdbName_Group.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(8, 28);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(251, 22);
            this.txtTimKiem.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(524, 38);
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
            this.btnXoa.Location = new System.Drawing.Point(524, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 37);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.rdbId_Group);
            this.grp_TimKiem.Controls.Add(this.rdbName_Group);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(29, 470);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(890, 69);
            this.grp_TimKiem.TabIndex = 22;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
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
            // errorName_Group
            // 
            this.errorName_Group.ContainerControl = this;
            // 
            // txtName_Group
            // 
            this.txtName_Group.Location = new System.Drawing.Point(177, 104);
            this.txtName_Group.MaxLength = 20;
            this.txtName_Group.Name = "txtName_Group";
            this.txtName_Group.Size = new System.Drawing.Size(176, 21);
            this.txtName_Group.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(58, 109);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Nhóm:";
            // 
            // dgvListCustomerGroup
            // 
            this.dgvListCustomerGroup.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvListCustomerGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomerGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Group,
            this.Name_Group});
            this.dgvListCustomerGroup.Location = new System.Drawing.Point(234, 289);
            this.dgvListCustomerGroup.Name = "dgvListCustomerGroup";
            this.dgvListCustomerGroup.RowHeadersWidth = 51;
            this.dgvListCustomerGroup.Size = new System.Drawing.Size(446, 174);
            this.dgvListCustomerGroup.TabIndex = 21;
            this.dgvListCustomerGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvListCustomerGroup_MouseClick);
            // 
            // Id_Group
            // 
            this.Id_Group.DataPropertyName = "Id_Group";
            this.Id_Group.HeaderText = "Mã Nhóm";
            this.Id_Group.MinimumWidth = 6;
            this.Id_Group.Name = "Id_Group";
            this.Id_Group.Width = 150;
            // 
            // Name_Group
            // 
            this.Name_Group.DataPropertyName = "Name_Group";
            this.Name_Group.HeaderText = "Tên Nhóm";
            this.Name_Group.MinimumWidth = 6;
            this.Name_Group.Name = "Name_Group";
            this.Name_Group.ReadOnly = true;
            this.Name_Group.Width = 250;
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTK.Location = new System.Drawing.Point(705, 129);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(127, 37);
            this.btnThemTK.TabIndex = 19;
            this.btnThemTK.Text = "Thêm Tài Khoản";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Group);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThemTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtName_Group);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(29, 91);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(905, 264);
            this.grpThongTinTaiKhoan.TabIndex = 20;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // QLNhomNguoiDungcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 551);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Controls.Add(this.grp_TimKiem);
            this.Controls.Add(this.dgvListCustomerGroup);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QLNhomNguoiDungcs";
            this.Text = "QLNhomNguoiDungcs";
            this.Load += new System.EventHandler(this.QLNhomNguoiDungcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorId_Group)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorName_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomerGroup)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorId_Group;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbId_Group;
        private System.Windows.Forms.RadioButton rdbName_Group;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvListCustomerGroup;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtId_Group;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.TextBox txtName_Group;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errorName_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Group;
    }
}