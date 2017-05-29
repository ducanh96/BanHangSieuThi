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


namespace BanHangTrongSieuThi.Duc_Anh.ChonHH
{
    public partial class FrmHangHoa : Form
    {
        public List<Hang> data;
        List<Hang> dataFilter;
        public FrmCreateDonHang _frmCreateDH;
        public FrmHangHoa()
        {
            InitializeComponent();
            data = HangBus.GetListHang();
            dgvHang.DataSource = data;
            dataFilter = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCreateHangHoa create = new FrmCreateHangHoa();
            create._frmHH = this;
            create.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var nv = dgvHang.CurrentRow.DataBoundItem as Hang;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (HangBus.DeleteHang(nv.MaHang))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data = HangBus.GetListHang();
                    dgvHang.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var _hang = dgvHang.Rows[e.RowIndex].DataBoundItem as Hang;
            FrmUpdateHH update = new FrmUpdateHH();
            update._frmHH = this;
            update._hang = _hang;
            update.Show();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var _CHonHH = dgvHang.CurrentRow.DataBoundItem as Hang;
            _frmCreateDH.txtDVT.Text = _CHonHH.DVT;
            _frmCreateDH.txtMH.Text = _CHonHH.MaHang;
            _frmCreateDH.txtTenHang.Text = _CHonHH.TenHang;
            this.Close();



        }
    }
}
