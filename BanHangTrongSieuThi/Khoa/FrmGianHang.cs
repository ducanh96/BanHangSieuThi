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



namespace BanHangTrongSieuThi.Khoa
{
    public partial class FrmGianHang : Form
    {
        public List<GianHang> data;
        List<GianHang> dataFilter;
        public FrmGianHang()
        {
            InitializeComponent();
            data =GianHangBus.GetListGianHang();
            dataFilter = data;
        }
        
        private void GianHang_Load(object sender, EventArgs e)
        {
            dgvGianHang.DataSource = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCreateGianHang create = new FrmCreateGianHang();
            create._frmGH = this;
            create.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var gh = dgvGianHang.CurrentRow.DataBoundItem as GianHang;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (GianHangBus.DeleteGianHang(gh.MaGianHang))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data = GianHangBus.GetListGianHang();
                    dgvGianHang.DataSource = data;
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
                dgvGianHang.DataSource = data;
            }
            else
            {
                dataFilter = data.Where(x => x.TenGianHang.Contains(txtName.Text)).ToList();
                dgvGianHang.DataSource = dataFilter;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                dgvGianHang.DataSource = data;
            }
        }

        private void dgvGianHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _gh = dgvGianHang.Rows[e.RowIndex].DataBoundItem as GianHang;
            FrmUpdateGianHang update = new FrmUpdateGianHang();
            update._frmGH = this;
            update.gh = _gh;
            update.Show();
        }
    }
}
