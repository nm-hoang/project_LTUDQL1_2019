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
            this.btnSuaCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCauHoi.Location = new System.Drawing.Point(0, 0);
            this.dgvCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.RowTemplate.Height = 40;
            this.dgvCauHoi.Size = new System.Drawing.Size(744, 217);
            this.dgvCauHoi.TabIndex = 0;
            // 
            // btnSuaCH
            // 
            this.btnSuaCH.Location = new System.Drawing.Point(13, 251);
            this.btnSuaCH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaCH.Name = "btnSuaCH";
            this.btnSuaCH.Size = new System.Drawing.Size(127, 41);
            this.btnSuaCH.TabIndex = 1;
            this.btnSuaCH.Text = "Sửa câu hỏi";
            this.btnSuaCH.UseVisualStyleBackColor = true;
            this.btnSuaCH.Click += new System.EventHandler(this.btnSuaCH_Click);
            // 
            // GV_QLCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(744, 332);
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
    }
}