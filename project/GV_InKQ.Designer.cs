namespace project
{
    partial class GV_InKQ
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
            this.rptView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.cbMaKyThi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rptView
            // 
            this.rptView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptView.Location = new System.Drawing.Point(0, 50);
            this.rptView.Name = "rptView";
            this.rptView.Size = new System.Drawing.Size(737, 383);
            this.rptView.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã kỳ thi";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(571, 8);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(98, 37);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cbMaKyThi
            // 
            this.cbMaKyThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKyThi.FormattingEnabled = true;
            this.cbMaKyThi.Location = new System.Drawing.Point(96, 13);
            this.cbMaKyThi.Name = "cbMaKyThi";
            this.cbMaKyThi.Size = new System.Drawing.Size(121, 26);
            this.cbMaKyThi.TabIndex = 5;
            // 
            // GV_InKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.rptView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.cbMaKyThi);
            this.Name = "GV_InKQ";
            this.Text = "GV_InKQ";
            this.Load += new System.EventHandler(this.GV_InKQ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cbMaKyThi;
    }
}