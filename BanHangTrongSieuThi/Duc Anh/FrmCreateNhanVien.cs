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
    public partial class FrmCreateNhanVien : Form
    {
        public FrmNhanVien _frmNV;
        public FrmCreateNhanVien()
        {
            InitializeComponent();
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
            if(errTenNV.GetError(txtTenNv).Length==0)
            {
                var nv = new NhanVien();
                nv.TenNV = txtTenNv.Text;
                nv.MoTaKhac = txtMoTa.Text ?? "";
                nv.DienThoaiLH = txtDT.Text ?? "";
                if (NhanVienBus.CreateNhanVien(nv))
                {
                    MessageBox.Show("Thêm mới thánh công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _frmNV.data = NhanVienBus.GetListNhanVien();
                    _frmNV.dgvNhanVien.DataSource = _frmNV.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FrmCreateNhanVien_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = NhanVienBus.GetMaNVNext().ToString();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
