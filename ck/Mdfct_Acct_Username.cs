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

namespace Contact_Manage
{
    public partial class Mdfct_Acct_Username : Form
    {
        public Mdfct_Acct_Username()
        {
            InitializeComponent();
        }

        //点击此文本框时跳出当前登录名
        private void tB_Username_MouseClick(object sender, MouseEventArgs e)
        {
            tB_Username.Text = Login.txtLogin_Username;
        }

        //点击此文本框时跳出当前登录名
        private void tB_NewUsername_MouseClick(object sender, MouseEventArgs e)
        {
            tB_Username.Text = Login.txtLogin_Username;
        }

        private void btt_Modfct_Username_Click(object sender, EventArgs e)
        {
            //获取用户输入的新用户名
            String newUsername = tB_NewUsername.Text;
            if (newUsername == "")
            {
                MessageBox.Show("请输入新用户名！");
                return;
            }

            //连接数据库更改用户名
            String sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "update Account set Account_Username='" + newUsername + "' where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            int eq = com.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("修改成功!");
                this.Close();
                Login.txtLogin_Username = newUsername;
            }
            else MessageBox.Show("修改失败！");

        }

    }
}