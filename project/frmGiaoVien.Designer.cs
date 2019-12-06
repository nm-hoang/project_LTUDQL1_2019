namespace project
{
    partial class frmGiaoVien
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
            this.btnQLCauHoi = new System.Windows.Forms.Button();
            this.btnQLDeThi = new System.Windows.Forms.Button();
            this.btnQLKyThiThu = new System.Windows.Forms.Button();
            this.btnQLKyThi = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnQLHocSinh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQLCauHoi
            // 
            this.btnQLCauHoi.Location = new System.Drawing.Point(23, 150);
            this.btnQLCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLCauHoi.Name = "btnQLCauHoi";
            this.btnQLCauHoi.Size = new System.Drawing.Size(188, 56);
            this.btnQLCauHoi.TabIndex = 0;
            this.btnQLCauHoi.Text = "Quản lý câu hỏi";
            this.btnQLCauHoi.UseVisualStyleBackColor = true;
            this.btnQLCauHoi.Click += new System.EventHandler(this.btnQLCauHoi_Click);
            // 
            // btnQLDeThi
            // 
            this.btnQLDeThi.Location = new System.Drawing.Point(244, 150);
            this.btnQLDeThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLDeThi.Name = "btnQLDeThi";
            this.btnQLDeThi.Size = new System.Drawing.Size(188, 56);
            this.btnQLDeThi.TabIndex = 1;
            this.btnQLDeThi.Text = "Quản lý đề thi";
            this.btnQLDeThi.UseVisualStyleBackColor = true;
            // 
            // btnQLKyThiThu
            // 
            this.btnQLKyThiThu.Location = new System.Drawing.Point(244, 254);
            this.btnQLKyThiThu.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLKyThiThu.Name = "btnQLKyThiThu";
            this.btnQLKyThiThu.Size = new System.Drawing.Size(188, 57);
            this.btnQLKyThiThu.TabIndex = 3;
            this.btnQLKyThiThu.Text = "Quản lý kỳ thi thử";
            this.btnQLKyThiThu.UseVisualStyleBackColor = true;
            // 
            // btnQLKyThi
            // 
            this.btnQLKyThi.Location = new System.Drawing.Point(471, 150);
            this.btnQLKyThi.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLKyThi.Name = "btnQLKyThi";
            this.btnQLKyThi.Size = new System.Drawing.Size(188, 56);
            this.btnQLKyThi.TabIndex = 2;
            this.btnQLKyThi.Text = "Quản lý kỳ thi";
            this.btnQLKyThi.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(683, 296);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(170, 46);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnQLHocSinh
            // 
            this.btnQLHocSinh.Location = new System.Drawing.Point(23, 255);
            this.btnQLHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnQLHocSinh.Name = "btnQLHocSinh";
            this.btnQLHocSinh.Size = new System.Drawing.Size(188, 56);
            this.btnQLHocSinh.TabIndex = 4;
            this.btnQLHocSinh.Text = "Quản lý học sinh";
            this.btnQLHocSinh.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Giáo viên";
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(920, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnQLHocSinh);
            this.Controls.Add(this.btnQLKyThiThu);
            this.Controls.Add(this.btnQLKyThi);
            this.Controls.Add(this.btnQLDeThi);
            this.Controls.Add(this.btnQLCauHoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaoVien";
            this.Text = "frmGiaoVien";
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLCauHoi;
        private System.Windows.Forms.Button btnQLDeThi;
        private System.Windows.Forms.Button btnQLKyThiThu;
        private System.Windows.Forms.Button btnQLKyThi;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnQLHocSinh;
        private System.Windows.Forms.Label label1;
    }
}