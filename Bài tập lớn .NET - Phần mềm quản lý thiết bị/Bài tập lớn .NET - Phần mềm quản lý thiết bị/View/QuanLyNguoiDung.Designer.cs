namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class QuanLyNguoiDung
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
            this.errAddress_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtId_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_QLTaiKhoan = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.rdbId_Customer = new System.Windows.Forms.RadioButton();
            this.rdbUserName = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grp_TimKiem = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.errName = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAddress_Customer = new System.Windows.Forms.TextBox();
            this.lblMaTK = new System.Windows.Forms.Label();
            this.txtName_Customer = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dgvDSTaiKhoan = new System.Windows.Forms.DataGridView();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtId_Group = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdentity_Customer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBirthday_Customer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGender_Customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorGrender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorBirthday_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorIdentity_Card = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorId_Group = new System.Windows.Forms.ErrorProvider(this.components);
            this.Id_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grender_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identity_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.mntNgaySinh = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.errAddress_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).BeginInit();
            this.grp_TimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGrender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthday_Customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentity_Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId_Group)).BeginInit();
            this.SuspendLayout();
            // 
            // errAddress_Customer
            // 
            this.errAddress_Customer.ContainerControl = this;
            // 
            // errId_Customer
            // 
            this.errId_Customer.ContainerControl = this;
            // 
            // txtId_Customer
            // 
            this.txtId_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Customer.Location = new System.Drawing.Point(104, 30);
            this.txtId_Customer.MaxLength = 20;
            this.txtId_Customer.Name = "txtId_Customer";
            this.txtId_Customer.Size = new System.Drawing.Size(140, 20);
            this.txtId_Customer.TabIndex = 27;
            this.txtId_Customer.TextChanged += new System.EventHandler(this.txtId_Customer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Mã Người Dùng";
            // 
            // lbl_QLTaiKhoan
            // 
            this.lbl_QLTaiKhoan.AutoSize = true;
            this.lbl_QLTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLTaiKhoan.Location = new System.Drawing.Point(16, -4);
            this.lbl_QLTaiKhoan.Name = "lbl_QLTaiKhoan";
            this.lbl_QLTaiKhoan.Size = new System.Drawing.Size(516, 61);
            this.lbl_QLTaiKhoan.TabIndex = 19;
            this.lbl_QLTaiKhoan.Text = "Quản Lý Người Dùng";
            this.lbl_QLTaiKhoan.Click += new System.EventHandler(this.lbl_QLTaiKhoan_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTimKiem.Location = new System.Drawing.Point(708, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(127, 37);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // rdbId_Customer
            // 
            this.rdbId_Customer.AutoSize = true;
            this.rdbId_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbId_Customer.Location = new System.Drawing.Point(514, 28);
            this.rdbId_Customer.Name = "rdbId_Customer";
            this.rdbId_Customer.Size = new System.Drawing.Size(112, 19);
            this.rdbId_Customer.TabIndex = 2;
            this.rdbId_Customer.TabStop = true;
            this.rdbId_Customer.Text = "Mã Người Dùng";
            this.rdbId_Customer.UseVisualStyleBackColor = true;
            // 
            // rdbUserName
            // 
            this.rdbUserName.AutoSize = true;
            this.rdbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUserName.Location = new System.Drawing.Point(358, 29);
            this.rdbUserName.Name = "rdbUserName";
            this.rdbUserName.Size = new System.Drawing.Size(112, 19);
            this.rdbUserName.TabIndex = 1;
            this.rdbUserName.TabStop = true;
            this.rdbUserName.Text = "Tên Đăng Nhập";
            this.rdbUserName.UseVisualStyleBackColor = true;
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
            this.btnLamMoi.Location = new System.Drawing.Point(570, 49);
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
            this.btnXoa.Location = new System.Drawing.Point(718, 49);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 37);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // grp_TimKiem
            // 
            this.grp_TimKiem.Controls.Add(this.btnTimKiem);
            this.grp_TimKiem.Controls.Add(this.rdbId_Customer);
            this.grp_TimKiem.Controls.Add(this.rdbUserName);
            this.grp_TimKiem.Controls.Add(this.txtTimKiem);
            this.grp_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TimKiem.ForeColor = System.Drawing.Color.Black;
            this.grp_TimKiem.Location = new System.Drawing.Point(27, 470);
            this.grp_TimKiem.Name = "grp_TimKiem";
            this.grp_TimKiem.Size = new System.Drawing.Size(854, 69);
            this.grp_TimKiem.TabIndex = 22;
            this.grp_TimKiem.TabStop = false;
            this.grp_TimKiem.Text = "Tìm Kiếm";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(718, 123);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(128, 37);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // errName
            // 
            this.errName.ContainerControl = this;
            // 
            // txtAddress_Customer
            // 
            this.txtAddress_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress_Customer.Location = new System.Drawing.Point(104, 113);
            this.txtAddress_Customer.MaxLength = 20;
            this.txtAddress_Customer.Name = "txtAddress_Customer";
            this.txtAddress_Customer.Size = new System.Drawing.Size(140, 20);
            this.txtAddress_Customer.TabIndex = 17;
            // 
            // lblMaTK
            // 
            this.lblMaTK.AutoSize = true;
            this.lblMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaTK.Location = new System.Drawing.Point(6, 119);
            this.lblMaTK.Name = "lblMaTK";
            this.lblMaTK.Size = new System.Drawing.Size(47, 15);
            this.lblMaTK.TabIndex = 16;
            this.lblMaTK.Text = "Địa Chỉ";
            this.lblMaTK.Click += new System.EventHandler(this.lblMaTK_Click);
            // 
            // txtName_Customer
            // 
            this.txtName_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_Customer.Location = new System.Drawing.Point(104, 74);
            this.txtName_Customer.MaxLength = 20;
            this.txtName_Customer.Name = "txtName_Customer";
            this.txtName_Customer.Size = new System.Drawing.Size(140, 20);
            this.txtName_Customer.TabIndex = 15;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(4, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Tên Người Dùng";
            // 
            // dgvDSTaiKhoan
            // 
            this.dgvDSTaiKhoan.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dgvDSTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Customer,
            this.Name_Customer,
            this.Address_Customer,
            this.Grender_Customer,
            this.Birthday_Customer,
            this.Identity_Card,
            this.Id_Group});
            this.dgvDSTaiKhoan.Location = new System.Drawing.Point(27, 281);
            this.dgvDSTaiKhoan.Name = "dgvDSTaiKhoan";
            this.dgvDSTaiKhoan.RowHeadersWidth = 51;
            this.dgvDSTaiKhoan.Size = new System.Drawing.Size(854, 183);
            this.dgvDSTaiKhoan.TabIndex = 21;
            this.dgvDSTaiKhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSTaiKhoan_MouseClick);
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThemTK.Location = new System.Drawing.Point(570, 123);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(127, 37);
            this.btnThemTK.TabIndex = 19;
            this.btnThemTK.Text = "Thêm Tài Khoản";
            this.btnThemTK.UseVisualStyleBackColor = false;
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.mntNgaySinh);
            this.grpThongTinTaiKhoan.Controls.Add(this.button1);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Group);
            this.grpThongTinTaiKhoan.Controls.Add(this.label5);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtIdentity_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.label4);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnThemTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtBirthday_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.label3);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtGender_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnXoa);
            this.grpThongTinTaiKhoan.Controls.Add(this.label2);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnLamMoi);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnCapNhat);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtAddress_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblMaTK);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtName_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(27, 73);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(884, 202);
            this.grpThongTinTaiKhoan.TabIndex = 20;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // txtId_Group
            // 
            this.txtId_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Group.Location = new System.Drawing.Point(387, 131);
            this.txtId_Group.MaxLength = 20;
            this.txtId_Group.Name = "txtId_Group";
            this.txtId_Group.Size = new System.Drawing.Size(139, 20);
            this.txtId_Group.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mã Nhóm";
            // 
            // txtIdentity_Customer
            // 
            this.txtIdentity_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentity_Customer.Location = new System.Drawing.Point(387, 87);
            this.txtIdentity_Customer.MaxLength = 20;
            this.txtIdentity_Customer.Name = "txtIdentity_Customer";
            this.txtIdentity_Customer.Size = new System.Drawing.Size(139, 20);
            this.txtIdentity_Customer.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "CMND";
            // 
            // txtBirthday_Customer
            // 
            this.txtBirthday_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirthday_Customer.Location = new System.Drawing.Point(387, 43);
            this.txtBirthday_Customer.MaxLength = 20;
            this.txtBirthday_Customer.Name = "txtBirthday_Customer";
            this.txtBirthday_Customer.Size = new System.Drawing.Size(104, 20);
            this.txtBirthday_Customer.TabIndex = 31;
            this.txtBirthday_Customer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ngày Sinh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGender_Customer
            // 
            this.txtGender_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender_Customer.Location = new System.Drawing.Point(104, 153);
            this.txtGender_Customer.MaxLength = 20;
            this.txtGender_Customer.Name = "txtGender_Customer";
            this.txtGender_Customer.Size = new System.Drawing.Size(140, 20);
            this.txtGender_Customer.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "Giới Tính";
            // 
            // errorGrender
            // 
            this.errorGrender.ContainerControl = this;
            // 
            // errorBirthday_Customer
            // 
            this.errorBirthday_Customer.ContainerControl = this;
            // 
            // errorIdentity_Card
            // 
            this.errorIdentity_Card.ContainerControl = this;
            // 
            // errorId_Group
            // 
            this.errorId_Group.ContainerControl = this;
            // 
            // Id_Customer
            // 
            this.Id_Customer.DataPropertyName = "Id_Customer";
            this.Id_Customer.HeaderText = "Mã Người Dùng";
            this.Id_Customer.MinimumWidth = 6;
            this.Id_Customer.Name = "Id_Customer";
            this.Id_Customer.Width = 110;
            // 
            // Name_Customer
            // 
            this.Name_Customer.DataPropertyName = "Name_Customer";
            this.Name_Customer.HeaderText = "Tên Người Dùng";
            this.Name_Customer.MinimumWidth = 6;
            this.Name_Customer.Name = "Name_Customer";
            this.Name_Customer.ReadOnly = true;
            this.Name_Customer.Width = 140;
            // 
            // Address_Customer
            // 
            this.Address_Customer.DataPropertyName = "Address_Customer";
            this.Address_Customer.HeaderText = "Địa Chỉ";
            this.Address_Customer.MinimumWidth = 6;
            this.Address_Customer.Name = "Address_Customer";
            this.Address_Customer.ReadOnly = true;
            this.Address_Customer.Width = 130;
            // 
            // Grender_Customer
            // 
            this.Grender_Customer.DataPropertyName = "Grender_Customer";
            this.Grender_Customer.HeaderText = "Giới Tính";
            this.Grender_Customer.MinimumWidth = 6;
            this.Grender_Customer.Name = "Grender_Customer";
            this.Grender_Customer.Width = 80;
            // 
            // Birthday_Customer
            // 
            this.Birthday_Customer.DataPropertyName = "Birthday_Customer";
            this.Birthday_Customer.HeaderText = "Ngày Sinh";
            this.Birthday_Customer.MinimumWidth = 6;
            this.Birthday_Customer.Name = "Birthday_Customer";
            this.Birthday_Customer.Width = 150;
            // 
            // Identity_Card
            // 
            this.Identity_Card.DataPropertyName = "Identity_Card";
            this.Identity_Card.HeaderText = "CMND";
            this.Identity_Card.MinimumWidth = 6;
            this.Identity_Card.Name = "Identity_Card";
            // 
            // Id_Group
            // 
            this.Id_Group.DataPropertyName = "Id_Group";
            this.Id_Group.HeaderText = "Mã Nhóm";
            this.Id_Group.MinimumWidth = 6;
            this.Id_Group.Name = "Id_Group";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 22);
            this.button1.TabIndex = 36;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mntNgaySinh
            // 
            this.mntNgaySinh.Location = new System.Drawing.Point(299, 12);
            this.mntNgaySinh.MaxSelectionCount = 1;
            this.mntNgaySinh.Name = "mntNgaySinh";
            this.mntNgaySinh.TabIndex = 37;
            this.mntNgaySinh.Visible = false;
            this.mntNgaySinh.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntNgaySinh_DateChanged);
            this.mntNgaySinh.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgaySinh_DateSelected);
            // 
            // QuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 551);
            this.Controls.Add(this.lbl_QLTaiKhoan);
            this.Controls.Add(this.grp_TimKiem);
            this.Controls.Add(this.dgvDSTaiKhoan);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyNguoiDung";
            this.Text = "QuanLyNguoiDung";
            this.Load += new System.EventHandler(this.QuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errAddress_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).EndInit();
            this.grp_TimKiem.ResumeLayout(false);
            this.grp_TimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTaiKhoan)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorGrender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorBirthday_Customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIdentity_Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorId_Group)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errAddress_Customer;
        private System.Windows.Forms.Label lbl_QLTaiKhoan;
        private System.Windows.Forms.GroupBox grp_TimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.RadioButton rdbId_Customer;
        private System.Windows.Forms.RadioButton rdbUserName;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSTaiKhoan;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.TextBox txtId_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.TextBox txtAddress_Customer;
        private System.Windows.Forms.Label lblMaTK;
        private System.Windows.Forms.TextBox txtName_Customer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errId_Customer;
        private System.Windows.Forms.ErrorProvider errName;
        private System.Windows.Forms.TextBox txtBirthday_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGender_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdentity_Customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId_Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorGrender;
        private System.Windows.Forms.ErrorProvider errorBirthday_Customer;
        private System.Windows.Forms.ErrorProvider errorIdentity_Card;
        private System.Windows.Forms.ErrorProvider errorId_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grender_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identity_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar mntNgaySinh;
    }
}