using BUS;
using DAO;
using DAO.ViewModel;
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
    public partial class FrmCreateDonHang : Form
    {
        List<HangHoaNhap> listHHN;
       
        public FrmCreateDonHang()
        {
            InitializeComponent();
            txtNgayDat.Text = DateTime.Now.ToString();
            listHHN = new List<HangHoaNhap>();
           
           
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            ChonNV.FrmNhanVien frmNV = new ChonNV.FrmNhanVien();
            frmNV._frmCreateDH = this;
            frmNV.Show();
        }

        private void btnMaHang_Click(object sender, EventArgs e)
        {
            ChonHH.FrmHangHoa frmHH = new ChonHH.FrmHangHoa();
            frmHH._frmCreateDH = this;
            frmHH.Show();
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Length == 0)
            {
                errMaNV.SetError(lblMaNV, "Không được để trống");

            }
            else
            {
                errMaNV.Clear();
            }

            if (txtMH.Text.Length == 0)
            {
                errMH.SetError(lblMH, "Không được để trống");

            }
            else
            {
                errMH.Clear();
            }


            if (txtDG.Text.Length == 0)
            {
                errDG.SetError(txtDG, "Không được để trống");

            }
            else
            {
                decimal DG;
                var ktra = decimal.TryParse(txtDG.Text, out DG);

                if (!ktra)
                {
                    errDG.SetError(txtDG, "Chỉ được nhập số nguyên dương");
                }
                else
                {
                    if (DG <= 0)
                    {
                        errDG.SetError(txtDG, "Chỉ được nhập số nguyên dương");
                    }
                    else
                        errDG.Clear();
                }

            }
            if (txtSL.Text.Length == 0)
            {
                errSL.SetError(txtSL, "Không được để trống");

            }
            else
            {
                errSL.Clear();
                int SL;
                var ktra = int.TryParse(txtSL.Text, out SL);

                if (!ktra)
                {
                    errSL.SetError(txtSL, "Chỉ được nhập số nguyên dương");
                }
                else
                {
                    if (SL <= 0)
                    {
                        errSL.SetError(txtSL, "Chỉ được nhập số nguyên dương");
                    }
                    else
                        errSL.Clear();
                }
            }

            if (errSL.GetError(txtSL).Length == 0 && errDG.GetError(txtDG).Length == 0 && errMH.GetError(lblMH).Length==0 && errMaNV.GetError(lblMaNV).Length==0)
            {

                HangHoaNhap hhn = new HangHoaNhap
                {
                    DG = decimal.Parse(txtDG.Text),
                    MaHang = txtMH.Text,
                    SL = int.Parse(txtSL.Text),
                    TenHang = txtTenHang.Text,
                    ThanhTien = int.Parse(txtSL.Text) * decimal.Parse(txtDG.Text),
                    DVT = txtDVT.Text,
                    TenLoaiHang = DonHangBus.GetTenLH(txtMH.Text),
                    TenNCC = DonHangBus.GetTenNCC(txtMH.Text)



                };
                listHHN.Add(hhn);
                dgvDH.DataSource = null;
                dgvDH.DataSource = listHHN;
                dgvDH.Refresh();
                txtMH.Text = "";
                txtSL.Text = "";
                txtTenHang.Text = "";
                txtDG.Text = "";
                txtDVT.Text = "";

            }
        }

        private void FrmCreateDonHang_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNgayDat.Text = DateTime.Now.ToString();
            txtMH.Text = "";
            txtSL.Text = "";
            txtTenHang.Text = "";
            txtDG.Text = "";
            txtDVT.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           var hhn =  dgvDH.CurrentRow.DataBoundItem as HangHoaNhap;
            var obj =  listHHN.Find(x => x.MaHang.ToLower() == hhn.MaHang.ToLower());
            listHHN.Remove(obj);
            dgvDH.DataSource = null;
            dgvDH.DataSource = listHHN;
        }

        private void btnTaoPhieuNhap_Click(object sender, EventArgs e)
        {
            int ktra = 0;
            if(listHHN.Count >0)
            {
                DonHang dh = new DonHang
                {
                    MaNV = int.Parse(txtMaNV.Text),
                    NgayDH = DateTime.Parse(txtNgayDat.Text)

                };
                if (DonHangBus.InsertDonHang(dh))
                {

                    foreach (var item in listHHN)
                    {
                        HangNhap hn = new HangNhap
                        {
                            DonGia = item.DG,
                            MaDH = dh.MaDH,
                            MaHang = item.MaHang,
                            SoLuong = item.SL


                        };
                        if (!DonHangBus.InsertHangNhap(hn))
                        {
                            ktra++;
                        }

                    }
                }
                else
                    ktra++;
                if (ktra == 0)
                    MessageBox.Show("Tạo đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hãy thêm hàng hóa muốn nhập","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
         
    }
}
