namespace project
{
    partial class frmAdmin
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
            this.pnFooter = new System.Windows.Forms.Panel();
            this.btnQLND = new System.Windows.Forms.Button();
            this.btnQLHT = new System.Windows.Forms.Button();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFooter
            // 
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 74);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(1151, 351);
            this.pnFooter.TabIndex = 4;
            // 
            // btnQLND
            // 
            this.btnQLND.Location = new System.Drawing.Point(12, 12);
            this.btnQLND.Name = "btnQLND";
            this.btnQLND.Size = new System.Drawing.Size(274, 45);
            this.btnQLND.TabIndex = 0;
            this.btnQLND.Text = "Quản lí người dùng";
            this.btnQLND.UseVisualStyleBackColor = true;
            this.btnQLND.Click += new System.EventHandler(this.btnQLND_Click);
            // 
            // btnQLHT
            // 
            this.btnQLHT.Location = new System.Drawing.Point(292, 12);
            this.btnQLHT.Name = "btnQLHT";
            this.btnQLHT.Size = new System.Drawing.Size(274, 45);
            this.btnQLHT.TabIndex = 0;
            this.btnQLHT.Text = "Quản lí hệ thống";
            this.btnQLHT.UseVisualStyleBackColor = true;
            this.btnQLHT.Click += new System.EventHandler(this.btnQLHT_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnHeader.Controls.Add(this.btnQLND);
            this.pnHeader.Controls.Add(this.btnQLHT);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1151, 68);
            this.pnHeader.TabIndex = 3;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 425);
            this.Controls.Add(this.pnFooter);
            this.Controls.Add(this.pnHeader);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.pnHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnFooter;
        private System.Windows.Forms.Button btnQLND;
        private System.Windows.Forms.Button btnQLHT;
        private System.Windows.Forms.Panel pnHeader;
    }
}