namespace project
{
    partial class AD_FormSL
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRT = new System.Windows.Forms.Button();
            this.cbSV = new System.Windows.Forms.ComboBox();
            this.btnBrowseRT = new System.Windows.Forms.Button();
            this.txtDDanRT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBU = new System.Windows.Forms.Button();
            this.btnBrowseBU = new System.Windows.Forms.Button();
            this.cbDBBU = new System.Windows.Forms.ComboBox();
            this.txtDDanBU = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDBRT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRT);
            this.groupBox3.Controls.Add(this.cbDBRT);
            this.groupBox3.Controls.Add(this.cbSV);
            this.groupBox3.Controls.Add(this.btnBrowseRT);
            this.groupBox3.Controls.Add(this.txtDDanRT);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(159, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 160);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Khôi phục database";
            // 
            // btnRT
            // 
            this.btnRT.Location = new System.Drawing.Point(150, 120);
            this.btnRT.Name = "btnRT";
            this.btnRT.Size = new System.Drawing.Size(134, 23);
            this.btnRT.TabIndex = 5;
            this.btnRT.Text = "Khôi phục";
            this.btnRT.UseVisualStyleBackColor = true;
            this.btnRT.Click += new System.EventHandler(this.btnRT_Click);
            // 
            // cbSV
            // 
            this.cbSV.FormattingEnabled = true;
            this.cbSV.Location = new System.Drawing.Point(134, 82);
            this.cbSV.Name = "cbSV";
            this.cbSV.Size = new System.Drawing.Size(210, 21);
            this.cbSV.TabIndex = 3;
            // 
            // btnBrowseRT
            // 
            this.btnBrowseRT.Location = new System.Drawing.Point(350, 24);
            this.btnBrowseRT.Name = "btnBrowseRT";
            this.btnBrowseRT.Size = new System.Drawing.Size(65, 23);
            this.btnBrowseRT.TabIndex = 4;
            this.btnBrowseRT.Text = "Browse...";
            this.btnBrowseRT.UseVisualStyleBackColor = true;
            this.btnBrowseRT.Click += new System.EventHandler(this.btnBrowseRT_Click);
            // 
            // txtDDanRT
            // 
            this.txtDDanRT.Location = new System.Drawing.Point(134, 26);
            this.txtDDanRT.Name = "txtDDanRT";
            this.txtDDanRT.Size = new System.Drawing.Size(210, 20);
            this.txtDDanRT.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đường dẫn khôi phục:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Database:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBU);
            this.groupBox2.Controls.Add(this.btnBrowseBU);
            this.groupBox2.Controls.Add(this.cbDBBU);
            this.groupBox2.Controls.Add(this.txtDDanBU);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(159, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sao lưu database";
            // 
            // btnBU
            // 
            this.btnBU.Location = new System.Drawing.Point(150, 90);
            this.btnBU.Name = "btnBU";
            this.btnBU.Size = new System.Drawing.Size(134, 23);
            this.btnBU.TabIndex = 5;
            this.btnBU.Text = "Sao Lưu";
            this.btnBU.UseVisualStyleBackColor = true;
            this.btnBU.Click += new System.EventHandler(this.btnBU_Click);
            // 
            // btnBrowseBU
            // 
            this.btnBrowseBU.Location = new System.Drawing.Point(350, 30);
            this.btnBrowseBU.Name = "btnBrowseBU";
            this.btnBrowseBU.Size = new System.Drawing.Size(65, 23);
            this.btnBrowseBU.TabIndex = 4;
            this.btnBrowseBU.Text = "Browse...";
            this.btnBrowseBU.UseVisualStyleBackColor = true;
            this.btnBrowseBU.Click += new System.EventHandler(this.btnBrowseBU_Click);
            // 
            // cbDBBU
            // 
            this.cbDBBU.FormattingEnabled = true;
            this.cbDBBU.Location = new System.Drawing.Point(121, 62);
            this.cbDBBU.Name = "cbDBBU";
            this.cbDBBU.Size = new System.Drawing.Size(223, 21);
            this.cbDBBU.TabIndex = 3;
            // 
            // txtDDanBU
            // 
            this.txtDDanBU.Location = new System.Drawing.Point(121, 32);
            this.txtDDanBU.Name = "txtDDanBU";
            this.txtDDanBU.Size = new System.Drawing.Size(223, 20);
            this.txtDDanBU.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Database:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đường dẫn sao lưu:";
            // 
            // cbDBRT
            // 
            this.cbDBRT.FormattingEnabled = true;
            this.cbDBRT.Location = new System.Drawing.Point(134, 55);
            this.cbDBRT.Name = "cbDBRT";
            this.cbDBRT.Size = new System.Drawing.Size(210, 21);
            this.cbDBRT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sao lưu, phục hồi database";
            // 
            // AD_FormSL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AD_FormSL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD_FormSL";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRT;
        private System.Windows.Forms.ComboBox cbSV;
        private System.Windows.Forms.Button btnBrowseRT;
        private System.Windows.Forms.TextBox txtDDanRT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBU;
        private System.Windows.Forms.Button btnBrowseBU;
        private System.Windows.Forms.ComboBox cbDBBU;
        private System.Windows.Forms.TextBox txtDDanBU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDBRT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}