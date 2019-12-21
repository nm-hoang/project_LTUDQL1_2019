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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            this.header = new System.Windows.Forms.Panel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnQLDeThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnQLKyThiThu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLHocSinh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLKyThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnQLCauHoi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Controls.Add(this.lblName);
            this.header.Controls.Add(this.bunifuCustomLabel1);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.bunifuImageButton2);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(433, 32);
            this.header.TabIndex = 22;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.lblName.Location = new System.Drawing.Point(96, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 21);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 21);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Trang chủ: ";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(394, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(789, 0);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(39, 32);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            // 
            // btnQLDeThi
            // 
            this.btnQLDeThi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLDeThi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLDeThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLDeThi.BorderRadius = 0;
            this.btnQLDeThi.ButtonText = "     Quản lý đề thi";
            this.btnQLDeThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDeThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLDeThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLDeThi.Iconimage = global::project.Properties.Resources.tải_xuống__2_;
            this.btnQLDeThi.Iconimage_right = null;
            this.btnQLDeThi.Iconimage_right_Selected = null;
            this.btnQLDeThi.Iconimage_Selected = null;
            this.btnQLDeThi.IconMarginLeft = 0;
            this.btnQLDeThi.IconMarginRight = 0;
            this.btnQLDeThi.IconRightVisible = true;
            this.btnQLDeThi.IconRightZoom = 0D;
            this.btnQLDeThi.IconVisible = true;
            this.btnQLDeThi.IconZoom = 90D;
            this.btnQLDeThi.IsTab = false;
            this.btnQLDeThi.Location = new System.Drawing.Point(21, 130);
            this.btnQLDeThi.Name = "btnQLDeThi";
            this.btnQLDeThi.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLDeThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLDeThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLDeThi.selected = false;
            this.btnQLDeThi.Size = new System.Drawing.Size(190, 45);
            this.btnQLDeThi.TabIndex = 28;
            this.btnQLDeThi.Text = "     Quản lý đề thi";
            this.btnQLDeThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDeThi.Textcolor = System.Drawing.Color.White;
            this.btnQLDeThi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDeThi.Click += new System.EventHandler(this.btnQLDeThi_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.ActiveBorderThickness = 1;
            this.btnLogOut.ActiveCornerRadius = 20;
            this.btnLogOut.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLogOut.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogOut.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.ButtonText = "Đăng xuất";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Honeydew;
            this.btnLogOut.IdleBorderThickness = 1;
            this.btnLogOut.IdleCornerRadius = 20;
            this.btnLogOut.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnLogOut.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnLogOut.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnLogOut.Location = new System.Drawing.Point(238, 184);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(181, 41);
            this.btnLogOut.TabIndex = 27;
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnQLKyThiThu
            // 
            this.btnQLKyThiThu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLKyThiThu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLKyThiThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLKyThiThu.BorderRadius = 0;
            this.btnQLKyThiThu.ButtonText = "    Quản lý kì thi thử";
            this.btnQLKyThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLKyThiThu.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLKyThiThu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLKyThiThu.Iconimage = global::project.Properties.Resources.tải_xuống__2_;
            this.btnQLKyThiThu.Iconimage_right = null;
            this.btnQLKyThiThu.Iconimage_right_Selected = null;
            this.btnQLKyThiThu.Iconimage_Selected = null;
            this.btnQLKyThiThu.IconMarginLeft = 0;
            this.btnQLKyThiThu.IconMarginRight = 0;
            this.btnQLKyThiThu.IconRightVisible = true;
            this.btnQLKyThiThu.IconRightZoom = 0D;
            this.btnQLKyThiThu.IconVisible = true;
            this.btnQLKyThiThu.IconZoom = 90D;
            this.btnQLKyThiThu.IsTab = false;
            this.btnQLKyThiThu.Location = new System.Drawing.Point(21, 359);
            this.btnQLKyThiThu.Name = "btnQLKyThiThu";
            this.btnQLKyThiThu.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLKyThiThu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLKyThiThu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLKyThiThu.selected = false;
            this.btnQLKyThiThu.Size = new System.Drawing.Size(190, 45);
            this.btnQLKyThiThu.TabIndex = 26;
            this.btnQLKyThiThu.Text = "    Quản lý kì thi thử";
            this.btnQLKyThiThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKyThiThu.Textcolor = System.Drawing.Color.White;
            this.btnQLKyThiThu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKyThiThu.Click += new System.EventHandler(this.btnQLKyThiThu_Click);
            // 
            // btnQLHocSinh
            // 
            this.btnQLHocSinh.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLHocSinh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLHocSinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLHocSinh.BorderRadius = 0;
            this.btnQLHocSinh.ButtonText = "     Quản lý học sinh";
            this.btnQLHocSinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLHocSinh.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLHocSinh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLHocSinh.Iconimage = global::project.Properties.Resources.images__1_;
            this.btnQLHocSinh.Iconimage_right = null;
            this.btnQLHocSinh.Iconimage_right_Selected = null;
            this.btnQLHocSinh.Iconimage_Selected = null;
            this.btnQLHocSinh.IconMarginLeft = 0;
            this.btnQLHocSinh.IconMarginRight = 0;
            this.btnQLHocSinh.IconRightVisible = true;
            this.btnQLHocSinh.IconRightZoom = 0D;
            this.btnQLHocSinh.IconVisible = true;
            this.btnQLHocSinh.IconZoom = 90D;
            this.btnQLHocSinh.IsTab = false;
            this.btnQLHocSinh.Location = new System.Drawing.Point(21, 283);
            this.btnQLHocSinh.Name = "btnQLHocSinh";
            this.btnQLHocSinh.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLHocSinh.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLHocSinh.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLHocSinh.selected = false;
            this.btnQLHocSinh.Size = new System.Drawing.Size(190, 45);
            this.btnQLHocSinh.TabIndex = 25;
            this.btnQLHocSinh.Text = "     Quản lý học sinh";
            this.btnQLHocSinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLHocSinh.Textcolor = System.Drawing.Color.White;
            this.btnQLHocSinh.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHocSinh.Click += new System.EventHandler(this.btnQLHocSinh_Click);
            // 
            // btnQLKyThi
            // 
            this.btnQLKyThi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLKyThi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLKyThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLKyThi.BorderRadius = 0;
            this.btnQLKyThi.ButtonText = "     Quản lý kì thi";
            this.btnQLKyThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLKyThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLKyThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLKyThi.Iconimage = global::project.Properties.Resources.tải_xuống__2_;
            this.btnQLKyThi.Iconimage_right = null;
            this.btnQLKyThi.Iconimage_right_Selected = null;
            this.btnQLKyThi.Iconimage_Selected = null;
            this.btnQLKyThi.IconMarginLeft = 0;
            this.btnQLKyThi.IconMarginRight = 0;
            this.btnQLKyThi.IconRightVisible = true;
            this.btnQLKyThi.IconRightZoom = 0D;
            this.btnQLKyThi.IconVisible = true;
            this.btnQLKyThi.IconZoom = 90D;
            this.btnQLKyThi.IsTab = false;
            this.btnQLKyThi.Location = new System.Drawing.Point(21, 202);
            this.btnQLKyThi.Name = "btnQLKyThi";
            this.btnQLKyThi.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLKyThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLKyThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLKyThi.selected = false;
            this.btnQLKyThi.Size = new System.Drawing.Size(190, 45);
            this.btnQLKyThi.TabIndex = 24;
            this.btnQLKyThi.Text = "     Quản lý kì thi";
            this.btnQLKyThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKyThi.Textcolor = System.Drawing.Color.White;
            this.btnQLKyThi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKyThi.Click += new System.EventHandler(this.btnQLKyThi_Click);
            // 
            // btnQLCauHoi
            // 
            this.btnQLCauHoi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLCauHoi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLCauHoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQLCauHoi.BorderRadius = 0;
            this.btnQLCauHoi.ButtonText = "     Quản lý câu hỏi";
            this.btnQLCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLCauHoi.DisabledColor = System.Drawing.Color.Gray;
            this.btnQLCauHoi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnQLCauHoi.Iconimage = global::project.Properties.Resources.image_question;
            this.btnQLCauHoi.Iconimage_right = null;
            this.btnQLCauHoi.Iconimage_right_Selected = null;
            this.btnQLCauHoi.Iconimage_Selected = null;
            this.btnQLCauHoi.IconMarginLeft = 0;
            this.btnQLCauHoi.IconMarginRight = 0;
            this.btnQLCauHoi.IconRightVisible = true;
            this.btnQLCauHoi.IconRightZoom = 0D;
            this.btnQLCauHoi.IconVisible = true;
            this.btnQLCauHoi.IconZoom = 90D;
            this.btnQLCauHoi.IsTab = false;
            this.btnQLCauHoi.Location = new System.Drawing.Point(21, 47);
            this.btnQLCauHoi.Name = "btnQLCauHoi";
            this.btnQLCauHoi.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnQLCauHoi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnQLCauHoi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnQLCauHoi.selected = false;
            this.btnQLCauHoi.Size = new System.Drawing.Size(190, 45);
            this.btnQLCauHoi.TabIndex = 23;
            this.btnQLCauHoi.Text = "     Quản lý câu hỏi";
            this.btnQLCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLCauHoi.Textcolor = System.Drawing.Color.White;
            this.btnQLCauHoi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLCauHoi.Click += new System.EventHandler(this.btnQLCauHoi_Click);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 416);
            this.Controls.Add(this.btnQLDeThi);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnQLKyThiThu);
            this.Controls.Add(this.btnQLHocSinh);
            this.Controls.Add(this.btnQLKyThi);
            this.Controls.Add(this.btnQLCauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaoVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaoVien";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogOut;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLKyThiThu;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLHocSinh;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLKyThi;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLCauHoi;
        private Bunifu.Framework.UI.BunifuFlatButton btnQLDeThi;
    }
}