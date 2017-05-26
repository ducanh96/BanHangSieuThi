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

namespace BanHangTrongSieuThi.Tuyet
{
    public partial class FrmUpNhaCC : Form
    {
        public NhaCungCap cc;
        public FrmNhaCC _frmCC;
        public FrmUpNhaCC()
        {
            InitializeComponent();
        }

        private void FrmUpNhaCC_Load(object sender, EventArgs e)
        {
            txtMa.Text = cc.MaNCC.ToString();
            txtTen.Text = cc.TenNCC;
            txtdiachi.Text = cc.DiaChi;
            txtSodienthoai.Text = cc.DienThoai;
            txtFax.Text = cc.Fax;
            txtMathue.Text = cc.MaSoThue;
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {

         

                cc.TenNCC = txtTen.Text ?? "";
                cc.DienThoai= txtSodienthoai.Text ?? "";
                cc.MaSoThue = txtMathue.Text ?? "";
                cc.Fax = txtFax.Text ?? "";
                cc.DiaChi = txtdiachi.Text ?? "";
                if (NhaCungCapBus.UpdateNhaCC(cc))
                {
                    MessageBox.Show("Cập nhật thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmCC.data = NhaCungCapBus.GetListNhaCC();
                    _frmCC.dgvNhaCC.DataSource = _frmCC.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
      

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
