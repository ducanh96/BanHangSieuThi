using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBus
    {
        #region Tạo mới nhân viên
        public static bool CreateNhanVien(NhanVien nv)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var nv1 = new NhanVien();
                    nv1.TenNV = nv.TenNV;
                    nv1.MoTaKhac = nv.MoTaKhac ?? "";
                    nv1.DienThoaiLH = nv.DienThoaiLH ?? "";
                    db.NhanViens.InsertOnSubmit(nv1);
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

        #region Cap nhat nhan vien
        public static bool UpdateNhanVien(NhanVien _nv)
        {
            try
            {
                using (var db = new SieuThiDBDataContext())
                {
                    var nv = db.NhanViens.Single(x => x.MaNV == _nv.MaNV);
                    nv.TenNV = _nv.TenNV;
                    nv.DienThoaiLH = _nv.DienThoaiLH;
                    nv.MoTaKhac = _nv.MoTaKhac;
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

        #region Lay Id Nhan vien tiep theo
        public static int GetMaNVNext()
        {
            using (var db = new SieuThiDBDataContext())
            {
                int? manv = 0;
                db.ManvNext(ref manv);
                return manv+1 ?? 1;
               
            }
        }
        #endregion

        #region Lay danh sach nhan vien
        public static List<NhanVien> GetListNhanVien()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.NhanViens.OrderBy(x=>x.TenNV).ToList();
            }
        }
        #endregion

        #region Xoa nhan vien
        public static bool DeleteNhanVien(int id)
        {
            try
            {


                using (var db = new SieuThiDBDataContext())
                {
                    var nv = db.NhanViens.Single(x => x.MaNV == id);
                    if (nv != null)
                    {
                        db.NhanViens.DeleteOnSubmit(nv);
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
