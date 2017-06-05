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

namespace BanHangTrongSieuThi.Linh
{
    public partial class frmBaoCao : Form
    {
        public List<DSHB> data;
        private int dem = 0;
        private List<DSHB> dataFilter;

        public frmBaoCao()
        {
            InitializeComponent();
            data = HangBanBus.getListDSHB();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dgvDSHB.DataSource = data;

        }

        private void dgvDSHB_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dem++;
            var dshb = dgvDSHB.Rows[e.RowIndex].DataBoundItem as DSHB;
            var hangnhap = HangNhapBus.getHangNhap(dshb.MaHang);
            var hang = HangBus.getHang(dshb.MaHang);

            dgvDSHB.Rows[e.RowIndex].Cells[colTT.Index].Value = dshb.soLuong * (dshb.DonGia - hangnhap.DonGia);
            dgvDSHB.Rows[e.RowIndex].Cells[colDGN.Index].Value = hangnhap.DonGia;
            dgvDSHB.Rows[e.RowIndex].Cells[colTenHang.Index].Value = hang.TenHang;

            //tính toán doanh thu, tiền lãi
            if (dem == dgvDSHB.Rows.Count)
            {
                int soHang = dgvDSHB.Rows.Count;
                decimal tongLai = 0;
                decimal doanhThu = 0;
                for (int i = 0; i < soHang; i++)
                {
                    tongLai += decimal.Parse(dgvDSHB.Rows[i].Cells[colTT.Index].Value.ToString());
                    doanhThu += (decimal.Parse(dgvDSHB.Rows[i].Cells[colDonGiaBan.Index].Value.ToString()) * (decimal.Parse(dgvDSHB.Rows[i].Cells[colSoLuong.Index].Value.ToString())));
                }

                tbTongTienLai.Text = tongLai.ToString();
                tbDoanhThu.Text = doanhThu.ToString();

                //cập nhật doanh thu, tiền lãi, hàng bán chạy theo ngày lên view
                var hangBanChayNhatNgay = HangBanBus.getHangBanChayNhatNgay();
                tbTenHangBanChay.Text = HangBus.getHang(hangBanChayNhatNgay.MaHang).TenHang.ToString();
                tbMaHangBanChay.Text = hangBanChayNhatNgay.MaHang.ToString();
                tbSoLuong.Text = hangBanChayNhatNgay.soLuong.ToString();

                //Cập nhật dữ liệu vào csdl doanh thu
                DoanhThu dt = DoanhThuBus.getDoanhThuGanNhat();
                if (dt == null)
                {
                    dt = new DoanhThu();
                    dt.ngayThongKe = DateTime.Parse(DateTime.Now.ToShortDateString());
                    dt.doanhThuHomNay = long.Parse(tbDoanhThu.Text);
                    dt.maHangBanChay = tbMaHangBanChay.Text;
                    dt.soLuongBanChay = int.Parse(tbSoLuong.Text);
                    dt.tienLaiHomNay = long.Parse(tbTongTienLai.Text);

                    DoanhThuBus.createDoanhThu(dt);
                }
                else if (dt != null && dt.ngayThongKe == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    dt.doanhThuHomNay = long.Parse(tbDoanhThu.Text);
                    dt.maHangBanChay = tbMaHangBanChay.Text;
                    dt.soLuongBanChay = int.Parse(tbSoLuong.Text);
                    dt.tienLaiHomNay = long.Parse(tbTongTienLai.Text);

                    DoanhThuBus.updateDoanhThu(dt);
                }
                else if(dt != null && dt.ngayThongKe != DateTime.Now)
                {
                    dt = new DoanhThu();
                    dt.ngayThongKe = DateTime.Parse(DateTime.Now.ToShortDateString());
                    dt.doanhThuHomNay = long.Parse(tbDoanhThu.Text);
                    dt.maHangBanChay = tbMaHangBanChay.Text;
                    dt.soLuongBanChay = int.Parse(tbSoLuong.Text);
                    dt.tienLaiHomNay = long.Parse(tbTongTienLai.Text);

                    DoanhThuBus.createDoanhThu(dt);
                }

                //Cập nhật, tính toán thống kê theo tháng;
                long doanhThuThang = DoanhThuBus.tinhTongDoanhThuThang();
                float percentDoanhThu = ((float)doanhThuThang / 50000000000) * 100;

                long laiSuatThang = DoanhThuBus.tinhTongLaiTheoThang();
                float percentLaiSuat = ((float)laiSuatThang / 1500000000) * 100;

                tbDoanhThuThang.Text = doanhThuThang.ToString();
                tbLaiSuatThang.Text = laiSuatThang.ToString();
                tbPercentDoanhThu.Text = percentDoanhThu.ToString();
                tbPercentLaiSuat.Text = percentLaiSuat.ToString();

                //Đưa ra thông tin hàng bán chạy nhất tháng
                var hangBanChayNhatThang = HangBanBus.getHangBanChayNhatThang();
                tbMaBanChayThang.Text = hangBanChayNhatThang.MaHang;
                tbTenBanChayThang.Text = HangBus.getHang(hangBanChayNhatThang.MaHang).TenHang.ToString();
                tbSoLuongThang.Text = hangBanChayNhatThang.soLuong.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDTTimKiem_Click(object sender, EventArgs e)
        {
            if (tbDTTimKiem.Text.Length == 0)
            {
                dgvDSHB.DataSource = data;
            }
            else
            {
                dataFilter = HangBanBus.findDSHB(tbDTTimKiem.Text);
                dgvDSHB.DataSource = dataFilter;
            }
        }
    }
}
