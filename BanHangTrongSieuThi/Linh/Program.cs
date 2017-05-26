using BanHangTrongSieuThi;
using BanHangTrongSieuThi.Duc_Anh;
using BanHangTrongSieuThi.Khoa;
using BanHangTrongSieuThi.Linh;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangTrongSieuThi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHangHoa());
        }
    }
}
