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

namespace BanHangTrongSieuThi.Khoa
{
    public partial class frmThem : Form
    {
        public frmThem()
        {
            InitializeComponent();
            tbMaLoaiHang.Text = LoaiHangBus.getCurrentMaLoaiHang().ToString();
        }
        public frmLoaiHang _frmLoaiHang;
     
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbTenLoaiHang.Text.Length == 0)
            {
                erpName.SetError(tbTenLoaiHang, "Không được để trống");
            }
            else
            {
                erpName.SetError(tbTenLoaiHang, "");
            }
            if (erpName.GetError(tbTenLoaiHang).Length == 0)
            {
                var lh = new LoaiHang();
                lh.TenLoaiHang = tbTenLoaiHang.Text;
                if (LoaiHangBus.createLoaiHang(lh))
                {
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _frmLoaiHang.data = LoaiHangBus.getListLoaiHang();
                    _frmLoaiHang.dgvLoaiHang.DataSource = _frmLoaiHang.data;
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm mới thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmThem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
