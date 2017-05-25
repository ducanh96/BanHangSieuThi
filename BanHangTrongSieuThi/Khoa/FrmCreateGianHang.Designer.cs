namespace BanHangTrongSieuThi.Khoa
{
    partial class FrmCreateGianHang
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaGH = new System.Windows.Forms.TextBox();
            this.txtTenGH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.txtLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.errTenGH = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errTenGH)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tạo gian hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã gian hàng";
            // 
            // txtMaGH
            // 
            this.txtMaGH.Enabled = false;
            this.txtMaGH.Location = new System.Drawing.Point(108, 63);
            this.txtMaGH.Name = "txtMaGH";
            this.txtMaGH.Size = new System.Drawing.Size(159, 20);
            this.txtMaGH.TabIndex = 11;
            // 
            // txtTenGH
            // 
            this.txtTenGH.Location = new System.Drawing.Point(108, 114);
            this.txtTenGH.Name = "txtTenGH";
            this.txtTenGH.Size = new System.Drawing.Size(159, 20);
            this.txtTenGH.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã loại hàng";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(108, 167);
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(159, 20);
            this.txtMaLoaiHang.TabIndex = 16;
            // 
            // txtLuu
            // 
            this.txtLuu.Location = new System.Drawing.Point(39, 249);
            this.txtLuu.Name = "txtLuu";
            this.txtLuu.Size = new System.Drawing.Size(75, 23);
            this.txtLuu.TabIndex = 18;
            this.txtLuu.Text = "Lưu";
            this.txtLuu.UseVisualStyleBackColor = true;
            this.txtLuu.Click += new System.EventHandler(this.txtLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(211, 249);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // errTenGH
            // 
            this.errTenGH.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên gian hàng";
            // 
            // FrmCreateGianHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtLuu);
            this.Controls.Add(this.txtMaLoaiHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenGH);
            this.Controls.Add(this.txtMaGH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FrmCreateGianHang";
            this.Text = "Tạo mới gian hàng";
            this.Load += new System.EventHandler(this.FrmCreateGianHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errTenGH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaGH;
        private System.Windows.Forms.TextBox txtTenGH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Button txtLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.ErrorProvider errTenGH;
        private System.Windows.Forms.Label label2;
    }
}