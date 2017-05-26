using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangTrongSieuThi.Duc_Anh
{
    public partial class FrmHangHoa : Form
    {
        public List<Hang> data;
        List<Hang> dataFilter;
        public FrmHangHoa()
        {
            InitializeComponent();
            data = HangBus.GetListHang();
            dgvHang.DataSource = data;
            dataFilter = data;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmCreateHangHoa create = new FrmCreateHangHoa();
            create.Show();
        }
    }
}
