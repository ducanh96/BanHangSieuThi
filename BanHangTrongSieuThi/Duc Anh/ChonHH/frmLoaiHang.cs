using BanHangTrongSieuThi.Duc_Anh;
using BanHangTrongSieuThi.Linh;
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

namespace BanHangTrongSieuThi.Duc_Anh.CHonHH
{
    public partial class frmLoaiHang : Form
    {

        public int ktra = 0;
        public ChonHH.FrmUpdateHH _frmUpdateHH;
        public ChonHH.FrmCreateHangHoa _frmCreateHH;
        public List<LoaiHang> data;
        List<LoaiHang> dataFilter;
        private LoaiHang lh;
      
        public frmLoaiHang()
        {
            InitializeComponent();
            data = LoaiHangBus.getListLoaiHang();
            dataFilter = data;
            dgvLoaiHang.DataSource = data;
        }
      

        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
           
            dgvLoaiHang.Columns[0].HeaderText = "Mã";
            dgvLoaiHang.Columns[0].Width = 50;
            dgvLoaiHang.Columns[1].HeaderText = "Tên Loại Hàng";
            dgvLoaiHang.Columns[1].Width = 150;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThem create = new frmThem();
            create._frmLoaiHang = this;
            create.Show();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var lh = dgvLoaiHang.CurrentRow.DataBoundItem as LoaiHang;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (LoaiHangBus.deleteLoaiHang(lh.MaLoaiHang))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data = LoaiHangBus.getListLoaiHang();
                    dgvLoaiHang.DataSource = data;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.Length == 0)
            {
                dgvLoaiHang.DataSource = data;
            }
            else
            {
                dataFilter = data.Where(x => x.TenLoaiHang.ToLower().Contains(tbTimKiem.Text.ToLower())).ToList();
                dgvLoaiHang.DataSource = dataFilter;
            }
        }

        private void tbTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiem.Text.Length == 0)
            {
                dgvLoaiHang.DataSource = data;
            }
        }

        private void dgvLoaiHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lh = dgvLoaiHang.Rows[e.RowIndex].DataBoundItem as LoaiHang;
            tbMaLoaiHang.Text = lh.MaLoaiHang.ToString();
            tbTenLoaiHang.Text = lh.TenLoaiHang.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (tbMaLoaiHang.Text.Length == 0)
            {
                erpName.SetError(tbMaLoaiHang, "Chưa chọn loại hàng để sửa");
            }
            else
            {
                if (tbTenLoaiHang.Text.Length == 0)
                {
                    erpName.SetError(tbTenLoaiHang, "Không được để trống");
                }
                else
                {
                    erpName.SetError(tbTenLoaiHang, "");
                }
                if (erpName.GetError(tbTenLoaiHang).Length == 0)
                {

                    lh.TenLoaiHang = tbTenLoaiHang.Text;
                    if (LoaiHangBus.updateLoaiHang(lh))
                    {
                        MessageBox.Show("Cập nhật thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        data = LoaiHangBus.getListLoaiHang();
                        dgvLoaiHang.DataSource = data;
                    }
                    else
                        MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var LoaiHangChon = dgvLoaiHang.CurrentRow.DataBoundItem as LoaiHang;
            if(ktra == 0)
            {
                _frmCreateHH.txtMaLH.Text = LoaiHangChon.MaLoaiHang.ToString();
                _frmCreateHH.lblTenMaLH.Text = LoaiHangChon.TenLoaiHang;
                this.Close();
            }
            else
            {
                _frmUpdateHH.txtMaLH.Text = LoaiHangChon.MaLoaiHang.ToString();
                _frmUpdateHH.lblTenMaLH.Text = LoaiHangChon.TenLoaiHang;
                this.Close();
            }
          
        }

       
    }
}
