namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class AddThanhLy
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
            this.label15 = new System.Windows.Forms.Label();
            this.txtName_Liqui = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDate_Liqui = new System.Windows.Forms.TextBox();
            this.btnThemThanhLy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnNgaySinh = new System.Windows.Forms.Button();
            this.cbbThietBi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mntNgayThanhLy = new System.Windows.Forms.MonthCalendar();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 18);
            this.label15.TabIndex = 1;
            this.label15.Text = "Tên Thanh Lý";
            // 
            // txtName_Liqui
            // 
            this.txtName_Liqui.Location = new System.Drawing.Point(176, 125);
            this.txtName_Liqui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName_Liqui.Name = "txtName_Liqui";
            this.txtName_Liqui.Size = new System.Drawing.Size(200, 26);
            this.txtName_Liqui.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Thiết Bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Ngày thanh lý";
            // 
            // txtDate_Liqui
            // 
            this.txtDate_Liqui.Location = new System.Drawing.Point(593, 72);
            this.txtDate_Liqui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate_Liqui.Name = "txtDate_Liqui";
            this.txtDate_Liqui.Size = new System.Drawing.Size(158, 26);
            this.txtDate_Liqui.TabIndex = 37;
            // 
            // btnThemThanhLy
            // 
            this.btnThemThanhLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThemThanhLy.FlatAppearance.BorderSize = 0;
            this.btnThemThanhLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThanhLy.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemThanhLy.ForeColor = System.Drawing.Color.White;
            this.btnThemThanhLy.Location = new System.Drawing.Point(122, 332);
            this.btnThemThanhLy.Name = "btnThemThanhLy";
            this.btnThemThanhLy.Size = new System.Drawing.Size(143, 45);
            this.btnThemThanhLy.TabIndex = 13;
            this.btnThemThanhLy.Text = "Thêm Thanh Lý";
            this.btnThemThanhLy.UseVisualStyleBackColor = false;
            this.btnThemThanhLy.Click += new System.EventHandler(this.btnThemThanhLy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(638, 332);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 46);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLamMoi.FlatAppearance.BorderSize = 0;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.White;
            this.btnLamMoi.Location = new System.Drawing.Point(390, 332);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(152, 46);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnNgaySinh
            // 
            this.btnNgaySinh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNgaySinh.Location = new System.Drawing.Point(754, 72);
            this.btnNgaySinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNgaySinh.Name = "btnNgaySinh";
            this.btnNgaySinh.Size = new System.Drawing.Size(38, 25);
            this.btnNgaySinh.TabIndex = 42;
            this.btnNgaySinh.Text = "...";
            this.btnNgaySinh.UseVisualStyleBackColor = true;
            this.btnNgaySinh.Click += new System.EventHandler(this.btnNgaySinh_Click);
            // 
            // cbbThietBi
            // 
            this.cbbThietBi.FormattingEnabled = true;
            this.cbbThietBi.Location = new System.Drawing.Point(176, 70);
            this.cbbThietBi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbThietBi.Name = "cbbThietBi";
            this.cbbThietBi.Size = new System.Drawing.Size(200, 26);
            this.cbbThietBi.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.mntNgayThanhLy);
            this.groupBox2.Controls.Add(this.cbbThietBi);
            this.groupBox2.Controls.Add(this.btnNgaySinh);
            this.groupBox2.Controls.Add(this.txtDate_Liqui);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtName_Liqui);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(25, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 256);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // mntNgayThanhLy
            // 
            this.mntNgayThanhLy.Location = new System.Drawing.Point(596, 70);
            this.mntNgayThanhLy.MaxSelectionCount = 1;
            this.mntNgayThanhLy.Name = "mntNgayThanhLy";
            this.mntNgayThanhLy.TabIndex = 46;
            this.mntNgayThanhLy.Visible = false;
            this.mntNgayThanhLy.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayThanhLy_DateSelected);
            // 
            // AddThanhLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(945, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemThanhLy);
            this.Controls.Add(this.btnLamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddThanhLy";
            this.Text = "AddThanhLy";
            this.Load += new System.EventHandler(this.AddThanhLy_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtName_Liqui;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDate_Liqui;
        private System.Windows.Forms.Button btnThemThanhLy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnNgaySinh;
        private System.Windows.Forms.ComboBox cbbThietBi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar mntNgayThanhLy;
    }
}