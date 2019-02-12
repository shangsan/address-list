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
    /// <summary>
    /// 注销用户界面
    /// </summary>
    public partial class Logout : Form
    {
        //注销账号名
        public static string txtLogoutName;
        public Logout()
        {
            InitializeComponent();
        }


        private void btt_Logout_Click(object sender, EventArgs e)
        {
            //获取用户输入的将要注销的用户名及密码
            String logout_Username = tB_Logout_Username.Text;
            String logout_Password = tB_Logout_Password.Text;

            //判断是否输入了用户名及密码
            if (logout_Username == "" || logout_Password == "")
            {
                MessageBox.Show("请输入要注销的用户名和密码！");
                return;
            }

            //连接数据库进行数据验证
            String sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "select * from Account where Account_Username='" + logout_Username + "' and Account_Password='" + logout_Password + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //如果密码以及用户名正确，提示用户是否确认注销，确定之后将该用户从数据库中删除
                txtLogoutName = tB_Logout_Username.Text;
                Affirm affirm = new Affirm();
                affirm.Show();

            }
            else { MessageBox.Show("你输入的用户名或密码不正确，请重新输入！"); }

            //清空所有文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            con.Close();

        }

       
    }
}