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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            this.header = new System.Windows.Forms.Panel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDangXuat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDGop = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThiThu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTTSV = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.header.Size = new System.Drawing.Size(416, 32);
            this.header.TabIndex = 7;
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(377, 3);
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
            // btnDangXuat
            // 
            this.btnDangXuat.ActiveBorderThickness = 1;
            this.btnDangXuat.ActiveCornerRadius = 20;
            this.btnDangXuat.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.ActiveForecolor = System.Drawing.Color.White;
            this.btnDangXuat.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDangXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.BackgroundImage")));
            this.btnDangXuat.ButtonText = "Đăng xuất";
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Honeydew;
            this.btnDangXuat.IdleBorderThickness = 1;
            this.btnDangXuat.IdleCornerRadius = 20;
            this.btnDangXuat.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnDangXuat.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDangXuat.Location = new System.Drawing.Point(235, 156);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(5);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(181, 41);
            this.btnDangXuat.TabIndex = 21;
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDGop
            // 
            this.btnDGop.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDGop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDGop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDGop.BorderRadius = 0;
            this.btnDGop.ButtonText = "     Đóng góp câu hỏi";
            this.btnDGop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDGop.DisabledColor = System.Drawing.Color.Gray;
            this.btnDGop.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDGop.Iconimage = global::project.Properties.Resources.tải_xuống__3_;
            this.btnDGop.Iconimage_right = null;
            this.btnDGop.Iconimage_right_Selected = null;
            this.btnDGop.Iconimage_Selected = null;
            this.btnDGop.IconMarginLeft = 0;
            this.btnDGop.IconMarginRight = 0;
            this.btnDGop.IconRightVisible = true;
            this.btnDGop.IconRightZoom = 0D;
            this.btnDGop.IconVisible = true;
            this.btnDGop.IconZoom = 90D;
            this.btnDGop.IsTab = false;
            this.btnDGop.Location = new System.Drawing.Point(21, 279);
            this.btnDGop.Name = "btnDGop";
            this.btnDGop.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDGop.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDGop.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDGop.selected = false;
            this.btnDGop.Size = new System.Drawing.Size(190, 45);
            this.btnDGop.TabIndex = 11;
            this.btnDGop.Text = "     Đóng góp câu hỏi";
            this.btnDGop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDGop.Textcolor = System.Drawing.Color.White;
            this.btnDGop.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDGop.Click += new System.EventHandler(this.btnDGop_Click);
            // 
            // btnThiThu
            // 
            this.btnThiThu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThiThu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThiThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThiThu.BorderRadius = 0;
            this.btnThiThu.ButtonText = "     Làm bài thi thử";
            this.btnThiThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThiThu.DisabledColor = System.Drawing.Color.Gray;
            this.btnThiThu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThiThu.Iconimage = global::project.Properties.Resources.tải_xuống__2_;
            this.btnThiThu.Iconimage_right = null;
            this.btnThiThu.Iconimage_right_Selected = null;
            this.btnThiThu.Iconimage_Selected = null;
            this.btnThiThu.IconMarginLeft = 0;
            this.btnThiThu.IconMarginRight = 0;
            this.btnThiThu.IconRightVisible = true;
            this.btnThiThu.IconRightZoom = 0D;
            this.btnThiThu.IconVisible = true;
            this.btnThiThu.IconZoom = 90D;
            this.btnThiThu.IsTab = false;
            this.btnThiThu.Location = new System.Drawing.Point(21, 200);
            this.btnThiThu.Name = "btnThiThu";
            this.btnThiThu.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThiThu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThiThu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThiThu.selected = false;
            this.btnThiThu.Size = new System.Drawing.Size(190, 45);
            this.btnThiThu.TabIndex = 10;
            this.btnThiThu.Text = "     Làm bài thi thử";
            this.btnThiThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThiThu.Textcolor = System.Drawing.Color.White;
            this.btnThiThu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnThi
            // 
            this.btnThi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnThi.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThi.BorderRadius = 0;
            this.btnThi.ButtonText = "     Làm bài trắc nghiệm";
            this.btnThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThi.DisabledColor = System.Drawing.Color.Gray;
            this.btnThi.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThi.Iconimage = global::project.Properties.Resources.tải_xuống__2_;
            this.btnThi.Iconimage_right = null;
            this.btnThi.Iconimage_right_Selected = null;
            this.btnThi.Iconimage_Selected = null;
            this.btnThi.IconMarginLeft = 0;
            this.btnThi.IconMarginRight = 0;
            this.btnThi.IconRightVisible = true;
            this.btnThi.IconRightZoom = 0D;
            this.btnThi.IconVisible = true;
            this.btnThi.IconZoom = 90D;
            this.btnThi.IsTab = false;
            this.btnThi.Location = new System.Drawing.Point(21, 124);
            this.btnThi.Name = "btnThi";
            this.btnThi.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnThi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnThi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThi.selected = false;
            this.btnThi.Size = new System.Drawing.Size(190, 45);
            this.btnThi.TabIndex = 9;
            this.btnThi.Text = "     Làm bài trắc nghiệm";
            this.btnThi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThi.Textcolor = System.Drawing.Color.White;
            this.btnThi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnTTSV
            // 
            this.btnTTSV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTTSV.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTTSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTTSV.BorderRadius = 0;
            this.btnTTSV.ButtonText = "     Thông tin sinh viên";
            this.btnTTSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTSV.DisabledColor = System.Drawing.Color.Gray;
            this.btnTTSV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTTSV.Iconimage = global::project.Properties.Resources.images__1_;
            this.btnTTSV.Iconimage_right = null;
            this.btnTTSV.Iconimage_right_Selected = null;
            this.btnTTSV.Iconimage_Selected = null;
            this.btnTTSV.IconMarginLeft = 0;
            this.btnTTSV.IconMarginRight = 0;
            this.btnTTSV.IconRightVisible = true;
            this.btnTTSV.IconRightZoom = 0D;
            this.btnTTSV.IconVisible = true;
            this.btnTTSV.IconZoom = 90D;
            this.btnTTSV.IsTab = false;
            this.btnTTSV.Location = new System.Drawing.Point(21, 48);
            this.btnTTSV.Name = "btnTTSV";
            this.btnTTSV.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTTSV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTTSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTTSV.selected = false;
            this.btnTTSV.Size = new System.Drawing.Size(190, 45);
            this.btnTTSV.TabIndex = 8;
            this.btnTTSV.Text = "     Thông tin sinh viên";
            this.btnTTSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTTSV.Textcolor = System.Drawing.Color.White;
            this.btnTTSV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTTSV.Click += new System.EventHandler(this.btnTTSV_Click_1);
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(416, 380);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnDGop);
            this.Controls.Add(this.btnThiThu);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.btnTTSV);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học sinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnTTSV;
        private Bunifu.Framework.UI.BunifuFlatButton btnThi;
        private Bunifu.Framework.UI.BunifuFlatButton btnThiThu;
        private Bunifu.Framework.UI.BunifuFlatButton btnDGop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDangXuat;
    }
}