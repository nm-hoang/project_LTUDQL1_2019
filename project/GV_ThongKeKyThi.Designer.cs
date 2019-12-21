namespace project
{
    partial class GV_ThongKeKyThi
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
            this.txtKem = new System.Windows.Forms.TextBox();
            this.txtYeu = new System.Windows.Forms.TextBox();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.txtKha = new System.Windows.Forms.TextBox();
            this.txtGioi = new System.Windows.Forms.TextBox();
            this.txtXuatSac = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKyThi
            // 
            this.dgvKyThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKyThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dgvKyThi.Location = new System.Drawing.Point(447, 116);
            this.dgvKyThi.Name = "dgvKyThi";
            this.dgvKyThi.Size = new System.Drawing.Size(561, 305);
            this.dgvKyThi.TabIndex = 40;
            this.dgvKyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKyThi_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // txtKem
            // 
            this.txtKem.Enabled = false;
            this.txtKem.Location = new System.Drawing.Point(208, 321);
            this.txtKem.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtKem.Name = "txtKem";
            this.txtKem.Size = new System.Drawing.Size(83, 20);
            this.txtKem.TabIndex = 39;
            this.txtKem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYeu
            // 
            this.txtYeu.Enabled = false;
            this.txtYeu.Location = new System.Drawing.Point(208, 285);
            this.txtYeu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtYeu.Name = "txtYeu";
            this.txtYeu.Size = new System.Drawing.Size(83, 20);
            this.txtYeu.TabIndex = 38;
            this.txtYeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTB
            // 
            this.txtTB.Enabled = false;
            this.txtTB.Location = new System.Drawing.Point(208, 243);
            this.txtTB.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(83, 20);
            this.txtTB.TabIndex = 37;
            this.txtTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKha
            // 
            this.txtKha.Enabled = false;
            this.txtKha.Location = new System.Drawing.Point(208, 207);
            this.txtKha.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtKha.Name = "txtKha";
            this.txtKha.Size = new System.Drawing.Size(83, 20);
            this.txtKha.TabIndex = 36;
            this.txtKha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGioi
            // 
            this.txtGioi.Enabled = false;
            this.txtGioi.Location = new System.Drawing.Point(208, 165);
            this.txtGioi.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtGioi.Name = "txtGioi";
            this.txtGioi.Size = new System.Drawing.Size(83, 20);
            this.txtGioi.TabIndex = 35;
            this.txtGioi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXuatSac
            // 
            this.txtXuatSac.Enabled = false;
            this.txtXuatSac.Location = new System.Drawing.Point(208, 129);
            this.txtXuatSac.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtXuatSac.Name = "txtXuatSac";
            this.txtXuatSac.Size = new System.Drawing.Size(83, 20);
            this.txtXuatSac.TabIndex = 34;
            this.txtXuatSac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Thống kê kì thi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 328);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Kém :(<3đ)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 285);
            this.label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Yếu :(>=3đ và <5đ )";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 247);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Trung Bình :(>=5đ và <6.5đ )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 210);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Khá :(>=6.5đ  và <8đ )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Giỏi :(>=8đ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Xuất sắc : (>=9đ)";
            // 
            // cbKyThi
            // 
            this.cbKyThi.FormattingEnabled = true;
            this.cbKyThi.Location = new System.Drawing.Point(730, 79);
            this.cbKyThi.Name = "cbKyThi";
            this.cbKyThi.Size = new System.Drawing.Size(198, 21);
            this.cbKyThi.TabIndex = 41;
            this.cbKyThi.SelectedIndexChanged += new System.EventHandler(this.cbKyThi_SelectedIndexChanged);
            // 
            // GV_ThongKeKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 436);
            this.Controls.Add(this.dgvKyThi);
            this.Controls.Add(this.txtKem);
            this.Controls.Add(this.txtYeu);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtKha);
            this.Controls.Add(this.txtGioi);
            this.Controls.Add(this.txtXuatSac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbKyThi);
            this.Name = "GV_ThongKeKyThi";
            this.Text = "GV_ThongKeKyThi";
            this.Load += new System.EventHandler(this.GV_ThongKeKyThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKyThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        public System.Windows.Forms.TextBox txtKem;
        public System.Windows.Forms.TextBox txtYeu;
        public System.Windows.Forms.TextBox txtTB;
        public System.Windows.Forms.TextBox txtKha;
        public System.Windows.Forms.TextBox txtGioi;
        public System.Windows.Forms.TextBox txtXuatSac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbKyThi;
    }
}