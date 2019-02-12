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
using System.Configuration;


namespace Contact_Manage
{
    public partial class Contact_Manage : Form
    {
        //数据库连接字符串
        string sqlcon = "server=.;database=phone_Book;uid=sa;pwd=666888";
        public Contact_Manage()
        {
            InitializeComponent();
        }
        //查询事件
        private void button1_Click(object sender, EventArgs e)
        {
            string condition = " 1=1";
            //姓名
            if (tB_Name.Text != "")
                condition = condition + " and Contact_Name like'" + tB_Name.Text + "%'";
            //电话
            if (tB_Phone.Text != "")
                condition = condition + " and Contact_Phone like'" + tB_Phone.Text + "%'";
            //QQ
            if (tB_QQ.Text != "")
                condition = condition + " and Contact_QQ like'" + tB_QQ.Text + "%'";
            //Email
            if (tB_Email.Text != "")
                condition = condition + " and Contact_Email like'" + tB_Email.Text + "%'";
            //ID
            if (tB_ID.Text != "")
            {
                condition = condition + " and Contact_ID='" + tB_ID.Text + "'";
            }
            string sqlcom = "select * from Contact where" + condition;

            SqlConnection con = new SqlConnection(sqlcon);
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sqlcom, con);
            //设置默认列不显示
            //dataGridView1.AutoGenerateColumns = false;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "cs");
            dataGridView1.DataSource = ds.Tables["cs"];//绑定

            con.Close();

            //清空所有文本框
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

            //显示用户名
            lb_Username.Text = Login.txtLogin_Username;

            String sqlcom2 = "select Account_Image from Account where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con2 = new SqlConnection(sqlcon);
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

        //修改事件
        private void btt_Modification_Click(object sender, EventArgs e)
        {

            //获取用户输入的要修改的联系人ID
            String modification_ID = tB_ID.Text;
            //如果文本框为空，则说明用户没有点击联系人
            if (modification_ID != "")
            {
                String condition = "";
                //姓名
                /* if (tB_Name.Text != "")
                     condition = condition + ",Contact_Name='" + tB_Name.Text + "'";*/
                //电话
                if (tB_Phone.Text != "")
                    condition = condition + ",Contact_Phone='" + tB_Phone.Text + "'";
                //QQ
                if (tB_QQ.Text != "")
                    condition = condition + ",Contact_QQ='" + tB_QQ.Text + "'";
                //Email
                if (tB_Email.Text != "")
                    condition = condition + ",Contact_Email='" + tB_Email.Text + "'";

                String sqlcom = "update Contact set Contact_Name='" + tB_Name.Text + "'" + condition + " where Contact_ID = '" + modification_ID + "'";

                SqlConnection con = new SqlConnection(sqlcon);
                SqlCommand com = new SqlCommand(sqlcom, con);
                con.Open();
                int eq = com.ExecuteNonQuery();
                if (eq != 0)
                {
                    MessageBox.Show("修改成功思密达！");
                }
                else MessageBox.Show("修改失败思密达！");
                con.Close();

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }
            else MessageBox.Show("请先点击联系人再进行修改操作！");

        }

        //删除事件
        private void btt_Delete_Click(object sender, EventArgs e)
        {
            //获取用户输入的要删除的联系人ID
            String delete_ID = tB_ID.Text;

            //连接数据库将该联系人数据删除
            String sqlcom = "delete from Contact where Contact_ID='" + delete_ID + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            int eq = com.ExecuteNonQuery();
            if (eq != 0)
            {
                MessageBox.Show("删除成功思密达！");
            }
            else MessageBox.Show("删除失败思密达！");
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

        //提示用户进行联系人管理时的操作说明 并显示用户名和头像
        private void btt_Hint_Click(object sender, EventArgs e)
        {
            //显示用户名
            lb_Username.Text = Login.txtLogin_Username;

            String sqlcom = "select Account_Image from Account where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            //返回结果集的第一行第一列
            object obj = com.ExecuteScalar();
            //将数据库中读取到的路径放入变量中
            String image_Path = obj.ToString();

            con.Close();
            pctrB_Image.Image = Image.FromFile(image_Path);
            //将图片居中显示
            pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;

            MessageBox.Show("查询：文本框全为空时，点击查询将列出所有数据，除ID之外都为模糊查询。\r删除：点击要删除的行。\r修改：ID不可改");
        }

        private void tB_Name_MouseClick(object sender, MouseEventArgs e)
        {
            //显示用户名
            lb_Username.Text = Login.txtLogin_Username;

            String sqlcom = "select Account_Image from Account where Account_Username='" + Login.txtLogin_Username + "'";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlCommand com = new SqlCommand(sqlcom, con);
            con.Open();
            //返回结果集的第一行第一列
            object obj = com.ExecuteScalar();
            //将数据库中读取到的路径放入变量中
            String image_Path = obj.ToString();

            con.Close();
            pctrB_Image.Image = Image.FromFile(image_Path);
            //将图片居中显示
            pctrB_Image.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tB_ID.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tB_Name.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tB_QQ.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tB_Phone.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tB_Email.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Contact_Manage_Load(object sender, EventArgs e)
        {

        }
    }
}