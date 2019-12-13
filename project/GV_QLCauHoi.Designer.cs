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
            this.btnSuaCH = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.AllowUserToAddRows = false;
            this.dgvCauHoi.AllowUserToDeleteRows = false;
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
            this.dgvCauHoi.Size = new System.Drawing.Size(922, 217);
            this.dgvCauHoi.TabIndex = 0;
            this.dgvCauHoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCauHoi_CellContentClick);
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
            this.btnSuaCH.Location = new System.Drawing.Point(26, 236);
            this.btnSuaCH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.Size = new System.Drawing.Size(127, 41);
            this.btnSuaCH.TabIndex = 1;
            this.btnSuaCH.Text = "Sửa ";
            this.btnSuaCH.UseVisualStyleBackColor = true;
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(571, 236);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(180, 236);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(127, 41);
            this.btnViewDetails.TabIndex = 3;
            this.btnViewDetails.Text = "Chi tiết câu hỏi";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(436, 236);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(127, 41);
            this.btnInsert.TabIndex = 4;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // GV_QLCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(922, 375);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSuaCH);
            this.Controls.Add(this.dgvCauHoi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GV_QLCauHoi";
            this.Text = "GV_QLCauHoi";
            this.Load += new System.EventHandler(this.GV_QLCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.Button btnSuaCH;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnInsert;
    }
}