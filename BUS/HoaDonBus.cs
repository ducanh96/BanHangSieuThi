using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class HoaDonBus
    {
        #region Them Hoa don
        public static bool InsertHoaDon(HoaDon hd)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    db.HoaDons.InsertOnSubmit(hd);
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

        #region Them hang xuat
        public static bool InsertHangBan(HangBan hb)
        {
            try
            {
                using (SieuThiDBDataContext db = new SieuThiDBDataContext())
                {
                    
                    db.HangBans.InsertOnSubmit(hb);
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
    }
}
