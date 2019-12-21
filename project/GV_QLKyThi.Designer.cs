namespace project
{
    partial class GV_QLKyThi
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
            this.dgvKyThi = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThiSinh = new System.Windows.Forms.DataGridView();
            this.MaKiThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDSTS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKyThi
            // 
            this.dgvKyThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NgayThi,
            this.MaDe,
            this.SuDung});
            this.dgvKyThi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvKyThi.Location = new System.Drawing.Point(12, 79);
            this.dgvKyThi.Name = "dgvKyThi";
            this.dgvKyThi.Size = new System.Drawing.Size(400, 279);
            this.dgvKyThi.TabIndex = 9;
            this.dgvKyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyThi_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // NgayThi
            // 
            this.NgayThi.DataPropertyName = "NgayThi";
            this.NgayThi.HeaderText = "Ngày thi";
            this.NgayThi.Name = "NgayThi";
            // 
            // MaDe
            // 
            this.MaDe.DataPropertyName = "MaDe";
            this.MaDe.HeaderText = "Mã đề";
            this.MaDe.Name = "MaDe";
            // 
            // SuDung
            // 
            this.SuDung.DataPropertyName = "SuDung";
            this.SuDung.HeaderText = "Sử dụng";
            this.SuDung.Name = "SuDung";
            // 
            // dgvThiSinh
            // 
            this.dgvThiSinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThiSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThiSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKiThi,
            this.MaHS,
            this.ID_Account});
            this.dgvThiSinh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvThiSinh.Location = new System.Drawing.Point(418, 79);
            this.dgvThiSinh.Name = "dgvThiSinh";
            this.dgvThiSinh.Size = new System.Drawing.Size(381, 279);
            this.dgvThiSinh.TabIndex = 10;
            // 
            // MaKiThi
            // 
            this.MaKiThi.DataPropertyName = "MaKiThi";
            this.MaKiThi.HeaderText = "Mã Kỳ thi";
            this.MaKiThi.Name = "MaKiThi";
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            // 
            // ID_Account
            // 
            this.ID_Account.DataPropertyName = "ID_Account";
            this.ID_Account.HeaderText = "Id tài khoản";
            this.ID_Account.Name = "ID_Account";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(266, 381);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 35);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(164, 381);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Teal;
            this.btnRefresh.Location = new System.Drawing.Point(32, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 35);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(70, 381);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(76, 35);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Tạo kỳ thi";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Danh sách thí sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách kỳ thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kỳ thi";
            // 
            // btnDSTS
            // 
            this.btnDSTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSTS.ForeColor = System.Drawing.Color.Black;
            this.btnDSTS.Location = new System.Drawing.Point(528, 381);
            this.btnDSTS.Name = "btnDSTS";
            this.btnDSTS.Size = new System.Drawing.Size(170, 35);
            this.btnDSTS.TabIndex = 18;
            this.btnDSTS.Text = "In danh sách thí sinh";
            this.btnDSTS.UseVisualStyleBackColor = true;
            this.btnDSTS.Click += new System.EventHandler(this.btnDSTS_Click);
            // 
            // GV_QLKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 426);
            this.Controls.Add(this.btnDSTS);
            this.Controls.Add(this.dgvKyThi);
            this.Controls.Add(this.dgvThiSinh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GV_QLKyThi";
            this.Text = "GV_QLKyThi";
            this.Load += new System.EventHandler(this.GV_QLKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiSinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuDung;
        private System.Windows.Forms.DataGridView dgvThiSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKiThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Account;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDSTS;
    }
}