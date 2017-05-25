using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class GianHangBus
    {
        // Tạo Gian hang
        public static bool CreateGianHang(GianHang gh)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var gh1 = new GianHang();
                   
                    gh1.TenGianHang = gh.TenGianHang ?? "";
                    gh1.LoaiHangMa = gh.LoaiHangMa;
                    db.GianHangs.InsertOnSubmit(gh1);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        

        // Cap nhat Gian hang
        public static bool UpdateGianHang(GianHang _gh)
        {
            try
            {
                using (var db = new SieuThiDBDataContext())
                {
                    var gh = db.GianHangs.Single(x => x.MaGianHang == _gh.MaGianHang);
                    gh.TenGianHang = _gh.TenGianHang;
                    gh.LoaiHangMa = _gh.LoaiHangMa;
                    
                    db.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        
       // Lay Id Gian Hang tiep theo
        public static int GetMaGHNext()
        {
            using (var db = new SieuThiDBDataContext())
            {
                int? MaGianHang = 0;
                var gh = db.GianHangs.FirstOrDefault();
                if(gh == null)
                {
                    return 1;
                }
                else
                {
                    db.GianHangNext(ref MaGianHang);
                    return MaGianHang + 1 ?? 1;
                }
               

            }
        }
        

          //danh sach gian hang
        public static List<GianHang> GetListGianHang()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.GianHangs.OrderBy(x => x.TenGianHang).ToList();
            }
        }
       

        // Xoa gian hang
        public static bool DeleteGianHang(int id)
        {
            try
            {


                using (var db = new SieuThiDBDataContext())
                {
                    var gh = db.GianHangs.Single(x => x.MaGianHang == id);
                    if (gh != null)
                    {
                        db.GianHangs.DeleteOnSubmit(gh);
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
