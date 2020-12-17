namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class AddNewCustomerDetail
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
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mntNgaySinh = new System.Windows.Forms.MonthCalendar();
            this.txtId_Customer = new System.Windows.Forms.TextBox();
            this.btnNgaySinh = new System.Windows.Forms.Button();
            this.txtId_Group = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdentity_Card = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBirthday_Customer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddress_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName_Customer = new System.Windows.Forms.TextBox();
            this.cbbGrender = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTaiKhoan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(83, 352);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(143, 45);
            this.btnThemTaiKhoan.TabIndex = 13;
            this.btnThemTaiKhoan.Text = "Thêm Người Dùng";
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã Tài Khoản:";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(599, 352);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 46);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên Người Dùng:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(351, 351);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(152, 46);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbbGrender);
            this.groupBox2.Controls.Add(this.mntNgaySinh);
            this.groupBox2.Controls.Add(this.txtId_Customer);
            this.groupBox2.Controls.Add(this.btnNgaySinh);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThemTaiKhoan);
            this.groupBox2.Controls.Add(this.txtId_Group);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIdentity_Card);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtBirthday_Customer);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtAddress_Customer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtName_Customer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(26, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 458);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // mntNgaySinh
            // 
            this.mntNgaySinh.Location = new System.Drawing.Point(531, 67);
            this.mntNgaySinh.MaxSelectionCount = 1;
            this.mntNgaySinh.Name = "mntNgaySinh";
            this.mntNgaySinh.TabIndex = 44;
            this.mntNgaySinh.Visible = false;
            this.mntNgaySinh.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgaySinh_DateSelected);
            // 
            // txtId_Customer
            // 
            this.txtId_Customer.Location = new System.Drawing.Point(190, 44);
            this.txtId_Customer.MaxLength = 50;
            this.txtId_Customer.Name = "txtId_Customer";
            this.txtId_Customer.Size = new System.Drawing.Size(200, 26);
            this.txtId_Customer.TabIndex = 43;
            this.txtId_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_Customer_KeyPress);
            // 
            // btnNgaySinh
            // 
            this.btnNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNgaySinh.Location = new System.Drawing.Point(719, 67);
            this.btnNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNgaySinh.Name = "btnNgaySinh";
            this.btnNgaySinh.Size = new System.Drawing.Size(38, 25);
            this.btnNgaySinh.TabIndex = 42;
            this.btnNgaySinh.Text = "...";
            this.btnNgaySinh.UseVisualStyleBackColor = true;
            this.btnNgaySinh.Click += new System.EventHandler(this.btnNgaySinh_Click);
            // 
            // txtId_Group
            // 
            this.txtId_Group.Location = new System.Drawing.Point(566, 203);
            this.txtId_Group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId_Group.Name = "txtId_Group";
            this.txtId_Group.Size = new System.Drawing.Size(192, 26);
            this.txtId_Group.TabIndex = 41;
            this.txtId_Group.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_Group_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 40;
            this.label6.Text = "Mã Nhóm:";
            // 
            // txtIdentity_Card
            // 
            this.txtIdentity_Card.Location = new System.Drawing.Point(566, 130);
            this.txtIdentity_Card.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdentity_Card.Name = "txtIdentity_Card";
            this.txtIdentity_Card.Size = new System.Drawing.Size(192, 26);
            this.txtIdentity_Card.TabIndex = 39;
            this.txtIdentity_Card.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdentity_Card_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "CMND:";
            // 
            // txtBirthday_Customer
            // 
            this.txtBirthday_Customer.Location = new System.Drawing.Point(566, 67);
            this.txtBirthday_Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBirthday_Customer.Name = "txtBirthday_Customer";
            this.txtBirthday_Customer.Size = new System.Drawing.Size(150, 26);
            this.txtBirthday_Customer.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 34;
            this.label2.Text = "Giới Tính:";
            // 
            // txtAddress_Customer
            // 
            this.txtAddress_Customer.Location = new System.Drawing.Point(190, 167);
            this.txtAddress_Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress_Customer.Name = "txtAddress_Customer";
            this.txtAddress_Customer.Size = new System.Drawing.Size(200, 26);
            this.txtAddress_Customer.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Địa Chỉ:";
            // 
            // txtName_Customer
            // 
            this.txtName_Customer.Location = new System.Drawing.Point(190, 101);
            this.txtName_Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName_Customer.Name = "txtName_Customer";
            this.txtName_Customer.Size = new System.Drawing.Size(200, 26);
            this.txtName_Customer.TabIndex = 31;
            // 
            // cbbGrender
            // 
            this.cbbGrender.FormattingEnabled = true;
            this.cbbGrender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGrender.Location = new System.Drawing.Point(190, 224);
            this.cbbGrender.Name = "cbbGrender";
            this.cbbGrender.Size = new System.Drawing.Size(200, 26);
            this.cbbGrender.TabIndex = 45;
            this.cbbGrender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbGrender_KeyPress);
            // 
            // AddNewCustomerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(850, 506);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddNewCustomerDetail";
            this.Text = "Add New Customer Detail";
            this.Load += new System.EventHandler(this.AddNewCustomerDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName_Customer;
        private System.Windows.Forms.TextBox txtId_Group;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdentity_Card;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBirthday_Customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddress_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNgaySinh;
        private System.Windows.Forms.TextBox txtId_Customer;
        private System.Windows.Forms.MonthCalendar mntNgaySinh;
        private System.Windows.Forms.ComboBox cbbGrender;
    }
}