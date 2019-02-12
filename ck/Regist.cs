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
    public partial class Regist : Form
    {
        //默认头像路径
        public static String imagePath = "F:/VS设计/Contact_Manage/images/1.jpeg";
        public Regist()
        {
            InitializeComponent();
        }

        private void btt_Regist_Click(object sender, EventArgs e)
        {
            //获取用户注册输入的用户名和密码
            String regist_Username = tB_Regist_Username.Text;
            String regist_Password1 = tB_Regist_Password1.Text;
            string regist_Password2 = tB_Regist_Password2.Text;

            //判断是否输入了用户名和密码
            if (regist_Username == "" || regist_Password1 == "" || regist_Password2 == "")
            {
                MessageBox.Show("请输入用户名和密码！");
                return;
            }

            //判断两次输入的密码是否一致
            if (!regist_Password1.Equals(regist_Password2))
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                return;
            }


            //连接数据库，判断用户名是否已存在
            string sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888";
            String sqlcom = " select * from Account where Account_Username='" + regist_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();

            SqlDataReader reader = com.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("用户名已存在，请重新输入用户名！");
                return;
            }
            reader.Close();



            //验证通过，将用户输入的数据添加进入数据库
            String sqlcom2 = " insert into Account(Account_Username,Account_Password,Account_Image) values('" + regist_Username + "','" + regist_Password1 + "','" + imagePath + "')";
            SqlCommand com2 = new SqlCommand(sqlcom2, con);
            int eq = com2.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("注册成功！将跳转到登录页面！");
                this.Close();
            }
            con.Close();

        }

        //当点击用户名文本框时给pictureBox中放置一张默认的图片
        private void tB_Regist_Username_MouseClick(object sender, MouseEventArgs e)
        {
            //如果pictureBox为空时显示默认图片
            if (pctrB_Regist_Image.Image == null)
            {
                String imagePath = "F:/VS设计/Contact_Manage/images/1.jpeg";
                pctrB_Regist_Image.Image = Image.FromFile(imagePath);
                pctrB_Regist_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        private void btt_ChangeImage_Click(object sender, EventArgs e)
        {

            //自定义OpenFileDialog打开Windows文件对话框选择文件，并保存路径
            OpenFileDialog f = new OpenFileDialog();
            f.InitialDirectory = Application.StartupPath + @"\images";
            f.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
            {
                imagePath = f.FileName.ToString();
                //将更换的图片显示在注册页面
                pctrB_Regist_Image.Image = Image.FromFile(imagePath);
                //将图片居中显示
                pctrB_Regist_Image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return;
        }

        
    }
}