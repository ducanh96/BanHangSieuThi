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

namespace BanHangTrongSieuThi.Duc_Anh.HoaDon.ChonNV
{
    public partial class FrmUpdateNhanVien : Form
    {
        public NhanVien nv;
        public FrmNhanVien _frmNV;
        public FrmUpdateNhanVien()
        {
            InitializeComponent();
        }

        private void FrmUpdateNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = nv.MaNV.ToString();
            txtTenNv.Text = nv.TenNV;
            txtMoTa.Text = nv.MoTaKhac;
            txtDT.Text = nv.DienThoaiLH;
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            if (txtTenNv.Text.Length == 0)
            {
                errTenNV.SetError(txtTenNv, "Không được để trống");
            }
            else
            {
                errTenNV.SetError(txtTenNv, "");
            }
            if (errTenNV.GetError(txtTenNv).Length == 0)
            {
                
                nv.TenNV = txtTenNv.Text;
                nv.MoTaKhac = txtMoTa.Text ?? "";
                nv.DienThoaiLH = txtDT.Text ?? "";
                if (NhanVienBus.UpdateNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmNV.data = NhanVienBus.GetListNhanVien();
                    _frmNV.dgvNhanVien.DataSource = _frmNV.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
