namespace project
{
    partial class GV_TaoDeThi
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DoKhoch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.DoKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.CauHoi1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvListQuestions = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMaKhoi = new System.Windows.Forms.ComboBox();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(211, 80);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 35);
            this.btnCreate.TabIndex = 35;
            this.btnCreate.Text = "Tạo đề";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(832, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Đề thi";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(620, 419);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 35);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Xóa câu hỏi";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(153, 419);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 35);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Thêm vào đề thi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Danh sách câu hỏi";
            // 
            // DoKhoch
            // 
            this.DoKhoch.DataPropertyName = "DoKho";
            this.DoKhoch.HeaderText = "Độ khó";
            this.DoKhoch.Name = "DoKhoch";
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi1";
            this.CauHoi.HeaderText = "Câu hỏi";
            this.CauHoi.Name = "CauHoi";
            // 
            // IDch
            // 
            this.IDch.DataPropertyName = "ID_CauHoi";
            this.IDch.HeaderText = "ID";
            this.IDch.Name = "IDch";
            // 
            // dgvExam
            // 
            this.dgvExam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDch,
            this.CauHoi,
            this.DoKhoch});
            this.dgvExam.Location = new System.Drawing.Point(511, 147);
            this.dgvExam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.Size = new System.Drawing.Size(432, 267);
            this.dgvExam.TabIndex = 29;
            // 
            // DoKho
            // 
            this.DoKho.DataPropertyName = "DoKho";
            this.DoKho.HeaderText = "Độ khó";
            this.DoKho.Name = "DoKho";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(755, 419);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 35);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Lưu đề thi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CauHoi1
            // 
            this.CauHoi1.DataPropertyName = "CauHoi1";
            this.CauHoi1.HeaderText = "Câu hỏi";
            this.CauHoi1.Name = "CauHoi1";
            // 
            // dgvListQuestions
            // 
            this.dgvListQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CauHoi1,
            this.DoKho});
            this.dgvListQuestions.Location = new System.Drawing.Point(11, 144);
            this.dgvListQuestions.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListQuestions.Name = "dgvListQuestions";
            this.dgvListQuestions.Size = new System.Drawing.Size(471, 270);
            this.dgvListQuestions.TabIndex = 28;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // cbMaKhoi
            // 
            this.cbMaKhoi.FormattingEnabled = true;
            this.cbMaKhoi.Location = new System.Drawing.Point(82, 106);
            this.cbMaKhoi.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaKhoi.Name = "cbMaKhoi";
            this.cbMaKhoi.Size = new System.Drawing.Size(95, 21);
            this.cbMaKhoi.TabIndex = 27;
            // 
            // cbMaMH
            // 
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(82, 77);
            this.cbMaMH.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(95, 21);
            this.cbMaMH.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tạo đề thi";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(82, 44);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(79, 20);
            this.txtTen.TabIndex = 24;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(82, 8);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 23;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã khối:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên đề thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID đề:";
            // 
            // GV_TaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 497);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvExam);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvListQuestions);
            this.Controls.Add(this.cbMaKhoi);
            this.Controls.Add(this.cbMaMH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GV_TaoDeThi";
            this.Text = "GV_TaoDeThi";
            this.Load += new System.EventHandler(this.GV_TaoDeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoKhoch;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDch;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoKho;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi1;
        private System.Windows.Forms.DataGridView dgvListQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.ComboBox cbMaKhoi;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}