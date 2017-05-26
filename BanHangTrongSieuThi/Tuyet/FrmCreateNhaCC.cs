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

namespace BanHangTrongSieuThi.Tuyet
{
    public partial class FrmCreateNhaCC : Form
    {
        public FrmNhaCC _frmCC;
      

        public FrmCreateNhaCC()
        {
            InitializeComponent();
        }

       

        private void FrmCreateNhaCC_Load(object sender, EventArgs e)
        {
            txtMa.Text = NhanVienBus.GetMaNhaCCNext().ToString();
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

                var cc = new nhacungcap();
                cc.tennhacungcap = txtTen.Text;
                cc.diachi = txtdiachi.Text;
                cc.sodienthoai = txtSodienthoai.Text;
                cc.fax = txtFax.Text;
                cc.masothue = txtMathue.Text;
                if (NhanVienBus.CreateNhanVien(cc))
                {
                    MessageBox.Show("Thêm mới thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmCC.data = NhanVienBus.GetListNhaCC();
                    _frmCC.dgvNhaCC.DataSource = _frmCC.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
