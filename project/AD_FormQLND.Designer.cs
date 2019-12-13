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
            this.components = new System.ComponentModel.Container();
            this.btnGV = new System.Windows.Forms.Button();
            this.btnHS = new System.Windows.Forms.Button();
            this.btnND = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnMenu.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGV
            // 
            this.btnGV.Location = new System.Drawing.Point(6, 113);
            this.btnGV.Name = "btnGV";
            this.btnGV.Size = new System.Drawing.Size(100, 70);
            this.btnGV.TabIndex = 0;
            this.btnGV.Text = "Giáo viên";
            this.btnGV.UseVisualStyleBackColor = true;
            this.btnGV.Click += new System.EventHandler(this.btnGV_Click);
            // 
            // btnHS
            // 
            this.btnHS.Location = new System.Drawing.Point(6, 189);
            this.btnHS.Name = "btnHS";
            this.btnHS.Size = new System.Drawing.Size(100, 70);
            this.btnHS.TabIndex = 0;
            this.btnHS.Text = "Học sinh";
            this.btnHS.UseVisualStyleBackColor = true;
            this.btnHS.Click += new System.EventHandler(this.btnHS_Click);
            // 
            // btnND
            // 
            this.btnND.Location = new System.Drawing.Point(6, 37);
            this.btnND.Name = "btnND";
            this.btnND.Size = new System.Drawing.Size(100, 70);
            this.btnND.TabIndex = 0;
            this.btnND.Text = "Người dùng";
            this.btnND.UseVisualStyleBackColor = true;
            this.btnND.Click += new System.EventHandler(this.btnND_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.groupBox1);
            this.pnMenu.ForeColor = System.Drawing.Color.Black;
            this.pnMenu.Location = new System.Drawing.Point(12, 12);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(124, 399);
            this.pnMenu.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.label1);
            this.pnBody.Location = new System.Drawing.Point(142, 12);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1017, 399);
            this.pnBody.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnND);
            this.groupBox1.Controls.Add(this.btnGV);
            this.groupBox1.Controls.Add(this.btnHS);
            this.groupBox1.Location = new System.Drawing.Point(3, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 274);
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
            this.label1.TabIndex = 0;
            this.label1.Text = "<== Chọn Menu";
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
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGV;
        private System.Windows.Forms.Button btnHS;
        private System.Windows.Forms.Button btnND;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}