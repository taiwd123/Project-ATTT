using ATTT_CuoiKy.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT_CuoiKy
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy form = new DangKy();
            form.Show();
            this.SetVisibleCore(false);
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        Account acc = new Account();
        Hash hash = new Hash();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            

            string user = TextUser.Text.Trim();
            string pass = TextPass.Text.Trim();
            string hashpass = "";
            if (rdMD5.Checked)
            {
                hashpass = hash.CreateMD5(pass);
            }
            else
            {
                if (rdSHA1.Checked)
                {
                    hashpass = hash.CreateSHA1(pass);
                }
                else
                {
                    if (rdSHA2.Checked)
                    {
                        hashpass = hash.CreateSha256(pass);
                    }
                    else
                    {
                        hashpass = hash.CreateRIPEMD160(pass);
                    }
                }
            }
            string role = acc.CheckAccount(user, hashpass);
            if (role.Equals(""))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng Nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (role.Equals("admin"))
                {
                    AdminForm frm = new AdminForm();
                    frm.Show();
                    this.SetVisibleCore(false);
                }
                else
                {
                    UserForm frm = new UserForm();
                    frm.Show();
                    this.SetVisibleCore(false);
                }
            }
        }
    }
}
