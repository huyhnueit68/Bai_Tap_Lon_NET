namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QuanLyTaiKhoan
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
            this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Id_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassWord_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbId_Customer = new System.Windows.Forms.RadioButton();
            this.rdbUserName = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtId_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errId_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errUser_Name = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPass_Word = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUser_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPass_Word)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSTaiKhoan
            // 
            this.dgvDSTaiKhoan.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Customer,
            this.User_Name_Customer,
            this.PassWord_Customer});
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(193, 358);
            this.dgvDSTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            this.dgvDSTaiKhoan.RowHeadersWidth = 51;
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(868, 214);
            this.dgvDSTaiKhoan.TabIndex = 5;
            this.dgvDSTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSTaiKhoan_MouseClick);
            // 
            // Id_Customer
            // 
            this.Id_Customer.DataPropertyName = "Id_Customer";
            this.Id_Customer.HeaderText = "Mã Người Dùng";
            this.Id_Customer.MinimumWidth = 6;
            this.Id_Customer.Name = "Id_Customer";
            this.Id_Customer.Width = 150;
            // 
            // User_Name_Customer
            // 
            this.User_Name_Customer.DataPropertyName = "User_Name_Customer";
            this.User_Name_Customer.HeaderText = "Tên Đăng Nhập";
            this.User_Name_Customer.MinimumWidth = 6;
            this.User_Name_Customer.Name = "User_Name_Customer";
            this.User_Name_Customer.ReadOnly = true;
            this.User_Name_Customer.Width = 250;
            // 
            // PassWord_Customer
            // 
            this.PassWord_Customer.DataPropertyName = "PassWord_Customer";
            this.PassWord_Customer.HeaderText = "Mật Khẩu";
            this.PassWord_Customer.MinimumWidth = 6;
            this.PassWord_Customer.Name = "PassWord_Customer";
            this.PassWord_Customer.ReadOnly = true;
            this.PassWord_Customer.Width = 200;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(164, 178);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaTK.MaxLength = 20;
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(233, 24);
            this.txtMaTK.TabIndex = 17;
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTK.Location = new System.Drawing.Point(8, 178);
            this.lblMaTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(71, 18);
            this.lblMaTK.TabIndex = 16;
            this.lblMaTK.Text = "Mật Khẩu";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(164, 116);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(233, 24);
            this.txtUsername.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(5, 122);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(115, 18);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Đăng Nhập:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLamMoi.Location = new System.Drawing.Point(740, 47);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(169, 46);
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
            this.btnXoa.Location = new System.Drawing.Point(740, 159);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(169, 46);
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
            this.btnCapNhat.Location = new System.Drawing.Point(991, 47);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(171, 46);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTK.Location = new System.Drawing.Point(992, 159);
            this.btnThemTK.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(169, 46);
            this.btnThemTK.TabIndex = 19;
            this.btnThemTK.Text = "Thêm Tài Khoản";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.rdbId_Customer);
            this.grp_TimKiem.Controls.Add(this.rdbUserName);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(41, 580);
            this.grp_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grp_TimKiem.Size = new System.Drawing.Size(1187, 85);
            this.grp_TimKiem.TabIndex = 18;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(992, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(135, 46);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // rdbId_Customer
            // 
            this.rdbId_Customer.AutoSize = true;
            this.rdbId_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Customer.Location = new System.Drawing.Point(685, 34);
            this.rdbId_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.rdbId_Customer.Name = "rdbId_Customer";
            this.rdbId_Customer.Size = new System.Drawing.Size(132, 22);
            this.rdbId_Customer.TabIndex = 2;
            this.rdbId_Customer.TabStop = true;
            this.rdbId_Customer.Text = "Mã Người Dùng";
            this.rdbId_Customer.UseVisualStyleBackColor = true;
            // 
            // rdbUserName
            // 
            this.rdbUserName.AutoSize = true;
            this.rdbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUserName.Location = new System.Drawing.Point(477, 36);
            this.rdbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.rdbUserName.Name = "rdbUserName";
            this.rdbUserName.Size = new System.Drawing.Size(132, 22);
            this.rdbUserName.TabIndex = 1;
            this.rdbUserName.TabStop = true;
            this.rdbUserName.Text = "Tên Đăng Nhập";
            this.rdbUserName.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(11, 34);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(333, 26);
            this.txtTimKiem.TabIndex = 0;
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(15, 11);
            this.lbl_QLTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(606, 76);
            this.lbl_QLTaiKhoan.TabIndex = 3;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Tài Khoản";
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThemTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtMaTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblMaTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtUsername);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(29, 114);
            this.grpThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(1195, 267);
            this.grpThongTinTaiKhoan.TabIndex = 4;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin Tài Khoản";
            // 
            // txtId_Customer
            // 
            this.txtId_Customer.Location = new System.Drawing.Point(164, 54);
            this.txtId_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Customer.MaxLength = 20;
            this.txtId_Customer.Name = "txtId_Customer";
            this.txtId_Customer.Size = new System.Drawing.Size(233, 24);
            this.txtId_Customer.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Người Dùng";
            // 
            // errId_Customer
            // 
            this.errId_Customer.ContainerControl = this;
            // 
            // errUser_Name
            // 
            this.errUser_Name.ContainerControl = this;
            // 
            // errPass_Word
            // 
            this.errPass_Word.ContainerControl = this;
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1236, 679);
            this.Controls.Add(this.dgvDSTaiKhoan);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Controls.Add(this.grp_TimKiem);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errUser_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPass_Word)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbId_Customer;
        private System.Windows.Forms.RadioButton rdbUserName;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtId_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassWord_Customer;
        private System.Windows.Forms.ErrorProvider errId_Customer;
        private System.Windows.Forms.ErrorProvider errUser_Name;
        private System.Windows.Forms.ErrorProvider errPass_Word;
    }
}