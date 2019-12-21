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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKyThi = new System.Windows.Forms.Button();
            this.btnHocSinh = new System.Windows.Forms.Button();
            this.btnCauHoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý học sinh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnKyThi
            // 
            this.btnKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyThi.Location = new System.Drawing.Point(41, 109);
            this.btnKyThi.Name = "btnKyThi";
            this.btnKyThi.Size = new System.Drawing.Size(171, 67);
            this.btnKyThi.TabIndex = 1;
            this.btnKyThi.Text = "Thống kê theo kỳ thi";
            this.btnKyThi.UseVisualStyleBackColor = true;
            this.btnKyThi.Click += new System.EventHandler(this.btnKyThi_Click);
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHocSinh.Location = new System.Drawing.Point(257, 109);
            this.btnHocSinh.Name = "btnHocSinh";
            this.btnHocSinh.Size = new System.Drawing.Size(161, 67);
            this.btnHocSinh.TabIndex = 2;
            this.btnHocSinh.Text = "Thống kê học sinh";
            this.btnHocSinh.UseVisualStyleBackColor = true;
            this.btnHocSinh.Click += new System.EventHandler(this.btnHocSinh_Click);
            // 
            // btnCauHoi
            // 
            this.btnCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCauHoi.Location = new System.Drawing.Point(471, 109);
            this.btnCauHoi.Name = "btnCauHoi";
            this.btnCauHoi.Size = new System.Drawing.Size(157, 67);
            this.btnCauHoi.TabIndex = 3;
            this.btnCauHoi.Text = "Thống kê câu hỏi";
            this.btnCauHoi.UseVisualStyleBackColor = true;
            this.btnCauHoi.Click += new System.EventHandler(this.btnCauHoi_Click);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKyThi;
        private System.Windows.Forms.Button btnHocSinh;
        private System.Windows.Forms.Button btnCauHoi;
    }
}