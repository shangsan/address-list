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
    /// 登录
    /// </summary>
    public partial class Login : Form
    {
        //存取用户登录名
        public static String txtLogin_Username;
        public Login()
        {
            InitializeComponent();
        }

        //登录
        private void btt_Login_Click(object sender, EventArgs e)
        {
            //获取用户输入的用户名和密码
            txtLogin_Username = tB_Account_Username.Text;
            String password = tB_Account_Password.Text;

            if (txtLogin_Username == "" || password == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }

            //连接数据库进行数据判断
            string sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888";
            String sqlcom = " select * from Account where Account_Username='" + txtLogin_Username + "' and Account_password='" + password + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                //打开菜单页面
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！");
            }
            con.Close();

            //清空文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        //注册账号事件
        private void lb_Regist_Click(object sender, EventArgs e)
        {
            Regist rigist = new Regist();
            rigist.Show();
        }

        //注销账户事件
        private void lb_Logout_Click(object sender, EventArgs e)
        {
            //跳出注销界面，验证输入的用户名及密码是否正确
            Logout logout = new Logout();
            logout.Show();

        }

        //点击密码文本框时将登录头像显示在pictureBox控件中
        private void tB_Account_Password_MouseClick(object sender, MouseEventArgs e)
        {
            //获取输入的用户名
            String username = tB_Account_Username.Text;

            if (username != "")
            {
                //连接数据库，如果该用户名存在则将头像显示
                string sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888";
                String sqlcom = " select * from Account where Account_Username='" + username + "'";
                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com = new SqlCommand(sqlcom, con);
                con.Open();

                SqlDataReader reader = com.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    //连接数据库，获取该用户名的头像保存路径

                    //连接数据库
                    string sqlcon2 = "server=.;database=phone_Book;uid=sa;pwd=666888";
                    String sqlcom2 = "select Account_Image from Account where Account_Username='" + username + "'";
                    SqlConnection con2 = new SqlConnection(sqlcon2);
                    SqlCommand com2 = new SqlCommand(sqlcom2, con2);
                    con2.Open();
                    //返回结果集的第一行第一列
                    object obj = com2.ExecuteScalar();
                    //将数据库中读取到的路径放入变量中
                    String image_Path = obj.ToString();

                    con2.Close();

                    pctrB_Image.Image = Image.FromFile(image_Path);
                    //将图片居中显示
                    pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                else
                {
                    MessageBox.Show("用户名不存在，请重新输入！");
                }
                con.Close();

            }


        }

    }
}