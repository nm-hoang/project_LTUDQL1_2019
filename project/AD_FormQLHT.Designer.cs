namespace project
{
    partial class AD_FormQLHT
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
            this.btnThietLap = new System.Windows.Forms.Button();
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThietLap
            // 
            this.btnThietLap.Location = new System.Drawing.Point(3, 86);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(199, 66);
            this.btnThietLap.TabIndex = 0;
            this.btnThietLap.Text = "Thiết lập kết nối database";
            this.btnThietLap.UseVisualStyleBackColor = true;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Location = new System.Drawing.Point(3, 159);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(199, 66);
            this.btnSaoLuu.TabIndex = 0;
            this.btnSaoLuu.Text = "Sao lưu, phục hồi database";
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnSaoLuu);
            this.pnMenu.Controls.Add(this.btnThietLap);
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(214, 399);
            this.pnMenu.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Location = new System.Drawing.Point(232, 12);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1017, 399);
            this.pnBody.TabIndex = 2;
            // 
            // AD_FormQLHT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 420);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AD_FormQLHT";
            this.Text = "AD_FormQLHT";
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnBody;
    }
}