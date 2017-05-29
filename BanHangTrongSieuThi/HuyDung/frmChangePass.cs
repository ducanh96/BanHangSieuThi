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
    public partial class frmChangePass : Form
    {
        SieuThiDBDataContext data = new SieuThiDBDataContext(); 
        public frmChangePass()
        {
            InitializeComponent();
        }
        public frmChangePass(string username)
        {
            InitializeComponent();

            txtTenDN.Text = username;
            txtTenDN.ReadOnly = true;
        }
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

            if (txtMKold.Text == "")
            {
                lblThongBao.Text = "Bạn phải nhập mật khẩu cũ";
                return;
            }
            if(txtMKnew.Text == "")
            {
                lblThongBao.Text = "Bạn phải nhập mật khẩu mới";
                return;
            }
            if(txtMKnewConfirm.Text == "")
            {
                lblThongBao.Text = "Bạn phải xác nhận mật khẩu mới";
                return;
            }
            
            var acc = (from i in data.DangNhaps
                        where i.Username == txtTenDN.Text
                        select i
                        ).SingleOrDefault();
            //string MKold = GetMd5(txtMKold.Text);
            //string MKnew = GetMd5(txtMKnew.Text);
            //if(MKold != acc.Password)
            //{
            //    lblThongBao.Text = "Nhập mật khẩu cũ sai";
            //    return;
            //}
            //if(MKnew == MKold)
            //{
            //    lblThongBao.Text = "Mật khẩu mới phải khác mật khẩu cũ";
            //    return;
            //}

            if (txtMKold.Text != acc.Password)
            {
                lblThongBao.Text = "Nhập mật khẩu cũ sai";
                return;
            }
            if (txtMKnew.Text == txtMKold.Text)
            {
                lblThongBao.Text = "Mật khẩu mới phải khác mật khẩu cũ";
                return;
            }
            if (txtMKnewConfirm.Text != txtMKnew.Text)
            {
                lblThongBao.Text = "Xác thực mật khẩu mới không chính xác";
                return;
            }


            acc.Password = txtMKnew.Text;
            data.SubmitChanges();
            this.Hide();
    

        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            Validation();
        }
    }
}
