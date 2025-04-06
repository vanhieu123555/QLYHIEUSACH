namespace QuanLyHieuSach
{
    partial class frmThemKhachHang
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 90;
            this.label7.Text = "Mã KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 89;
            this.label6.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 88;
            this.label5.Text = "Số ĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Địa chỉ";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(189, 176);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(231, 22);
            this.txtDiaChi.TabIndex = 86;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(189, 216);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(231, 22);
            this.txtSDT.TabIndex = 85;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(189, 139);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(231, 22);
            this.txtTenKH.TabIndex = 84;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(189, 99);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(231, 22);
            this.txtMaKH.TabIndex = 83;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(228, 308);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 91;
            this.btnLuu.Text = "Save";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 406);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Name = "frmThemKhachHang";
            this.Text = "frmThemKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Button btnLuu;
    }
}