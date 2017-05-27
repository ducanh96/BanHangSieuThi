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

namespace BanHangTrongSieuThi.Duc_Anh
{
    public partial class FrmUpdateHH : Form
    {
        public Hang _hang;
        public FrmHangHoa _frmHH;
        public FrmUpdateHH()
        {
            InitializeComponent();
         
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text.Length == 0)
            {
                errMaHang.SetError(txtMaHang, "Không được để trống");

            }
            else
            {
                errMaHang.Clear();
            }
            if (txtTenHang.Text.Length == 0)
            {
                errTenHang.SetError(txtTenHang, "Không được để trống");

            }
            else
            {
                errTenHang.Clear();
            }

            if (txtMaLH.Text.Length == 0)
            {
                errMaLH.SetError(lblMaLH, "Không được để trống");

            }
            else
            {
                errMaLH.Clear();
            }

            if (txtMaNCC.Text.Length == 0)
            {
                errMaNCC.SetError(lblMaNCC, "Không được để trống");

            }
            else
            {
                errMaNCC.Clear();
            }

            if (errMaHang.GetError(txtMaHang).Length == 0 && errTenHang.GetError(txtTenHang).Length == 0 && errMaNCC.GetError(lblMaNCC).Length == 0 && errMaLH.GetError(lblMaLH).Length == 0)
            {

                Hang hang = new Hang();
                hang.MaHang = txtMaHang.Text;
                hang.DVT = txtDVT.Text;
                hang.GhiChu = txtGhiChu.Text;
                hang.MaLoaiHang = int.Parse(txtMaLH.Text);
                hang.MaNCC = int.Parse(txtMaNCC.Text);
                hang.TenHang = txtTenHang.Text;
                if (HangBus.UpdateHang(hang))
                {
                    MessageBox.Show("Cập nhật thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmHH.data = HangBus.GetListHang();
                    _frmHH.dgvHang.DataSource = _frmHH.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FrmUpdateHH_Load(object sender, EventArgs e)
        {
            using (var db = new SieuThiDBDataContext())
            {
                lblTenMaLH.Text = db.LoaiHangs.Single(x => x.MaLoaiHang == _hang.MaLoaiHang).TenLoaiHang;
                lblTenMaNCC.Text = db.NhaCungCaps.Single(x => x.MaNCC == _hang.MaNCC).TenNCC;
            }
            
            txtMaHang.Text = _hang.MaHang;
            txtDVT.Text = _hang.DVT;
            txtGhiChu.Text = _hang.GhiChu;
            txtMaLH.Text = _hang.MaLoaiHang.ToString();
            txtMaNCC.Text = _hang.MaNCC.ToString();
            txtTenHang.Text = _hang.TenHang;
        }

        private void btnMaLH_Click(object sender, EventArgs e)
        {
            frmLoaiHang frmLH = new frmLoaiHang();
            frmLH.ktra = 1;
            frmLH._frmUpdateHH = this;
            frmLH.Show();
        }

        private void btnMaNCC_Click(object sender, EventArgs e)
        {
            FrmNhaCC frmNCC = new FrmNhaCC();
            frmNCC.ktra = 1;
            frmNCC._frmUpdateHH = this;
            frmNCC.Show();
        }
    }
}

