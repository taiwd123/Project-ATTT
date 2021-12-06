using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATTT_CuoiKy.Classes
{
    class Account
    {
        private string user;
        private string pass;
        private string role;

        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Role { get => role; set => role = value; }

        MyDB myDB = new MyDB();

        public string CheckAccount(string user, string pass)
        {
            string check = "";
            SqlCommand command = new SqlCommand("select * from account where username = @user and pass = @pass", myDB.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                check = dt.Rows[0].ItemArray[3].ToString();
            }
            return check;
        }

        public bool insertAcc(string user, string pass, string role)
        {
            SqlCommand command = new SqlCommand("insert into account(username, pass, roleuser) values(@user, @pass, @role)", myDB.getConnection);
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            command.Parameters.Add("@role", SqlDbType.VarChar).Value = role;

            myDB.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                myDB.closeConnection();
                return true;
            }
            else
            {
                myDB.closeConnection();
                return false;
            }
        }

        public DataTable getAllAccount()
        {
            SqlCommand command = new SqlCommand("select * from account ", myDB.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
