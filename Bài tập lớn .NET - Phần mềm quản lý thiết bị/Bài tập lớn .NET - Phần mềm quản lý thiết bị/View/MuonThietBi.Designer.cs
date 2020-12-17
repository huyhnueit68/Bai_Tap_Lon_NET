namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class MuonThietBi
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
            this.button1 = new System.Windows.Forms.Button();
            this.rdbTra = new System.Windows.Forms.RadioButton();
            this.rdbMuon = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId_Customer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate_Pay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errId_Rent = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDay_Rent = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDay_Pay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errId_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnMuonTB = new System.Windows.Forms.Button();
            this.txtDate_Rent = new System.Windows.Forms.TextBox();
            this.errQty_Device = new System.Windows.Forms.ErrorProvider(this.components);
            this.errStatus_Rent = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUsername = new System.Windows.Forms.Label();
            this.errId_Customer = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.txtQty_Device = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbThietBi = new System.Windows.Forms.ComboBox();
            this.mntNgayTra = new System.Windows.Forms.MonthCalendar();
            this.mntNgayMuon = new System.Windows.Forms.MonthCalendar();
            this.btnNgayTra = new System.Windows.Forms.Button();
            this.btnNgayMuon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Rent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).BeginInit();
            this.grpThongTinTaiKhoan.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(665, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 46);
            this.button1.TabIndex = 40;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbTra
            // 
            this.rdbTra.AutoSize = true;
            this.rdbTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTra.Location = new System.Drawing.Point(551, 247);
            this.rdbTra.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTra.Name = "rdbTra";
            this.rdbTra.Size = new System.Drawing.Size(51, 22);
            this.rdbTra.TabIndex = 39;
            this.rdbTra.TabStop = true;
            this.rdbTra.Text = "Trả";
            this.rdbTra.UseVisualStyleBackColor = true;
            // 
            // rdbMuon
            // 
            this.rdbMuon.AutoSize = true;
            this.rdbMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMuon.Location = new System.Drawing.Point(425, 247);
            this.rdbMuon.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMuon.Name = "rdbMuon";
            this.rdbMuon.Size = new System.Drawing.Size(67, 22);
            this.rdbMuon.TabIndex = 38;
            this.rdbMuon.TabStop = true;
            this.rdbMuon.Text = "Mượn";
            this.rdbMuon.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(504, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 36;
            this.label6.Text = "Thiết Bị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Trạng Thái";
            // 
            // txtId_Customer
            // 
            this.txtId_Customer.Location = new System.Drawing.Point(649, 178);
            this.txtId_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.txtId_Customer.MaxLength = 20;
            this.txtId_Customer.Name = "txtId_Customer";
            this.txtId_Customer.Size = new System.Drawing.Size(183, 24);
            this.txtId_Customer.TabIndex = 31;
            this.txtId_Customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_Customer_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(504, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtDate_Pay
            // 
            this.txtDate_Pay.Location = new System.Drawing.Point(191, 117);
            this.txtDate_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate_Pay.MaxLength = 20;
            this.txtDate_Pay.Name = "txtDate_Pay";
            this.txtDate_Pay.Size = new System.Drawing.Size(173, 24);
            this.txtDate_Pay.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ngày Trả";
            // 
            // errId_Rent
            // 
            this.errId_Rent.ContainerControl = this;
            // 
            // errDay_Rent
            // 
            this.errDay_Rent.ContainerControl = this;
            // 
            // errDay_Pay
            // 
            this.errDay_Pay.ContainerControl = this;
            // 
            // errId_Device
            // 
            this.errId_Device.ContainerControl = this;
            // 
            // btnMuonTB
            // 
            this.btnMuonTB.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMuonTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMuonTB.Location = new System.Drawing.Point(124, 364);
            this.btnMuonTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuonTB.Name = "btnMuonTB";
            this.btnMuonTB.Size = new System.Drawing.Size(196, 46);
            this.btnMuonTB.TabIndex = 21;
            this.btnMuonTB.Text = "Mượn Thiết Bị";
            this.btnMuonTB.UseVisualStyleBackColor = false;
            this.btnMuonTB.Click += new System.EventHandler(this.btnTraTB_Click);
            // 
            // txtDate_Rent
            // 
            this.txtDate_Rent.Location = new System.Drawing.Point(191, 60);
            this.txtDate_Rent.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate_Rent.MaxLength = 20;
            this.txtDate_Rent.Name = "txtDate_Rent";
            this.txtDate_Rent.Size = new System.Drawing.Size(173, 24);
            this.txtDate_Rent.TabIndex = 15;
            // 
            // errQty_Device
            // 
            this.errQty_Device.ContainerControl = this;
            // 
            // errStatus_Rent
            // 
            this.errStatus_Rent.ContainerControl = this;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(64, 68);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 18);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Ngày Mượn";
            // 
            // errId_Customer
            // 
            this.errId_Customer.ContainerControl = this;
            // 
            // grpThongTinTaiKhoan
            // 
            this.grpThongTinTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTinTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.grpThongTinTaiKhoan.Controls.Add(this.txtQty_Device);
            this.grpThongTinTaiKhoan.Controls.Add(this.label1);
            this.grpThongTinTaiKhoan.Controls.Add(this.cbbThietBi);
            this.grpThongTinTaiKhoan.Controls.Add(this.mntNgayTra);
            this.grpThongTinTaiKhoan.Controls.Add(this.mntNgayMuon);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnNgayTra);
            this.grpThongTinTaiKhoan.Controls.Add(this.btnNgayMuon);
            this.grpThongTinTaiKhoan.Controls.Add(this.rdbTra);
            this.grpThongTinTaiKhoan.Controls.Add(this.rdbMuon);
            this.grpThongTinTaiKhoan.Controls.Add(this.label6);
            this.grpThongTinTaiKhoan.Controls.Add(this.label4);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtId_Customer);
            this.grpThongTinTaiKhoan.Controls.Add(this.label3);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDate_Pay);
            this.grpThongTinTaiKhoan.Controls.Add(this.label2);
            this.grpThongTinTaiKhoan.Controls.Add(this.txtDate_Rent);
            this.grpThongTinTaiKhoan.Controls.Add(this.lblUsername);
            this.grpThongTinTaiKhoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpThongTinTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.grpThongTinTaiKhoan.Location = new System.Drawing.Point(16, 43);
            this.grpThongTinTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinTaiKhoan.Name = "grpThongTinTaiKhoan";
            this.grpThongTinTaiKhoan.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinTaiKhoan.Size = new System.Drawing.Size(915, 288);
            this.grpThongTinTaiKhoan.TabIndex = 29;
            this.grpThongTinTaiKhoan.TabStop = false;
            this.grpThongTinTaiKhoan.Text = "Thông Tin";
            // 
            // txtQty_Device
            // 
            this.txtQty_Device.Location = new System.Drawing.Point(649, 114);
            this.txtQty_Device.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty_Device.MaxLength = 20;
            this.txtQty_Device.Name = "txtQty_Device";
            this.txtQty_Device.Size = new System.Drawing.Size(183, 24);
            this.txtQty_Device.TabIndex = 50;
            this.txtQty_Device.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_Device_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Số Lượng";
            // 
            // cbbThietBi
            // 
            this.cbbThietBi.FormattingEnabled = true;
            this.cbbThietBi.Location = new System.Drawing.Point(649, 52);
            this.cbbThietBi.Margin = new System.Windows.Forms.Padding(4);
            this.cbbThietBi.Name = "cbbThietBi";
            this.cbbThietBi.Size = new System.Drawing.Size(183, 26);
            this.cbbThietBi.TabIndex = 48;
            // 
            // mntNgayTra
            // 
            this.mntNgayTra.Location = new System.Drawing.Point(147, 41);
            this.mntNgayTra.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mntNgayTra.MaxSelectionCount = 1;
            this.mntNgayTra.Name = "mntNgayTra";
            this.mntNgayTra.TabIndex = 47;
            this.mntNgayTra.Visible = false;
            this.mntNgayTra.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayTra_DateSelected);
            // 
            // mntNgayMuon
            // 
            this.mntNgayMuon.Location = new System.Drawing.Point(148, 29);
            this.mntNgayMuon.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mntNgayMuon.MaxSelectionCount = 1;
            this.mntNgayMuon.Name = "mntNgayMuon";
            this.mntNgayMuon.TabIndex = 46;
            this.mntNgayMuon.Visible = false;
            this.mntNgayMuon.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mntNgayMuon_DateSelected);
            // 
            // btnNgayTra
            // 
            this.btnNgayTra.ForeColor = System.Drawing.Color.Black;
            this.btnNgayTra.Location = new System.Drawing.Point(375, 114);
            this.btnNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnNgayTra.Name = "btnNgayTra";
            this.btnNgayTra.Size = new System.Drawing.Size(36, 28);
            this.btnNgayTra.TabIndex = 45;
            this.btnNgayTra.Text = "...";
            this.btnNgayTra.UseVisualStyleBackColor = true;
            this.btnNgayTra.Click += new System.EventHandler(this.btnNgayTra_Click);
            // 
            // btnNgayMuon
            // 
            this.btnNgayMuon.ForeColor = System.Drawing.Color.Black;
            this.btnNgayMuon.Location = new System.Drawing.Point(375, 59);
            this.btnNgayMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnNgayMuon.Name = "btnNgayMuon";
            this.btnNgayMuon.Size = new System.Drawing.Size(36, 28);
            this.btnNgayMuon.TabIndex = 44;
            this.btnNgayMuon.Text = "...";
            this.btnNgayMuon.UseVisualStyleBackColor = true;
            this.btnNgayMuon.Click += new System.EventHandler(this.btnNgayMuon_Click);
            // 
            // MuonThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(947, 462);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpThongTinTaiKhoan);
            this.Controls.Add(this.btnMuonTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MuonThietBi";
            this.Text = "MuonThietBi";
            this.Load += new System.EventHandler(this.MuonThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errId_Rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDay_Pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errQty_Device)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStatus_Rent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errId_Customer)).EndInit();
            this.grpThongTinTaiKhoan.ResumeLayout(false);
            this.grpThongTinTaiKhoan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbTra;
        private System.Windows.Forms.RadioButton rdbMuon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId_Customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate_Pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errId_Rent;
        private System.Windows.Forms.GroupBox grpThongTinTaiKhoan;
        private System.Windows.Forms.Button btnMuonTB;
        private System.Windows.Forms.TextBox txtDate_Rent;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errDay_Rent;
        private System.Windows.Forms.ErrorProvider errDay_Pay;
        private System.Windows.Forms.ErrorProvider errId_Device;
        private System.Windows.Forms.ErrorProvider errQty_Device;
        private System.Windows.Forms.ErrorProvider errStatus_Rent;
        private System.Windows.Forms.ErrorProvider errId_Customer;
        private System.Windows.Forms.MonthCalendar mntNgayTra;
        private System.Windows.Forms.MonthCalendar mntNgayMuon;
        private System.Windows.Forms.Button btnNgayTra;
        private System.Windows.Forms.Button btnNgayMuon;
        private System.Windows.Forms.ComboBox cbbThietBi;
        private System.Windows.Forms.TextBox txtQty_Device;
        private System.Windows.Forms.Label label1;
    }
}