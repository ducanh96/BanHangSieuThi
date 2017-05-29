using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangTrongSieuThi.Duc_Anh.CHonHH;
using BanHangTrongSieuThi.Tuyet;

namespace BanHangTrongSieuThi.Duc_Anh
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void tspLapDonHang_Click(object sender, EventArgs e)
        {
            FrmCreateDonHang create = new FrmCreateDonHang();
            create.Show();
        }

        private void tspThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tspQLDH_Click(object sender, EventArgs e)
        {
            FrmHangHoa hangHoa = new FrmHangHoa();
            hangHoa.Show();
        }

        private void tspLoaiHang_Click(object sender, EventArgs e)
        {
            Linh.frmLoaiHang lh = new Linh.frmLoaiHang();
            lh.Show();
        }

        private void tspGH_Click(object sender, EventArgs e)
        {
            Khoa.FrmGianHang GH = new Khoa.FrmGianHang();
            GH.Show();
        }

        private void tspNCC_Click(object sender, EventArgs e)
        {
            Tuyet.FrmNhaCC ncc = new Tuyet.FrmNhaCC();
            ncc.Show();
        }

        private void tspNV_Click(object sender, EventArgs e)
        {
            FrmNhanVien nv = new FrmNhanVien();
            nv.Show();
        }
    }
}
