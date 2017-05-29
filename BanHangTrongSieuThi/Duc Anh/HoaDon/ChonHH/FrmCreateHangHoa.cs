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


namespace BanHangTrongSieuThi.Duc_Anh.HoaDon.ChonHH
{
    public partial class FrmCreateHangHoa : Form
    {
        public FrmHangHoa _frmHH;

        public FrmCreateHangHoa()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
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
          if (errMaHang.GetError(txtMaHang).Length==0 && errTenHang.GetError(txtTenHang).Length ==0 && errMaNCC.GetError(lblMaNCC).Length==0 && errMaLH.GetError(lblMaLH).Length == 0)
            {
                var hang = new Hang();
                hang.MaHang = txtMaHang.Text;
                hang.TenHang = txtTenHang.Text;
                hang.MaLoaiHang = int.Parse(txtMaLH.Text);
                hang.MaNCC = int.Parse(txtMaNCC.Text);
                hang.GhiChu = txtGhiChu.Text;
                hang.DVT = txtDVT.Text;
                if (HangBus.CreateHang(hang))
                {
                    MessageBox.Show("Thêm mới thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmHH.data = HangBus.GetListHang();
                    _frmHH.dgvHang.DataSource = _frmHH.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnMaLH_Click(object sender, EventArgs e)
        {
           CHonHH.frmLoaiHang frmLH = new CHonHH.frmLoaiHang();
            frmLH._frmCreateHH = this;
            frmLH.Show();
        }

        private void btnMaNCC_Click(object sender, EventArgs e)
        {
            FrmNhaCC frmNCC = new FrmNhaCC();
            frmNCC._frmCreateHH = this;
            frmNCC.Show();
        }
    }
    }

