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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        Account acc = new Account();

        private void AdminForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            DGV_Acc.DataSource = acc.getAllAccount();
            DGV_Acc.ReadOnly = true;
            DGV_Acc.AllowUserToAddRows = false;
            DGV_Acc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Acc.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            DGV_Acc.Columns[0].HeaderText = "ID";
            DGV_Acc.Columns[1].HeaderText = "Username";
            DGV_Acc.Columns[2].HeaderText = "Password";
            DGV_Acc.Columns[3].HeaderText = "Role";
            DGV_Acc.Columns[0].Width = 50;
            DGV_Acc.Columns[1].Width = 100;
            DGV_Acc.Columns[2].Width = 708;
            DGV_Acc.Columns[3].Width = 50;

            DGV_Acc.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Acc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Acc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Acc.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }
    }
}
