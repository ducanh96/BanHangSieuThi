using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class NhaCungCapBus
    {
        // Tạo nhacc
        public static bool CreateNhaCC(NhaCungCap cc)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var cc1 = new NhaCungCap();

                    cc1.TenNCC = cc.TenNCC ?? "";
                    cc1.MaNCC = cc.MaNCC;
                    cc1.DiaChi = cc.DiaChi;
                    cc1.DienThoai = cc.DienThoai;
                    cc1.MaSoThue = cc.MaSoThue;
                    cc1.Fax = cc.Fax;
                    db.NhaCungCaps.InsertOnSubmit(cc1);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        // Cap nhat nhacc
        public static bool UpdateNhaCC(NhaCungCap _cc)
        {
            try
            {
                using (var db = new SieuThiDBDataContext())
                {
                    var cc = db.NhaCungCaps.Single(x => x.MaNCC == _cc.MaNCC);
                    cc.TenNCC = _cc.TenNCC;
                    cc.DiaChi = _cc.DiaChi;
                    cc.DienThoai = _cc.DienThoai;
                    cc.MaSoThue = _cc.MaSoThue;
                    cc.Fax = _cc.Fax;
                   

                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        // Lay Id nhacc tiep theo
        public static int GetMaNhaCCNext()
        {
            using (var db = new SieuThiDBDataContext())
            {
                int? MaNCC = 0;
                var gh = db.NhaCungCaps.FirstOrDefault();
                if (gh == null)
                {
                    return 1;
                }
                else
                {
                 
                   db.MaNhaCCNext(ref MaNCC);
                    return MaNCC + 1 ?? 1;
                }


            }
        }


        //danh sach nhacc
        public static List<NhaCungCap> GetListNhaCC()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.NhaCungCaps.OrderBy(x => x.TenNCC).ToList();
            }
        }


        // Xoa nhacc
        public static bool DeleteNhaCC(int id)
        {
            try
            {


                using (var db = new SieuThiDBDataContext())
                {
                    var cc = db.NhaCungCaps.Single(x => x.MaNCC == id);
                    if (cc != null)
                    {
                        db.NhaCungCaps.DeleteOnSubmit(cc);
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

        }

    }
}
