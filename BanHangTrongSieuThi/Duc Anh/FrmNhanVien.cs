using BanHangTrongSieuThi.Duc_Anh;
using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangTrongSieuThi
{
    public partial class FrmNhanVien : Form
    {
       public List<NhanVien> data;
        List<NhanVien> dataFilter;
        public FrmNhanVien()
        {
            InitializeComponent();
            data = NhanVienBus.GetListNhanVien();
            dataFilter = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCreateNhanVien create = new FrmCreateNhanVien();
            create._frmNV = this;
            create.Show();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = data;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var nv = dgvNhanVien.CurrentRow.DataBoundItem as NhanVien;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                if (NhanVienBus.DeleteNhanVien(nv.MaNV))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data = NhanVienBus.GetListNhanVien();
                    dgvNhanVien.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length ==0)
            {
                dgvNhanVien.DataSource = data;
            }
            else
            {
                dataFilter = data.Where(x => x.TenNV.Contains(txtName.Text)).ToList();
                dgvNhanVien.DataSource = dataFilter;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text.Length ==0)
            {
                dgvNhanVien.DataSource = data;
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _nv = dgvNhanVien.Rows[e.RowIndex].DataBoundItem as NhanVien;
            FrmUpdateNhanVien update = new FrmUpdateNhanVien();
            update._frmNV = this;
            update.nv = _nv;
            update.Show();
        }
    }
}
