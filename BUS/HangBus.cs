using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangBus
    {
        #region Lấy thông tin Hàng
        public static Hang getHang(string maHang)
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.Hangs where a.MaHang.ToLower() == maHang.ToLower() select a).FirstOrDefault();
                return kq;
            }

        }
        #endregion

        #region Tạo mới hang hoa
        public static bool CreateHang(Hang hang)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var hang1 = new Hang();
                    hang1.MaHang = hang.MaHang;
                    hang1.DVT = hang.DVT ?? "";
                    hang1.GhiChu = hang.GhiChu ?? "";
                    hang1.MaLoaiHang = hang.MaLoaiHang;
                    hang1.MaNCC = hang.MaNCC;
                    hang1.TenHang = hang.TenHang ?? "";
                    db.Hangs.InsertOnSubmit(hang1);
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

        #region Cap nhat hang
        public static bool UpdateHang(Hang hang)
        {
            try
            {
                using (var db = new SieuThiDBDataContext())
                {
                    var hang1 = db.Hangs.Single(x => x.MaHang == hang.MaHang);
                    hang1.DVT = hang.DVT ?? "";
                    hang1.GhiChu = hang.GhiChu ?? "";
                    hang1.MaLoaiHang = hang.MaLoaiHang;
                    hang1.MaNCC = hang.MaNCC;
                    hang1.TenHang = hang.TenHang ?? "";
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

        #region kiem tra ma hang bi trung
        public static bool IsExistHang(string maHang)
        {
            using (var db = new SieuThiDBDataContext())
            {
               
                var hang = db.Hangs.Single(x => x.MaHang.ToLower() == maHang.ToLower());
               
                if (hang == null)
                {
                    return false;
                }
                else
                {

                    return true;
                }


            }
        }
        #endregion

        #region Lay danh sach hang
        public static List<Hang> GetListHang()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.Hangs.OrderBy(x => x.TenHang).ToList();
            }
        }
        #endregion

        #region Xoa Hang
        public static bool DeleteHang(string maHang)
        {
            try
            {


                using (var db = new SieuThiDBDataContext())
                {
                    var nv = db.Hangs.Single(x => x.MaHang.ToLower() == maHang.ToLower());
                    if (nv != null)
                    {
                        db.Hangs.DeleteOnSubmit(nv);
                        db.SubmitChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            #endregion
        }
    }
}
