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
            this.SuspendLayout();
            // 
            // btnND
            // 
            this.btnND.Location = new System.Drawing.Point(201, 46);
            this.btnND.Name = "btnND";
            this.btnND.Size = new System.Drawing.Size(199, 23);
            this.btnND.TabIndex = 0;
            this.btnND.Text = "Người dùng";
            this.btnND.UseVisualStyleBackColor = true;
            this.btnND.Click += new System.EventHandler(this.btnND_Click);
            // 
            // btnHS
            // 
            this.btnHS.Location = new System.Drawing.Point(201, 123);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(199, 23);
            this.btnHS.TabIndex = 0;
            this.btnHS.Text = "Học sinh";
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(201, 206);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(199, 23);
            this.btnGV.TabIndex = 0;
            this.btnGV.Text = "Giáo viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // AD_FormQLND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 293);
            this.Controls.Add(this.btnGV);
            this.Controls.Add(this.btnHS);
            this.Controls.Add(this.btnND);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AD_FormQLND";
            this.Text = "AD_FormQLND";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnND;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnGV;
    }
}