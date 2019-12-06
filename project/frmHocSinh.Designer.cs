namespace project
{
    partial class frmHocSinh
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
            this.btnTTSV = new System.Windows.Forms.Button();
            this.btnThi = new System.Windows.Forms.Button();
            this.btnDGop = new System.Windows.Forms.Button();
            this.btnThiThu = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTTSV
            // 
            this.btnTTSV.Location = new System.Drawing.Point(34, 146);
            this.btnTTSV.Name = "btnTTSV";
            this.btnTTSV.Size = new System.Drawing.Size(120, 23);
            this.btnTTSV.TabIndex = 0;
            this.btnTTSV.Text = "Thông tin sinh viên";
            this.btnTTSV.UseVisualStyleBackColor = true;
            this.btnTTSV.Click += new System.EventHandler(this.btnTTSV_Click);
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(203, 146);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(140, 23);
            this.btnThi.TabIndex = 1;
            this.btnThi.Text = "Làm bài trắc nghiệm";
            this.btnThi.UseVisualStyleBackColor = true;
            // 
            // btnDGop
            // 
            this.btnDGop.Location = new System.Drawing.Point(530, 146);
            this.btnDGop.Name = "btnDGop";
            this.btnDGop.Size = new System.Drawing.Size(123, 23);
            this.btnDGop.TabIndex = 2;
            this.btnDGop.Text = "Đóng góp câu hỏi";
            this.btnDGop.UseVisualStyleBackColor = true;
            // 
            // btnThiThu
            // 
            this.btnThiThu.Location = new System.Drawing.Point(377, 146);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Size = new System.Drawing.Size(128, 23);
            this.btnThiThu.TabIndex = 3;
            this.btnThiThu.Text = "Làm bài thi thử";
            this.btnThiThu.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(297, 256);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(75, 23);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 380);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThiThu);
            this.Controls.Add(this.btnDGop);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.btnTTSV);
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học sinh";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTTSV;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.Button btnDGop;
        private System.Windows.Forms.Button btnThiThu;
        private System.Windows.Forms.Button btnDangXuat;
    }
}