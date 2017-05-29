namespace BanHangTrongSieuThi.Khoa
{
    partial class FrmGianHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGianHang = new System.Windows.Forms.DataGridView();
            this.colLoaiHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maGianHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGianHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GianHangbindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGianHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GianHangbindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(294, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên gian hàng";
            // 
            // dgvGianHang
            // 
            this.dgvGianHang.AllowUserToAddRows = false;
            this.dgvGianHang.AllowUserToDeleteRows = false;
            this.dgvGianHang.AutoGenerateColumns = false;
            this.dgvGianHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGianHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvGianHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGianHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGianHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGianHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGianHangDataGridViewTextBoxColumn,
            this.tenGianHangDataGridViewTextBoxColumn,
            this.colLoaiHang});
            this.dgvGianHang.DataSource = this.GianHangbindingSource1;
            this.dgvGianHang.Location = new System.Drawing.Point(29, 92);
            this.dgvGianHang.MultiSelect = false;
            this.dgvGianHang.Name = "dgvGianHang";
            this.dgvGianHang.ReadOnly = true;
            this.dgvGianHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGianHang.Size = new System.Drawing.Size(577, 223);
            this.dgvGianHang.TabIndex = 6;
            this.dgvGianHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGianHang_CellDoubleClick);
            this.dgvGianHang.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvGianHang_RowPrePaint);
            // 
            // colLoaiHang
            // 
            this.colLoaiHang.HeaderText = "Tên Loại Hàng";
            this.colLoaiHang.Name = "colLoaiHang";
            this.colLoaiHang.ReadOnly = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(320, 359);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Location = new System.Drawing.Point(474, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // maGianHangDataGridViewTextBoxColumn
            // 
            this.maGianHangDataGridViewTextBoxColumn.DataPropertyName = "MaGianHang";
            this.maGianHangDataGridViewTextBoxColumn.HeaderText = "MaGianHang";
            this.maGianHangDataGridViewTextBoxColumn.Name = "maGianHangDataGridViewTextBoxColumn";
            this.maGianHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGianHangDataGridViewTextBoxColumn
            // 
            this.tenGianHangDataGridViewTextBoxColumn.DataPropertyName = "TenGianHang";
            this.tenGianHangDataGridViewTextBoxColumn.HeaderText = "TenGianHang";
            this.tenGianHangDataGridViewTextBoxColumn.Name = "tenGianHangDataGridViewTextBoxColumn";
            this.tenGianHangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GianHangbindingSource1
            // 
            this.GianHangbindingSource1.DataSource = typeof(DAO.GianHang);
            // 
            // FrmGianHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dgvGianHang);
            this.Name = "FrmGianHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GianHang";
            this.Load += new System.EventHandler(this.GianHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGianHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GianHangbindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvGianHang;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource GianHangbindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGianHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGianHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiHang;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}