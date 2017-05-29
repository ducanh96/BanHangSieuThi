using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangTrongSieuThi.HuyDung
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SieuThiDBDataContext data = new SieuThiDBDataContext();
        public string GetMd5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] byteHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder encryptHash = new StringBuilder();
            foreach (var item in byteHash)
            {
                encryptHash.Append(String.Format("{0:x2}", item));
            }
            return encryptHash.ToString();
        }
        public void Validation()
        {
            if(txtTenDN.Text == "")
            {
                lblThongBao.Text = "Bạn phải nhập tên đăng nhập";
                return ;
            }
            else if(txtMatKhau.Text == "")
            {
                lblThongBao.Text = "Bạn phải nhập mật khẩu";
                return;
            }
            else if(txtMatKhau.Text != "" && txtTenDN.Text != "")
            {
                string MK = GetMd5(txtMatKhau.Text);
                var kiemTra = (from i in data.DangNhaps
                               where i.Username == txtTenDN.Text.Trim() && i.Password == MK.Trim()
                               select i).SingleOrDefault();

                if (kiemTra == null)
                {
                    lblThongBao.Text = "Tên đăng nhập hoặc mật khẩu không đúng";
                    return;
                }
            }

            this.Hide();
            frmChangePass newForm = new frmChangePass(txtTenDN.Text);
            newForm.ShowDialog();
            this.Close();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Validation();            
        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                Validation();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Validation();
            }
        }
    }
}
