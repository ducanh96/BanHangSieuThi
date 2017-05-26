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
        public nhacungcap cc;
        public FrmNhaCC _frmCC;
        public FrmUpNhaCC()
        {
            InitializeComponent();
        }

        private void FrmUpNhaCC_Load(object sender, EventArgs e)
        {
            txtMa.Text = cc.ma.ToString();
            txtTen.Text = cc.tennhacungcap;
            txtdiachi.Text = cc.diachi;
            txtSodienthoai.Text = cc.sodienthoai;
            txtFax.Text = cc.fax;
            txtMathue.Text = cc.masothue;
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {

            if (txtTen.Text.Length == 0)
            {
                errten.SetError(txtTen, "Không được để trống");
            }
            else
            {
                errten.SetError(txtTen, " ");
            }
            if (errten.GetError(txtTen).Length == 0)
            {

                cc.tennhacungcap = txtTen.Text;
                cc.sodienthoai = txtSodienthoai.Text;
                cc.masothue = txtMathue.Text;
                cc.fax = txtFax.Text;
                cc.diachi = txtdiachi.Text;
                if (NhanVienBus.UpdateNhaCC(cc))
                {
                    MessageBox.Show("Cập nhật thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmCC.data = NhanVienBus.GetListNhaCC();
                    _frmCC.dgvNhaCC.DataSource = _frmCC.data;
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
