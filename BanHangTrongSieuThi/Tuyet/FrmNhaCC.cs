﻿using System;
using BUS;
using DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangTrongSieuThi.Tuyet;

namespace BanHangTrongSieuThi
{
    public partial class FrmNhaCC : Form
    {
        public List<nhacungcap> data;
        List<nhacungcap> dataFilter;
        public FrmNhaCC()
        {
            InitializeComponent();
            
            data =NhanVienBus.GetListNhaCC();
            dataFilter = data;
        }

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCreateNhaCC create = new FrmCreateNhaCC();
            create._frmCC = this;
            create.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cc = dgvNhaCC.CurrentRow.DataBoundItem as nhacungcap;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (NhanVienBus.DeleteNhaCC(cc.ma))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data = NhanVienBus.GetListNhaCC();
                    dgvNhaCC.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                dgvNhaCC.DataSource = data;
            }
            else
            {
                dataFilter = data.Where(x => x.tennhacungcap.Contains(txtName.Text)).ToList();
                dgvNhaCC.DataSource = dataFilter;
            }
        }

        private void dgvNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var _cc = dgvNhaCC.Rows[e.RowIndex].DataBoundItem as nhacungcap;
            FrmUpNhaCC update = new FrmUpNhaCC();
            update._frmCC = this;
            update.cc= _cc;
            update.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
