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
            this.crytal_View_BangDiem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crytal_View_BangDiem
            // 
            this.crytal_View_BangDiem.ActiveViewIndex = -1;
            this.crytal_View_BangDiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crytal_View_BangDiem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crytal_View_BangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crytal_View_BangDiem.Location = new System.Drawing.Point(0, 0);
            this.crytal_View_BangDiem.Name = "crytal_View_BangDiem";
            this.crytal_View_BangDiem.ShowGroupTreeButton = false;
            this.crytal_View_BangDiem.ShowLogo = false;
            this.crytal_View_BangDiem.Size = new System.Drawing.Size(751, 423);
            this.crytal_View_BangDiem.TabIndex = 0;
            this.crytal_View_BangDiem.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmHS_BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 423);
            this.Controls.Add(this.crytal_View_BangDiem);
            this.Name = "frmHS_BangDiem";
            this.Text = "frmHS_BangDiem";
            this.Load += new System.EventHandler(this.frmHS_BangDiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crytal_View_BangDiem;
    }
}