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
    public partial class UserForm : Form
    {
        private string duoifile;
        public UserForm()
        {
            InitializeComponent();
        }

        Hash hash = new Hash();

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                int i;
                textFile.Text = openFile.FileName;
                for (i = textFile.Text.Length - 1; i > 0; i--)
                    if (textFile.Text[i] == '.')
                        break;
                duoifile = textFile.Text.Substring(i, textFile.Text.Length - i);

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if(!rdMD5.Checked && !rdSHA1.Checked && !rdSHA2.Checked && !rdRIPEMD.Checked)
            {
                MessageBox.Show("Chọn cách Hash để Hash File!!!", "Mã hóa file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(textFile.Text.Trim() == "")
                {
                    MessageBox.Show("Chọn File để Hash!!!", "Mã hóa file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string filename = textFile.Text.Trim();
                    string kq = "";
                    if (rdMD5.Checked)
                    {
                        kq = hash.GetMD5HashFromFile(filename);
                    }
                    else
                    {
                        if (rdSHA1.Checked)
                        {
                            kq = hash.GetSHA1HashFromFile(filename);
                        }
                        else
                        {
                            if (rdSHA2.Checked)
                            {
                                kq = hash.GetSHA2HashFromFile(filename);
                            }
                            else
                            {
                                kq = hash.GetRIPEMD160HashFromFile(filename);
                            }
                        }
                    }
                    textKQ.Text = kq;
                }
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                int i;
                textKT.Text = openFile.FileName;
                for (i = textKT.Text.Length - 1; i > 0; i--)
                    if (textKT.Text[i] == '.')
                        break;
                duoifile = textKT.Text.Substring(i, textKT.Text.Length - i);

            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string kqCheck = "";
            string kq = "";
            if (!rdMD5KT.Checked && !rdSHA1KT.Checked && !rdSHA2KT.Checked && !rdRIPEMDKT.Checked)
            {
                MessageBox.Show("Chọn cách mà File được Hash để kiểm tra!!!", "Kiểm tra file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textKT.Text.Trim() == "")
                {
                    MessageBox.Show("Chọn File để kiểm tra!!!", "Kiểm tra file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(textHashGoc.Text.Trim() == "")
                    {
                        MessageBox.Show("Nhập mã hash gốc của file để kiểm tra!!!", "Kiểm tra file", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        string filename = textKT.Text.Trim();
                        string hashgoc = textHashGoc.Text.Trim().ToUpper();
                        if (rdMD5KT.Checked)
                        {
                            kq = hash.GetMD5HashFromFile(filename);
                        }
                        else
                        {
                            if (rdSHA1KT.Checked)
                            {
                                kq = hash.GetSHA1HashFromFile(filename);
                            }
                            else
                            {
                                if (rdSHA2KT.Checked)
                                {
                                    kq = hash.GetSHA2HashFromFile(filename);
                                }
                                else
                                {
                                    kq = hash.GetRIPEMD160HashFromFile(filename);
                                }
                            }
                        }

                        if(kq.Trim() == hashgoc)
                        {
                            kqCheck = "File cần kiểm tra: " + filename + "\n\nKết quả kiểm tra: Dữ liệu chưa bị thay đổi -- FILE AN TOÀN";
                        }
                        else
                        {
                            kqCheck = "File cần kiểm tra: " + filename + "\n\nKết quả kiểm tra: Dữ Đã liệu chưa bị thay đổi -- FILE KHÔNG AN TOÀN \n\n" +
                                "Warning: Cẩn thận! File có thể chứ mã độc";
                        }
                        textTB.Text = kqCheck;
                    }
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
