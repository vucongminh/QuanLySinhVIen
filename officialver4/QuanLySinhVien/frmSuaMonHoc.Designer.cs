namespace QuanLySinhVien
{
    partial class frmSuaMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTrinh = new System.Windows.Forms.TextBox();
            this.txtMaBoMon = new System.Windows.Forms.TextBox();
            this.txtTenMonHoc = new System.Windows.Forms.TextBox();
            this.txtMaMonHoc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HỌC PHẦN CẦN SỬA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoTrinh);
            this.groupBox1.Controls.Add(this.txtMaBoMon);
            this.groupBox1.Controls.Add(this.txtTenMonHoc);
            this.groupBox1.Controls.Add(this.txtMaMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 194);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(115, 231);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(83, 31);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(214, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(116, 119);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(154, 20);
            this.txtHocKy.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Học Kỳ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Bộ Môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Tín Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã Môn Học:";
            // 
            // txtSoTrinh
            // 
            this.txtSoTrinh.Location = new System.Drawing.Point(116, 82);
            this.txtSoTrinh.Name = "txtSoTrinh";
            this.txtSoTrinh.Size = new System.Drawing.Size(154, 20);
            this.txtSoTrinh.TabIndex = 2;
            // 
            // txtMaBoMon
            // 
            this.txtMaBoMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMaBoMon.Location = new System.Drawing.Point(116, 156);
            this.txtMaBoMon.Name = "txtMaBoMon";
            this.txtMaBoMon.Size = new System.Drawing.Size(154, 20);
            this.txtMaBoMon.TabIndex = 4;
            // 
            // txtTenMonHoc
            // 
            this.txtTenMonHoc.Location = new System.Drawing.Point(116, 47);
            this.txtTenMonHoc.Name = "txtTenMonHoc";
            this.txtTenMonHoc.Size = new System.Drawing.Size(154, 20);
            this.txtTenMonHoc.TabIndex = 1;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtMaMonHoc.Location = new System.Drawing.Point(116, 10);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(154, 20);
            this.txtMaMonHoc.TabIndex = 0;
            // 
            // frmSuaMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSuaMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Học Phần";
            this.Load += new System.EventHandler(this.frmSuaMonHoc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoTrinh;
        private System.Windows.Forms.TextBox txtMaBoMon;
        private System.Windows.Forms.TextBox txtTenMonHoc;
        private System.Windows.Forms.TextBox txtMaMonHoc;
    }
}