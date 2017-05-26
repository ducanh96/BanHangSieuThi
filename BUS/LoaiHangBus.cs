using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BUS
{
    public class LoaiHangBus
    {

        public static bool createLoaiHang(LoaiHang loaiHang)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var lh = new LoaiHang();
                    lh.TenLoaiHang = loaiHang.TenLoaiHang;
                    db.LoaiHangs.InsertOnSubmit(lh);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public static bool updateLoaiHang(LoaiHang _lh)
        {
            try
            {
                using (var db = new SieuThiDBDataContext())
                {
                    var loaiHang = db.LoaiHangs.Single(x => x.MaLoaiHang == _lh.MaLoaiHang);
                    loaiHang.TenLoaiHang = _lh.TenLoaiHang;
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }


        public static int getCurrentMaLoaiHang()
        {
            using (var db = new SieuThiDBDataContext())
            {
                int? maLoaiHang = 0;
                var lh = db.LoaiHangs.FirstOrDefault();
                db.LoaiHangGanNhat(ref maLoaiHang);
                if (lh == null)
                {
                    return 1;
                }
                else
                {
                    db.LoaiHangGanNhat(ref maLoaiHang);
                    return maLoaiHang + 1 ?? 1;
                }


            }
        }

        public static List<LoaiHang> getListLoaiHang()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.LoaiHangs.OrderBy(x => x.TenLoaiHang).ToList();
            }
        }

        public static bool deleteLoaiHang(int id)
        {
            try
            {


                using (var db = new SieuThiDBDataContext())
                {
                    var nv = db.LoaiHangs.Single(x => x.MaLoaiHang == id);
                    if (nv != null)
                    {
                        db.LoaiHangs.DeleteOnSubmit(nv);
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
