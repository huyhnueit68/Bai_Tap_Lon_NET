namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QLLoaiTB
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
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.rdbId_Type = new System.Windows.Forms.RadioButton();
            this.rdbName_Type = new System.Windows.Forms.RadioButton();
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.dgvDSLoaiTB = new System.Windows.Forms.DataGridView();
            this.Id_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Device = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtId_Type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtName_Type = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.errIdType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNameType = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_TimKiem.SuspendLayout();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIdType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNameType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(-4, -2);
            this.lbl_QLTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(671, 76);
            this.lbl_QLTaiKhoan.TabIndex = 28;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Loại Thiết Bị";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(944, 25);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(169, 46);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(11, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(388, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.rdbId_Type);
            this.grp_TimKiem.Controls.Add(this.rdbName_Type);
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(11, 581);
            this.grp_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grp_TimKiem.Size = new System.Drawing.Size(1161, 85);
            this.grp_TimKiem.TabIndex = 30;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // rdbId_Type
            // 
            this.rdbId_Type.AutoSize = true;
            this.rdbId_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Type.Location = new System.Drawing.Point(488, 38);
            this.rdbId_Type.Margin = new System.Windows.Forms.Padding(4);
            this.rdbId_Type.Name = "rdbId_Type";
            this.rdbId_Type.Size = new System.Drawing.Size(135, 22);
            this.rdbId_Type.TabIndex = 5;
            this.rdbId_Type.TabStop = true;
            this.rdbId_Type.Text = "Mã Loại Thiết Bị";
            this.rdbId_Type.UseVisualStyleBackColor = true;
            // 
            // rdbName_Type
            // 
            this.rdbName_Type.AutoSize = true;
            this.rdbName_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbName_Type.Location = new System.Drawing.Point(696, 38);
            this.rdbName_Type.Margin = new System.Windows.Forms.Padding(4);
            this.rdbName_Type.Name = "rdbName_Type";
            this.rdbName_Type.Size = new System.Drawing.Size(109, 22);
            this.rdbName_Type.TabIndex = 4;
            this.rdbName_Type.TabStop = true;
            this.rdbName_Type.Text = "Tên Loại TB";
            this.rdbName_Type.UseVisualStyleBackColor = true;
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.dgvDSLoaiTB);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThemTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Type);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtName_Type);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(11, 93);
            this.grpThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(1194, 480);
            this.grpThongTinTaiKhoan.TabIndex = 29;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // dgvDSLoaiTB
            // 
            this.dgvDSLoaiTB.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvDSLoaiTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLoaiTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Type,
            this.Name_Device});
            this.dgvDSLoaiTB.Location = new System.Drawing.Point(237, 247);
            this.dgvDSLoaiTB.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSLoaiTB.Name = "dgvDSLoaiTB";
            this.dgvDSLoaiTB.RowHeadersWidth = 51;
            this.dgvDSLoaiTB.Size = new System.Drawing.Size(692, 225);
            this.dgvDSLoaiTB.TabIndex = 32;
            this.dgvDSLoaiTB.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLoaiTB_CellContentClick);
            this.dgvDSLoaiTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSLoaiTB_MouseClick);
            // 
            // Id_Type
            // 
            this.Id_Type.DataPropertyName = "Id_Type";
            this.Id_Type.HeaderText = "Mã Loại Thiết Bị";
            this.Id_Type.MinimumWidth = 6;
            this.Id_Type.Name = "Id_Type";
            this.Id_Type.Width = 200;
            // 
            // Name_Device
            // 
            this.Name_Device.DataPropertyName = "Name_Device";
            this.Name_Device.HeaderText = "Tên Loại Thiết Bị";
            this.Name_Device.MinimumWidth = 6;
            this.Name_Device.Name = "Name_Device";
            this.Name_Device.ReadOnly = true;
            this.Name_Device.Width = 250;
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTK.Location = new System.Drawing.Point(675, 151);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(213, 46);
            this.btnThemTK.TabIndex = 19;
            this.btnThemTK.Text = "Thêm Loại Thiết Bị";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(398, 151);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(171, 46);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtId_Type
            // 
            this.txtId_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Type.Location = new System.Drawing.Point(352, 73);
            this.txtId_Type.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Type.MaxLength = 20;
            this.txtId_Type.Name = "txtId_Type";
            this.txtId_Type.Size = new System.Drawing.Size(185, 23);
            this.txtId_Type.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Loại Thiết Bị";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(72, 151);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(169, 46);
            this.btnLamMoi.TabIndex = 25;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(957, 151);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(171, 46);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtName_Type
            // 
            this.txtName_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Type.Location = new System.Drawing.Point(744, 73);
            this.txtName_Type.Margin = new System.Windows.Forms.Padding(4);
            this.txtName_Type.MaxLength = 20;
            this.txtName_Type.Name = "txtName_Type";
            this.txtName_Type.Size = new System.Drawing.Size(185, 23);
            this.txtName_Type.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(610, 79);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(118, 18);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Loại Thiết Bị";
            // 
            // errIdType
            // 
            this.errIdType.ContainerControl = this;
            // 
            // errNameType
            // 
            this.errNameType.ContainerControl = this;
            // 
            // QLLoaiTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 685);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Controls.Add(this.grp_TimKiem);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Name = "QLLoaiTB";
            this.Text = "QLLoaiTB";
            this.Load += new System.EventHandler(this.QLLoaiTB_Load);
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLoaiTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errIdType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNameType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtId_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtName_Type;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dgvDSLoaiTB;
        private System.Windows.Forms.RadioButton rdbId_Type;
        private System.Windows.Forms.RadioButton rdbName_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Device;
        private System.Windows.Forms.ErrorProvider errIdType;
        private System.Windows.Forms.ErrorProvider errNameType;
    }
}