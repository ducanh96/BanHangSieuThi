using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonHangBus
    {
        #region Lay ten loai hang
        public static string GetTenLH(string maHang)
        {
            using(SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                string ten = db.Hangs.Single(x => x.MaHang.ToLower() == maHang.ToLower()).LoaiHang.TenLoaiHang;
                return ten;
            }
        }
        #endregion

        #region lay ten nha cung cap
        public static string GetTenNCC(string maHang)
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                return db.Hangs.Single(x => x.MaHang.ToLower() == maHang.ToLower()).NhaCungCap.TenNCC;
            }
        }
        #endregion

        #region Them Don hang
        public static bool InsertDonHang(DonHang dh)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    db.DonHangs.InsertOnSubmit(dh);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
           
        }
        #endregion

        #region Them hang nhap
        public static bool InsertHangNhap(HangNhap hn)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    db.HangNhaps.InsertOnSubmit(hn);
                    db.SubmitChanges();
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
