using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class NhaCCbus
    {
       
        public static bool CreateNhaCC(nhacungcap cc)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    var cc1 = new nhacungcap();
                    cc1.tennhacungcap = cc.tennhacungcap;
                    cc1.ma = cc.ma ;
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
                int ?  ma = 0;
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
