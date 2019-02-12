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
    /// 添加联系人
    /// </summary>
    public partial class AddContact : Form
    {
        public AddContact()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断是否有必填项目未输入的情况
            if (tB_Name.Text.Length == 0 && tB_Phone.Text.Length == 0)
            {
                MessageBox.Show("姓名电话必须填写！");
                return;
            }

            string sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888";
            string sqlcom = "INSERT INTO Contact (Contact_Name,Contact_QQ,Contact_Phone,Contact_Email,Account_Username) VALUES('"
                + tB_Name.Text + "','" + tB_QQ.Text + "','" + tB_Phone.Text + "','" + tB_Email.Text + "','" + Login.txtLogin_Username + "')";
            //执行添加操作
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            int eq = com.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("添加成功!");
            }
            con.Close();


            //清空所有文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

       
    }
}