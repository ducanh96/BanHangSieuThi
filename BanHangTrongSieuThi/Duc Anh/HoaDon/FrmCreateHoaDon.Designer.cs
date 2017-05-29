namespace BanHangTrongSieuThi.Duc_Anh.HoaDon
{
    partial class FrmCreateHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblMH = new System.Windows.Forms.Label();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMaHang = new System.Windows.Forms.Button();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNV = new System.Windows.Forms.Button();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayDat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errSL = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDG = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaNV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMH = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.btnTaoPhieuNhap = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.hangHoaNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaNhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(79, 54);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(709, 319);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin hóa đơn";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(342, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(156, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm vào phiếu xuất";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDVT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblMH);
            this.groupBox2.Controls.Add(this.txtDG);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnMaHang);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(398, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 208);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // txtDVT
            // 
            this.txtDVT.Enabled = false;
            this.txtDVT.Location = new System.Drawing.Point(107, 150);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(100, 20);
            this.txtDVT.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "ĐVT";
            // 
            // lblMH
            // 
            this.lblMH.AutoSize = true;
            this.lblMH.Location = new System.Drawing.Point(243, 19);
            this.lblMH.Name = "lblMH";
            this.lblMH.Size = new System.Drawing.Size(0, 13);
            this.lblMH.TabIndex = 8;
            // 
            // txtDG
            // 
            this.txtDG.Location = new System.Drawing.Point(107, 117);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(100, 20);
            this.txtDG.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đơn giá";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(107, 85);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(56, 20);
            this.txtSL.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng";
            // 
            // btnMaHang
            // 
            this.btnMaHang.Location = new System.Drawing.Point(213, 14);
            this.btnMaHang.Name = "btnMaHang";
            this.btnMaHang.Size = new System.Drawing.Size(24, 23);
            this.btnMaHang.TabIndex = 4;
            this.btnMaHang.Text = "...";
            this.btnMaHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaHang.UseVisualStyleBackColor = true;
            this.btnMaHang.Click += new System.EventHandler(this.btnMaHang_Click);
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Location = new System.Drawing.Point(107, 51);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenHang.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên hàng";
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(107, 16);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(100, 20);
            this.txtMH.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMaNV);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgayDat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(244, 70);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(0, 13);
            this.lblMaNV.TabIndex = 7;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(107, 113);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(100, 20);
            this.txtTenNV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên nhân viên";
            // 
            // btnNV
            // 
            this.btnNV.Location = new System.Drawing.Point(213, 63);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(24, 23);
            this.btnNV.TabIndex = 4;
            this.btnNV.Text = "...";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNV.UseVisualStyleBackColor = true;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(107, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtNgayDat
            // 
            this.txtNgayDat.Location = new System.Drawing.Point(107, 16);
            this.txtNgayDat.Name = "txtNgayDat";
            this.txtNgayDat.Size = new System.Drawing.Size(138, 20);
            this.txtNgayDat.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày đặt hàng";
            // 
            // errSL
            // 
            this.errSL.ContainerControl = this;
            // 
            // errDG
            // 
            this.errDG.ContainerControl = this;
            // 
            // errMaNV
            // 
            this.errMaNV.ContainerControl = this;
            // 
            // errMH
            // 
            this.errMH.ContainerControl = this;
            // 
            // dgvDH
            // 
            this.dgvDH.AllowUserToAddRows = false;
            this.dgvDH.AllowUserToDeleteRows = false;
            this.dgvDH.AutoGenerateColumns = false;
            this.dgvDH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDH.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.tenLoaiHangDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn,
            this.dGDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.dgvDH.DataSource = this.hangHoaNhapBindingSource;
            this.dgvDH.Location = new System.Drawing.Point(23, 432);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.ReadOnly = true;
            this.dgvDH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDH.Size = new System.Drawing.Size(818, 220);
            this.dgvDH.TabIndex = 9;
            // 
            // btnTaoPhieuNhap
            // 
            this.btnTaoPhieuNhap.Location = new System.Drawing.Point(226, 673);
            this.btnTaoPhieuNhap.Name = "btnTaoPhieuNhap";
            this.btnTaoPhieuNhap.Size = new System.Drawing.Size(105, 21);
            this.btnTaoPhieuNhap.TabIndex = 10;
            this.btnTaoPhieuNhap.Text = "Tạo phiếu xuất";
            this.btnTaoPhieuNhap.UseVisualStyleBackColor = true;
            this.btnTaoPhieuNhap.Click += new System.EventHandler(this.btnTaoPhieuNhap_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(507, 673);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(105, 21);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Danh sách hàng hóa xuất";
            // 
            // hangHoaNhapBindingSource
            // 
            this.hangHoaNhapBindingSource.DataSource = typeof(DAO.ViewModel.HangHoaNhap);
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            this.maHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            this.tenHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiHangDataGridViewTextBoxColumn
            // 
            this.tenLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiHang";
            this.tenLoaiHangDataGridViewTextBoxColumn.HeaderText = "TenLoaiHang";
            this.tenLoaiHangDataGridViewTextBoxColumn.Name = "tenLoaiHangDataGridViewTextBoxColumn";
            this.tenLoaiHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            this.dVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            this.sLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dGDataGridViewTextBoxColumn
            // 
            this.dGDataGridViewTextBoxColumn.DataPropertyName = "DG";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dGDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGDataGridViewTextBoxColumn.HeaderText = "DG";
            this.dGDataGridViewTextBoxColumn.Name = "dGDataGridViewTextBoxColumn";
            this.dGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.thanhTienDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmCreateHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(853, 716);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaoPhieuNhap);
            this.Controls.Add(this.dgvDH);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FrmCreateDonHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaNhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMaHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNgayDat;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTenNV;
        public System.Windows.Forms.TextBox txtMaNV;
        public System.Windows.Forms.TextBox txtMH;
        public System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.ErrorProvider errSL;
        private System.Windows.Forms.ErrorProvider errDG;
        private System.Windows.Forms.ErrorProvider errMaNV;
        private System.Windows.Forms.ErrorProvider errMH;
        private System.Windows.Forms.Label lblMH;
        private System.Windows.Forms.Label lblMaNV;
        public System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource hangHoaNhapBindingSource;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaoPhieuNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
    }
}