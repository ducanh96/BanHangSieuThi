using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DoanhThuBus
    {
        public static void createDoanhThu(DoanhThu doanhThu)
        {
            using (SieuThiDBDataContext db = new SieuThiDBDataContext())
            {
                var dt = new DoanhThu();
                dt.ngayThongKe = doanhThu.ngayThongKe;
                dt.maHangBanChay = doanhThu.maHangBanChay;
                dt.soLuongBanChay = doanhThu.soLuongBanChay;
                dt.doanhThuHomNay = doanhThu.doanhThuHomNay;
                dt.tienLaiHomNay = doanhThu.tienLaiHomNay;
                db.DoanhThus.InsertOnSubmit(dt);
                db.SubmitChanges();
            }
        }

        public static DoanhThu getDoanhThuGanNhat()
        {
            using (var db = new SieuThiDBDataContext())
            {
                return db.DoanhThus.OrderByDescending(x => x.ngayThongKe).FirstOrDefault();
            }
        }

        public static void updateDoanhThu(DoanhThu doanhThu)
        {
            using (var db = new SieuThiDBDataContext())
            {
                var dt = db.DoanhThus.Single(x => x.ngayThongKe == doanhThu.ngayThongKe);
                dt.maHangBanChay = doanhThu.maHangBanChay;
                dt.soLuongBanChay = doanhThu.soLuongBanChay;
                dt.doanhThuHomNay = doanhThu.doanhThuHomNay;
                dt.tienLaiHomNay = doanhThu.tienLaiHomNay;
                db.SubmitChanges();
            }
        }

        public static long tinhTongDoanhThuThang()
        {
            using (var db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.DoanhThus
                          where a.ngayThongKe.Month == DateTime.Now.Month
                          select a.doanhThuHomNay).Sum();
                return kq;
            }
        }

        public static long tinhTongLaiTheoThang()
        {
            using (var db = new SieuThiDBDataContext())
            {
                var kq = (from a in db.DoanhThus
                          where a.ngayThongKe.Month == DateTime.Now.Month
                          select a.tienLaiHomNay).Sum();
                return kq;
            }
        }
    }
}
