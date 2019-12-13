namespace project
{
    partial class AD_FormQLND
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
            this.btnND = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnGV = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnND
            // 
            this.btnND.Location = new System.Drawing.Point(13, 43);
            this.btnND.Name = "btnND";
            this.btnND.Size = new System.Drawing.Size(100, 70);
            this.btnND.TabIndex = 0;
            this.btnND.Text = "Người dùng";
            this.btnND.UseVisualStyleBackColor = true;
            this.btnND.Click += new System.EventHandler(this.btnND_Click);
            // 
            // btnHS
            // 
            this.btnHS.Location = new System.Drawing.Point(13, 119);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(100, 70);
            this.btnHS.TabIndex = 0;
            this.btnHS.Text = "Học sinh";
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(13, 195);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(100, 70);
            this.btnGV.TabIndex = 0;
            this.btnGV.Text = "Giáo viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnND);
            this.pnMenu.Controls.Add(this.btnGV);
            this.pnMenu.Controls.Add(this.btnHS);
            this.pnMenu.ForeColor = System.Drawing.Color.Black;
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(124, 399);
            this.pnMenu.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Location = new System.Drawing.Point(142, 12);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1017, 399);
            this.pnBody.TabIndex = 2;
            // 
            // AD_FormQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 431);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AD_FormQLND";
            this.Text = "AD_FormQLND";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnND;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnBody;
    }
}