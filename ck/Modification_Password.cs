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
    //修改密码
    public partial class Modification_Password : Form
    {
        public Modification_Password()
        {
            InitializeComponent();
        }

        //修改密码事件
        private void btt_Modification_Password_Click(object sender, EventArgs e)
        {
            //获取当前登录用户的登录名
            String modification_Username = Login.txtLogin_Username;

            //获取用户输入的登录密码以及两次新密码
            String login_Pwd = tB_Modif_Password.Text;
            String modif_NewPwd1 = tB_Modif_NewPassword.Text;
            String modif_NewPwd2 = tB_Modif_NewPassword2.Text;

            //判断是否输入了原密码
            if (login_Pwd == "")
            {
                MessageBox.Show("请输入密码！");
                return;
            }

            //连接数据库验证原密码是否正确
            String sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888;";
            String sqlcom = "select * from Account where Account_Password='" + login_Pwd + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("原登录密码错误，请重新输入！");
                return;
            }
            con.Close();

            //判断用户是否输入了新密码
            if (modif_NewPwd1 == "" || modif_NewPwd2 == "")
            {
                MessageBox.Show("请输入新密码！");
                return;
            }

            //判断两次输入的新密码是否一致
            if (!modif_NewPwd1.Equals(modif_NewPwd2))
            {
                MessageBox.Show("你两次输入的新密码不一致，请重新输入！");
                return;
            }

            //验证通过，进行修改密码操作
            String sqlcom2 = "update Account set Account_Password='" + modif_NewPwd1 + "' where Account_Username='" + modification_Username + "'";
            SqlConnection con2 = new SqlConnection(sqlcon);
            SqlCommand com2 = new SqlCommand(sqlcom2, con2);
            con2.Open();
            int eq = com2.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("修改密码成功思密达！");
                this.Close();
            }
            else MessageBox.Show("修改密码失败思密达！");

            con2.Close();
        }

        //当点击这个文本框时，将用户名显示
        private void tB_Modif_Password_MouseClick(object sender, MouseEventArgs e)
        {
            //获取当前登录用户的登录名
            String modification_Username = Login.txtLogin_Username;
            tB_Modif_Username.Text = modification_Username;
        }

        //当点击这个文本框时，也将用户名显示
        private void tB_Modif_Username_MouseClick(object sender, MouseEventArgs e)
        {
            //获取当前登录用户的登录名
            String modification_Username = Login.txtLogin_Username;
            tB_Modif_Username.Text = modification_Username;
        }

      
    }
}