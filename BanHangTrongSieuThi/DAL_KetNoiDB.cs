using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Application;
using System.Windows.Forms;

namespace BanHangTrongSieuThi
{
    class DAL_KetNoiDB
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader sqldr;
        DataSet ds = new DataSet();
        SqlDataAdapter sqlda;
        private SqlTransaction tran = null;
        public DAL_KetNoiDB()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-I269IGU\SQLEXPRESS;Initial Catalog=bhst;Integrated Security=True");
        }

        /// <summary>
        /// M? k?t n?i
        /// </summary>
        public void Open()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        /// <summary>
        /// Đóng k?t n?i
        /// </summary>
        public void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
        /// <summary>
        /// Đ?m s? c?t tr? v? khi select
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public object GetValue(string query)
        {
            Open();
            cmd = new SqlCommand(query, conn);
            return cmd.ExecuteScalar();
        }
        /// <summary>
        /// Th?c thi câu l?nh sql
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public void ExcuteNonQuery(string query)
        {
            Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            Close();
        }
        /// <summary>
        /// Tr? v? 1 b?ng khi select
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetDataTable(string query)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataSet GetDataSet(string query, string dsName)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.Fill(ds, dsName);
            return ds;
        }
        /// <summary>
        /// Th?c hi?n l?nh sql truy?n qua Parameter
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pr"></param>
        /// <returns></returns>
        public int doSQL(string sql, params SqlParameter[] pr)
        {
            SqlCommand command = new SqlCommand();
            int ret = 0;
            Open();

            command.Connection = conn;
            command.CommandText = sql;

            foreach (SqlParameter p in pr)
            {
                command.Parameters.Add(p);
            }
            try
            {
                ret = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            return ret;
        }

        public int doStoredProceduce(string storeName, params SqlParameter[] pr) // th?c hi?n th? t?c lưu tr? cho các tham s? tương ?ng
        {
            SqlCommand cm = new SqlCommand();
            int ret = 0;
            Open();
            if (ret < 0)
            {
                return -2;
            }
            cm.Connection = conn;
            cm.CommandText = storeName;
            cm.CommandType = CommandType.StoredProcedure; // các câu l?nh sql trư?c m?c đ?nh là command text nên không c?n ph?i g?i commandtype
            if (tran != null) // neu co transaction roi thi chay.
            {
                cm.Transaction = tran;
            }
            foreach (SqlParameter p in pr)
            {
                cm.Parameters.Add(p);
            }
            try
            {
                ret = cm.ExecuteNonQuery();
                return 0;
            }
            catch (Exception ex)
            {
                ret = -1;
            }
            return ret;
        }
        public void loadtextbox(TextBox cb, string strselect)
        {
            Open();
            cmd = new SqlCommand(strselect, conn);
            sqldr = cmd.ExecuteReader();
            while (sqldr.Read())
            {
                cb.Text = sqldr[0].ToString();
            }
            Close();

        }
        public void loaddatagridview(DataGridView dg, string strselect)
        {
            ds.Clear();
            sqlda = new SqlDataAdapter(strselect, conn);
            sqlda.Fill(ds, "tenbang");
            dg.DataSource = ds.Tables[0];
        }
    }
}
