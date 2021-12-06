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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap form = new DangNhap();
            form.Show();
            this.SetVisibleCore(false);
        }

        private void DangKy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(!rdMD5.Checked && !rdSHA1.Checked && !rdSHA2.Checked && !rdRIPEMD.Checked)
            {
                MessageBox.Show("Chọn cách Hash để lưu mật khẩu!!!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string user = textUser.Text.Trim();
                string pass = textPass.Text.Trim();
                string confi = textConf.Text.Trim();

                if(checkVilidate(user, pass, confi))
                {
                    if(pass == confi)
                    {
                        string hashpass = HashPass(pass);
                        if (acc.insertAcc(user, hashpass, "user"))
                        {
                            MessageBox.Show("Đăng ký thành công !!!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Đăng ký không thành công !!!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu xác nhật không trùng khớp !!!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin !!!", "Đăng Ký", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool checkVilidate(string user, string pass, string confi)
        {
            if (user == "" || pass == "" || confi == "")
            {
                return false;
            }
            return true;
        }
        Account acc = new Account();
        Hash hash = new Hash();
        private string HashPass(string pass)
        {
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
            return hashpass;
        }
    }
}
