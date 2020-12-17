namespace Bài_tập_lớn.NET___Phần_mềm_quản_lý_thiết_bị.View
{
    partial class Default
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
            this.lbThu = new System.Windows.Forms.Label();
            this.lbNgayThang = new System.Windows.Forms.Label();
            this.lbtGio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.Location = new System.Drawing.Point(824, 501);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(328, 91);
            this.lbThu.TabIndex = 22;
            this.lbThu.Text = "Monday";
            // 
            // lbNgayThang
            // 
            this.lbNgayThang.AutoSize = true;
            this.lbNgayThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayThang.Location = new System.Drawing.Point(65, 501);
            this.lbNgayThang.Name = "lbNgayThang";
            this.lbNgayThang.Size = new System.Drawing.Size(445, 91);
            this.lbNgayThang.TabIndex = 21;
            this.lbNgayThang.Text = "20/11/2020";
            // 
            // lbtGio
            // 
            this.lbtGio.AutoSize = true;
            this.lbtGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtGio.Location = new System.Drawing.Point(373, 270);
            this.lbtGio.Name = "lbtGio";
            this.lbtGio.Size = new System.Drawing.Size(533, 135);
            this.lbtGio.TabIndex = 20;
            this.lbtGio.Text = "12:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(787, 58);
            this.label2.TabIndex = 19;
            this.label2.Text = "Trường Đại Học Sư Phạm Hà Nội";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1103, 76);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phần Mềm Quản Lý Thiết Bị Nhà K";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 642);
            this.Controls.Add(this.lbThu);
            this.Controls.Add(this.lbNgayThang);
            this.Controls.Add(this.lbtGio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Default";
            this.Text = "Default";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbNgayThang;
        private System.Windows.Forms.Label lbtGio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}