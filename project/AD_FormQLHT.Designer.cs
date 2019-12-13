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
            this.btnSaoLuu = new System.Windows.Forms.Button();
            this.btnThietLap = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Location = new System.Drawing.Point(18, 115);
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.Size = new System.Drawing.Size(149, 66);
            this.btnSaoLuu.TabIndex = 0;
            this.btnSaoLuu.Text = "Sao lưu, phục hồi database";
            this.btnSaoLuu.UseVisualStyleBackColor = true;
            this.btnSaoLuu.Click += new System.EventHandler(this.btnSaoLuu_Click);
            
            // 
            // btnThietLap
            // 
            this.btnThietLap.Location = new System.Drawing.Point(18, 33);
            this.btnThietLap.Name = "btnThietLap";
            this.btnThietLap.Size = new System.Drawing.Size(150, 66);
            this.btnThietLap.TabIndex = 0;
            this.btnThietLap.Text = "Thiết lập database";
            this.btnThietLap.UseVisualStyleBackColor = true;
            this.btnThietLap.Click += new System.EventHandler(this.btnThietLap_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.groupBox1);
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(214, 399);
            this.pnMenu.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Location = new System.Drawing.Point(232, 12);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1017, 399);
            this.pnBody.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThietLap);
            this.groupBox1.Controls.Add(this.btnSaoLuu);
            this.groupBox1.Location = new System.Drawing.Point(16, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "<== Chọn Menu";
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
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaoLuu;
        private System.Windows.Forms.Button btnThietLap;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}