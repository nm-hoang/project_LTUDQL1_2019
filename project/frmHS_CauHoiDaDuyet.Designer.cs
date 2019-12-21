namespace project
{
    partial class frmHS_CauHoiDaDuyet
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.IDHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DapAn_D = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHS,
            this.CauHoi,
            this.DapAn_A,
            this.DapAn_B,
            this.DapAn_C,
            this.DapAn_D,
            this.KetQua,
            this.DoKho,
            this.MaMH});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(800, 261);
            this.dgv.TabIndex = 1;
            // 
            // IDHS
            // 
            this.IDHS.DataPropertyName = "IDHS";
            this.IDHS.HeaderText = "Mã học sinh";
            this.IDHS.Name = "IDHS";
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi";
            this.CauHoi.HeaderText = "Câu hỏi";
            this.CauHoi.Name = "CauHoi";
            // 
            // DapAn_A
            // 
            this.DapAn_A.DataPropertyName = "DapAn_A";
            this.DapAn_A.HeaderText = "Câu A";
            this.DapAn_A.Name = "DapAn_A";
            // 
            // DapAn_B
            // 
            this.DapAn_B.DataPropertyName = "DapAn_B";
            this.DapAn_B.HeaderText = "Câu B";
            this.DapAn_B.Name = "DapAn_B";
            // 
            // DapAn_C
            // 
            this.DapAn_C.DataPropertyName = "DapAn_C";
            this.DapAn_C.HeaderText = "Câu C";
            this.DapAn_C.Name = "DapAn_C";
            // 
            // DapAn_D
            // 
            this.DapAn_D.DataPropertyName = "DapAn_D";
            this.DapAn_D.HeaderText = "Câu D";
            this.DapAn_D.Name = "DapAn_D";
            // 
            // KetQua
            // 
            this.KetQua.DataPropertyName = "KetQua";
            this.KetQua.HeaderText = "Đáp án đúng";
            this.KetQua.Name = "KetQua";
            // 
            // DoKho
            // 
            this.DoKho.DataPropertyName = "DoKho";
            this.DoKho.HeaderText = "Độ khó";
            this.DoKho.Name = "DoKho";
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.Name = "MaMH";
            // 
            // frmHS_CauHoiDaDuyet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 261);
            this.Controls.Add(this.dgv);
            this.Name = "frmHS_CauHoiDaDuyet";
            this.Text = "frmHS_CauHoiDaDuyet";
            this.Load += new System.EventHandler(this.frmHS_CauHoiDaDuyet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_A;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_C;
        private System.Windows.Forms.DataGridViewTextBoxColumn DapAn_D;
        private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;

    }
}