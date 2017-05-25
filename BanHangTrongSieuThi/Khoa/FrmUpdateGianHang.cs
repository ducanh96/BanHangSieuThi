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

namespace BanHangTrongSieuThi.Khoa
{
    public partial class FrmUpdateGianHang : Form
    {
        public GianHang gh;
        public FrmGianHang _frmGH;
        public FrmUpdateGianHang()
        {
            InitializeComponent();
        }

        private void FrmUpdateGianHang_Load(object sender, EventArgs e)
        {
            txtMaGH.Text = gh.MaGianHang.ToString();
            txtTenGH.Text = gh.TenGianHang;
            txtMaLoaiHang.Text = gh.LoaiHangMa.ToString();
           
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {

            if (txtTenGH.Text.Length == 0 && txtMaGH.Text.Length == 0)
            {
                errTenGH.SetError(txtTenGH, "Không được để trống");
                
            }
            else
            {
                errTenGH.SetError(txtTenGH, "");
               
            }
            if (errTenGH.GetError(txtTenGH).Length == 0 )
            {

                gh.TenGianHang = txtTenGH.Text;
                gh.LoaiHangMa = int.Parse(txtMaLoaiHang.Text);
                
                if (GianHangBus.UpdateGianHang(gh))
                {
                    MessageBox.Show("Cập nhật thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmGH.data = GianHangBus.GetListGianHang();
                    _frmGH.dgvGianHang.DataSource = _frmGH.data;
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
