using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BanHangTrongSieuThi
{
    public partial class nhacungcap : Form
    {
        private string ma;
        private DAL_KetNoiDB conn;
        public nhacungcap()
        {
            conn = new DAL_KetNoiDB();
            InitializeComponent();
        }
        SqlConnection kn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=bhst;Integrated Security=True");

        private void ketnoi()
        {

            kn.Open();

            string sql = "	SELECT *FROM nhacungcap";
            SqlCommand com = new SqlCommand(sql, kn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kn.Close();

            dataGridView1.DataSource = dt;
        }
        private void getDataFromDgv()
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Chưa ch?n b?n ghi");
                return;
            }
            DataGridViewRow drv = dataGridView1.SelectedRows[0];
            DataRowView drview = (DataRowView)drv.DataBoundItem;
            if (drview == null)
            {
                MessageBox.Show("Không lấy đư?c dữ liêu");
                return;
            }
            DataRow dr = drview.Row;
            if (dr == null)
            {
                MessageBox.Show("Không lấy được dữ liêu");
                return;
            }

            ma = dr["ma"].ToString();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string diachi = txtdiachi.Text;
            string sodienthoai = txtSodienthoai.Text;
            string masothue = txtMathue.Text;
            string fax =txtFax.Text;
           


            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.NVarChar);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@tennhacungcap", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@diachi", SqlDbType.NVarChar);
            param.Value = diachi;
            listParams.Add(param);

            param = new SqlParameter("sodienthoai", SqlDbType.VarChar);
            param.Value = sodienthoai;
            listParams.Add(param);

            param = new SqlParameter("@fax", SqlDbType.NVarChar);
            param.Value = fax;
            listParams.Add(param);

            param = new SqlParameter("@masothue", SqlDbType.NVarChar);
            param.Value = masothue;
            listParams.Add(param);

        


            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn thêm", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce("ADD_NhaCC", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi thêm", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    nhacungcap_Load(sender, e);
                }
            }


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string diachi = txtdiachi.Text;
            string sodienthoai = txtSodienthoai.Text;
            string masothue = txtMathue.Text;
            string fax = txtFax.Text;



            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.NVarChar);
            param.Value = ma;
            listParams.Add(param);

            param = new SqlParameter("@tennhacungcap", SqlDbType.NVarChar);
            param.Value = ten;
            listParams.Add(param);

            param = new SqlParameter("@diachi", SqlDbType.NVarChar);
            param.Value = diachi;
            listParams.Add(param);

            param = new SqlParameter("sodienthoai", SqlDbType.VarChar);
            param.Value = sodienthoai;
            listParams.Add(param);

            param = new SqlParameter("@fax", SqlDbType.NVarChar);
            param.Value = fax;
            listParams.Add(param);

            param = new SqlParameter("@masothue", SqlDbType.NVarChar);
            param.Value = masothue;
            listParams.Add(param);


            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doStoredProceduce(" Up_NCC", listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi sửa", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    nhacungcap_Load(sender, e);
                }
            }




        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {

            ketnoi();
            LoadData();
        }
        private void LoadData()
        {
            txtMa.DataBindings.Clear();
            txtMa.DataBindings.Add("text", dataGridView1.DataSource, "ma");
            txtTen.DataBindings.Clear();
            txtTen.DataBindings.Add("text", dataGridView1.DataSource, "tennhacungcap");
            txtMathue.DataBindings.Clear();
            txtMathue.DataBindings.Add("text", dataGridView1.DataSource, "masothue");
            txtSodienthoai.DataBindings.Clear();
            txtSodienthoai.DataBindings.Add("text", dataGridView1.DataSource, "sodienthoai");
            txtFax.DataBindings.Clear();
            txtFax.DataBindings.Add("text", dataGridView1.DataSource, "fax");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("text", dataGridView1.DataSource, "diachi");


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               dataGridView1.CurrentRow.Selected = true;

            }
            catch
            {

            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            getDataFromDgv();
            string sqlxoa = "Delete from nhacungcap where ma='" + ma + "'";
            List<SqlParameter> listParams = new List<SqlParameter>();
            int ret = 0;

            SqlParameter param;
            param = new SqlParameter("@ma", SqlDbType.VarChar);
            param.Value = ma;
            listParams.Add(param);

            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ret = conn.doSQL(sqlxoa, listParams.ToArray());
                kn.Close();
                if (ret < 0)
                {
                    MessageBox.Show("Lỗi khi xoá", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    nhacungcap_Load(sender, e);
                }
            }
            else
            {
                this.Close();
            }
        }
    }

    
}
