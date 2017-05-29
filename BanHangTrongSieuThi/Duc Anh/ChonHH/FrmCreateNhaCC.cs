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

namespace BanHangTrongSieuThi.Duc_Anh.CHonHH
{
    public partial class FrmCreateNhaCC : Form
    {
        public ChonHH.FrmNhaCC _frmCC;
      

        public FrmCreateNhaCC()
        {
            InitializeComponent();
        }

       

        private void FrmCreateNhaCC_Load(object sender, EventArgs e)
        {
            txtMa.Text = NhaCungCapBus.GetMaNhaCCNext().ToString();
        }

        private void txtLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Length == 0)
            {
                errorProvider1.SetError(txtTen, "Không được để trống");
            }
            else
            {
                errorProvider1.SetError(txtTen, "");
            }
            if (errorProvider1.GetError(txtTen).Length == 0)
            {

                var cc = new NhaCungCap();
                cc.TenNCC = txtTen.Text??"";
                cc.DiaChi = txtdiachi.Text ?? "";
                cc.DienThoai = txtSodienthoai.Text ?? "";
                cc.Fax= txtFax.Text ?? "";
                cc.MaSoThue = txtMathue.Text ?? "";
                if (NhaCungCapBus.CreateNhaCC(cc))
                {
                    MessageBox.Show("Thêm mới thánh công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmCC.data = NhaCungCapBus.GetListNhaCC();
                    _frmCC.dgvNhaCC.DataSource = _frmCC.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
