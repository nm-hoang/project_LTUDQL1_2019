namespace project
{
    partial class GV_QLCauHoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GV_QLCauHoi));
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAnDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuaCH = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnViewDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnInsert = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.AllowUserToAddRows = false;
            this.dgvCauHoi.AllowUserToDeleteRows = false;
            this.dgvCauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CauHoi1,
            this.DapAn_A,
            this.DapAn_B,
            this.DapAn_C,
            this.DapAn_D,
            this.DapAnDung,
            this.Khoi,
            this.DoKho,
            this.MaMH});
            this.dgvCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCauHoi.Location = new System.Drawing.Point(0, 0);
            this.dgvCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.ReadOnly = true;
            this.dgvCauHoi.RowTemplate.Height = 40;
            this.dgvCauHoi.Size = new System.Drawing.Size(753, 217);
            this.dgvCauHoi.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // CauHoi1
            // 
            this.CauHoi1.DataPropertyName = "CauHoi1";
            this.CauHoi1.HeaderText = "Câu hỏi";
            this.CauHoi1.Name = "CauHoi1";
            this.CauHoi1.ReadOnly = true;
            // 
            // DapAn_A
            // 
            this.DapAn_A.DataPropertyName = "DapAn_A";
            this.DapAn_A.HeaderText = "Đáp án A";
            this.DapAn_A.Name = "DapAn_A";
            this.DapAn_A.ReadOnly = true;
            // 
            // DapAn_B
            // 
            this.DapAn_B.DataPropertyName = "DapAn_B";
            this.DapAn_B.HeaderText = "Đáp án B";
            this.DapAn_B.Name = "DapAn_B";
            this.DapAn_B.ReadOnly = true;
            // 
            // DapAn_C
            // 
            this.DapAn_C.DataPropertyName = "DapAn_C";
            this.DapAn_C.HeaderText = "Đáp án C";
            this.DapAn_C.Name = "DapAn_C";
            this.DapAn_C.ReadOnly = true;
            // 
            // DapAn_D
            // 
            this.DapAn_D.DataPropertyName = "DapAn_D";
            this.DapAn_D.HeaderText = "Đáp án D";
            this.DapAn_D.Name = "DapAn_D";
            this.DapAn_D.ReadOnly = true;
            // 
            // DapAnDung
            // 
            this.DapAnDung.DataPropertyName = "DapAnDung";
            this.DapAnDung.HeaderText = "Đáp án đúng";
            this.DapAnDung.Name = "DapAnDung";
            this.DapAnDung.ReadOnly = true;
            // 
            // Khoi
            // 
            this.Khoi.DataPropertyName = "Khoi";
            this.Khoi.HeaderText = "Khối";
            this.Khoi.Name = "Khoi";
            this.Khoi.ReadOnly = true;
            // 
            // DoKho
            // 
            this.DoKho.DataPropertyName = "DoKho";
            this.DoKho.HeaderText = "Độ khó";
            this.DoKho.Name = "DoKho";
            this.DoKho.ReadOnly = true;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã MH";
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            // 
            // btnSuaCH
            // 
            this.btnSuaCH.ActiveBorderThickness = 1;
            this.btnSuaCH.ActiveCornerRadius = 20;
            this.btnSuaCH.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSuaCH.ActiveForecolor = System.Drawing.Color.White;
            this.btnSuaCH.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSuaCH.BackColor = System.Drawing.SystemColors.Control;
            this.btnSuaCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCH.BackgroundImage")));
            this.btnSuaCH.ButtonText = "Sửa câu hỏi ";
            this.btnSuaCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaCH.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaCH.ForeColor = System.Drawing.Color.Honeydew;
            this.btnSuaCH.IdleBorderThickness = 1;
            this.btnSuaCH.IdleCornerRadius = 20;
            this.btnSuaCH.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnSuaCH.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSuaCH.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSuaCH.Location = new System.Drawing.Point(29, 250);
            this.btnSuaCH.Margin = new System.Windows.Forms.Padding(5);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.Size = new System.Drawing.Size(181, 41);
            this.btnSuaCH.TabIndex = 28;
            this.btnSuaCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.ActiveBorderThickness = 1;
            this.btnViewDetails.ActiveCornerRadius = 20;
            this.btnViewDetails.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnViewDetails.ActiveForecolor = System.Drawing.Color.White;
            this.btnViewDetails.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnViewDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewDetails.BackgroundImage")));
            this.btnViewDetails.ButtonText = "Chi tiết câu hỏi";
            this.btnViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetails.ForeColor = System.Drawing.Color.Honeydew;
            this.btnViewDetails.IdleBorderThickness = 1;
            this.btnViewDetails.IdleCornerRadius = 20;
            this.btnViewDetails.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnViewDetails.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnViewDetails.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnViewDetails.Location = new System.Drawing.Point(29, 301);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(5);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(181, 41);
            this.btnViewDetails.TabIndex = 29;
            this.btnViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.ActiveBorderThickness = 1;
            this.btnInsert.ActiveCornerRadius = 20;
            this.btnInsert.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.ActiveForecolor = System.Drawing.Color.White;
            this.btnInsert.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.BackColor = System.Drawing.SystemColors.Control;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.ButtonText = "Thêm câu hỏi";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Honeydew;
            this.btnInsert.IdleBorderThickness = 1;
            this.btnInsert.IdleCornerRadius = 20;
            this.btnInsert.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnInsert.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnInsert.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnInsert.Location = new System.Drawing.Point(290, 275);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(181, 41);
            this.btnInsert.TabIndex = 30;
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnExport
            // 
            this.btnExport.ActiveBorderThickness = 1;
            this.btnExport.ActiveCornerRadius = 20;
            this.btnExport.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnExport.ActiveForecolor = System.Drawing.Color.White;
            this.btnExport.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnExport.BackColor = System.Drawing.SystemColors.Control;
            this.btnExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExport.BackgroundImage")));
            this.btnExport.ButtonText = "Xuất danh sánh câu hỏi";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Honeydew;
            this.btnExport.IdleBorderThickness = 1;
            this.btnExport.IdleCornerRadius = 20;
            this.btnExport.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnExport.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnExport.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnExport.Location = new System.Drawing.Point(510, 275);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(208, 41);
            this.btnExport.TabIndex = 32;
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Xóa câu hỏi";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Honeydew;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(80)))), ((int)(((byte)(65)))));
            this.btnDelete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.Location = new System.Drawing.Point(14, 352);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(208, 41);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GV_QLCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 404);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnSuaCH);
            this.Controls.Add(this.dgvCauHoi);
            this.Name = "GV_QLCauHoi";
            this.Text = "GV_QLCauHoi";
            this.Load += new System.EventHandler(this.GV_QLCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAnDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSuaCH;
        private Bunifu.Framework.UI.BunifuThinButton2 btnViewDetails;
        private Bunifu.Framework.UI.BunifuThinButton2 btnInsert;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExport;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
    }
}