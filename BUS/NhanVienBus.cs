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

        public static bool CreateNhanVien(nhacungcap cc)
        {
            throw new NotImplementedException();
        }

        public static bool DeleteNhanVien(string ma)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Lay Id Nhan vien tiep theo
        public static int GetMaNVNext()
        {
            using (var db = new SieuThiDBDataContext())
            {
                int? manv = 0;
                var nv = db.NhanViens.FirstOrDefault();
                if(nv == null)
                {
                    return 1;
                }
                else
                {
                    db.ManvNext(ref manv);
                    return manv + 1 ?? 1;
                }
                
              
               
               
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
        public static bool CreateNhaCC(nhacungcap cc)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var cc1 = new nhacungcap();
                    cc1.tennhacungcap = cc.tennhacungcap;
                    cc1.ma = cc.ma;
                    cc1.diachi = cc.diachi;
                    cc1.sodienthoai = cc.sodienthoai;
                    cc1.masothue = cc.masothue;
                    cc1.fax = cc.fax;
                    db.nhacungcaps.InsertOnSubmit(cc1);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        #region Cap nhat nhacungcap
        public static bool UpdateNhaCC(nhacungcap _cc)
        {
            try
            {
                using (var db = new SieuThiDBDataContext())
                {
                    var cc = db.nhacungcaps.Single(x => x.ma == _cc.ma);
                    cc.tennhacungcap = _cc.tennhacungcap;
                    cc.ma = _cc.ma;
                    cc.diachi = _cc.diachi;
                    cc.sodienthoai = _cc.sodienthoai;
                    cc.masothue = _cc.masothue;
                    cc.fax = _cc.fax;

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

        #region Lay Id nhacc tiep theo
        public static int GetMaNhaCCNext()
        {
            using (var db = new SieuThiDBDataContext())
            {
                int? ma = 0;
                var nv = db.nhacungcaps.FirstOrDefault();
                if (nv == null)
                {
                    return 1;
                }
                else
                {
                    db.ManvNext(ref ma);
                    return ma + 1 ?? 1;
                }




            }
        }
        #endregion

        #region Lay danh sach nhan vien
        public static List<nhacungcap> GetListNhaCC()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.nhacungcaps.OrderBy(x => x.tennhacungcap).ToList();
            }
        }
        #endregion

        #region Xoa nhac
        public static bool DeleteNhaCC(string id)
        {
            try
            {


                using (var db = new SieuThiDBDataContext())
                {
                    var nv = db.nhacungcaps.Single(x => x.ma == id);
                    if (nv != null)
                    {
                        db.nhacungcaps.DeleteOnSubmit(nv);
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
