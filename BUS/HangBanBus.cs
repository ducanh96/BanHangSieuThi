using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangBanBus
    {
        public static List<DSHB> getListDSHB()
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                return db.DSHBs.ToList();
            }
        }

        public static DSHB getHangBanChayNhatNgay()
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.DSHBs orderby a.soLuong descending select a).FirstOrDefault();
                return kq;
            }
        }

        public static List<DSHB> findDSHB(string maHang)
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.DSHBs
                          where a.MaHang.ToString().ToLower().Contains(maHang.ToLower())
                          select a).ToList();

                return kq;
            }
        }

        public static HangBanTrongThang getHangBanChayNhatThang()
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.HangBanTrongThangs
                        orderby a.soLuong descending select a).FirstOrDefault();
                return kq;
            }
        }
    }
}
