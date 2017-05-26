using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using BanHangTrongSieuThi.Linh;

namespace BanHangTrongSieuThi.Khoa
{
    public partial class FrmCreateGianHang : Form
    {
        public FrmGianHang _frmGH;
        public LoaiHang lh;
        public FrmCreateGianHang()
        {
            InitializeComponent();
           
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            if (txtTenGH.Text.Length == 0 )
            {
                errTenGH.SetError(txtTenGH, "Không được để trống");
               
            }
            else
            {
                errTenGH.SetError(txtTenGH, "");
               
            }
            if (errTenGH.GetError(txtTenGH).Length == 0 )
            {
                var gh = new GianHang();
                gh.TenGianHang = txtTenGH.Text;
               
                gh.LoaiHangMa = int.Parse(txtMaLoaiHang.Text);
                if (GianHangBus.CreateGianHang(gh))
                {
                    MessageBox.Show("Thêm mới thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmGH.data = GianHangBus.GetListGianHang();
                    _frmGH.dgvGianHang.DataSource = _frmGH.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmCreateGianHang_Load(object sender, EventArgs e)
        {
            txtMaGH.Text = GianHangBus.GetMaGHNext().ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGianHang_Click(object sender, EventArgs e)
        {
            frmLoaiHang frmLH = new frmLoaiHang();
            frmLH._frmCreateGianHang = this;
            frmLH.Show();
            
        }
    }
}
