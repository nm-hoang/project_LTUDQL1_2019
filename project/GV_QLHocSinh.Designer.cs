namespace project
{
    partial class GV_QLHocSinh
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
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnKyThi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHoi.Location = new System.Drawing.Point(497, 143);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(157, 67);
            this.btnCauHoi.TabIndex = 7;
            this.btnCauHoi.Text = "Thống kê câu hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = true;
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.Location = new System.Drawing.Point(283, 143);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(161, 67);
            this.btnHocSinh.TabIndex = 6;
            this.btnHocSinh.Text = "Kết quả học sinh";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnKyThi
            // 
            this.btnKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyThi.Location = new System.Drawing.Point(67, 143);
            this.btnKyThi.Name = "btnKyThi";
            this.btnKyThi.Size = new System.Drawing.Size(171, 67);
            this.btnKyThi.TabIndex = 5;
            this.btnKyThi.Text = "Thống kê theo kỳ thi";
            this.btnKyThi.UseVisualStyleBackColor = true;
            this.btnKyThi.Click += new System.EventHandler(this.btnKyThi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quản lý học sinh";
            // 
            // GV_QLHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 252);
            this.Controls.Add(this.btnCauHoi);
            this.Controls.Add(this.btnHocSinh);
            this.Controls.Add(this.btnKyThi);
            this.Controls.Add(this.label1);
            this.Name = "GV_QLHocSinh";
            this.Text = "GV_QLHocSinh";
            this.Load += new System.EventHandler(this.GV_QLHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCauHoi;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnKyThi;
        private System.Windows.Forms.Label label1;
    }
}