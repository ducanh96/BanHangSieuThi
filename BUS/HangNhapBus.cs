using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangNhapBus
    {

        public static HangNhap getHangNhap(string maHang)
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.HangNhaps
                          join b in db.DonHangs
                          on a.MaDH equals b.MaDH
                          where a.MaHang.ToLower() == maHang.ToLower()
                          orderby b.NgayDH descending
                          select a).FirstOrDefault();
                return kq;
            }

        }
    }
}
