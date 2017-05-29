using System;
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


namespace BanHangTrongSieuThi.Duc_Anh.HoaDon.ChonHH
{
    public partial class FrmNhaCC : Form
    {
        public int ktra = 0;
        public FrmCreateHangHoa _frmCreateHH;
        public FrmUpdateHH _frmUpdateHH;
        public List<NhaCungCap> data;
        List<NhaCungCap> dataFilter;
        public FrmNhaCC()
        {
            InitializeComponent();
            
            data =NhaCungCapBus.GetListNhaCC();
            dataFilter = data;
        }

        private void FrmNhaCC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
          CHonHH.FrmCreateNhaCC create = new CHonHH.FrmCreateNhaCC();
            create._frmCC = this;
            create.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cc = dgvNhaCC.CurrentRow.DataBoundItem as NhaCungCap;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                if (NhaCungCapBus.DeleteNhaCC(cc.MaNCC))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    data = NhaCungCapBus.GetListNhaCC();
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
                dataFilter = data.Where(x => x.TenNCC.ToLower().Contains(txtName.Text.ToLower())).ToList();
                dgvNhaCC.DataSource = dataFilter;
            }
        }

        private void dgvNhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var _cc = dgvNhaCC.Rows[e.RowIndex].DataBoundItem as NhaCungCap;
            FrmUpNhaCC update = new FrmUpNhaCC();
            update._frmCC = this;
            update.cc= _cc;
            update.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            var NhaCC = dgvNhaCC.CurrentRow.DataBoundItem as NhaCungCap;
            if(ktra == 0)
            {
                _frmCreateHH.txtMaNCC.Text = NhaCC.MaNCC.ToString();
                _frmCreateHH.lblTenMaNCC.Text = NhaCC.TenNCC;
                this.Close();

            }

            else
            {
                _frmUpdateHH.txtMaNCC.Text = NhaCC.MaNCC.ToString();
                _frmUpdateHH.lblTenMaNCC.Text = NhaCC.TenNCC;
                this.Close();
            }
           
        }
    }
}
