namespace project
{
    partial class frmHS_BangDiem
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
            this.SuspendLayout();
            // 
            // rptView
            // 
            this.rptView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptView.Location = new System.Drawing.Point(0, 0);
            this.rptView.Name = "rptView";
            this.rptView.Size = new System.Drawing.Size(737, 433);
            this.rptView.TabIndex = 8;
            // 
            // frmHS_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 433);
            this.Controls.Add(this.rptView);
            this.Name = "frmHS_BangDiem";
            this.Text = "frmHS_BangDiem";
            this.Load += new System.EventHandler(this.frmHS_BangDiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptView;
    }
}