namespace project
{
    partial class GV_ThongKeCauHoi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaKyThi = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thống kê câu hỏi theo kì thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã kì thi";
            // 
            // cbMaKyThi
            // 
            this.cbMaKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKyThi.FormattingEnabled = true;
            this.cbMaKyThi.Location = new System.Drawing.Point(85, 55);
            this.cbMaKyThi.Name = "cbMaKyThi";
            this.cbMaKyThi.Size = new System.Drawing.Size(121, 28);
            this.cbMaKyThi.TabIndex = 5;
            this.cbMaKyThi.SelectedIndexChanged += new System.EventHandler(this.cbMaKyThi_SelectedIndexChanged);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CauHoi1,
            this.Khoi,
            this.DoKho,
            this.MaMH});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(0, 97);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(760, 254);
            this.dgv.TabIndex = 4;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // CauHoi1
            // 
            this.CauHoi1.DataPropertyName = "CauHoi1";
            this.CauHoi1.HeaderText = "Câu hỏi";
            this.CauHoi1.Name = "CauHoi1";
            // 
            // Khoi
            // 
            this.Khoi.DataPropertyName = "Khoi";
            this.Khoi.HeaderText = "Khối";
            this.Khoi.Name = "Khoi";
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
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.Color.Lime;
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Location = new System.Drawing.Point(660, 55);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 28);
            this.btnIN.TabIndex = 8;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // GV_ThongKeCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 351);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMaKyThi);
            this.Controls.Add(this.dgv);
            this.Name = "GV_ThongKeCauHoi";
            this.Text = "GV_ThongKeCauHoi";
            this.Load += new System.EventHandler(this.GV_ThongKeCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMaKyThi;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoKho;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.Button btnIN;
    }
}