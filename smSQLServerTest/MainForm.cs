using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//添加引用

namespace smSQLServerTest
{
    public partial class MainForm : Form
    {
        SqlConnection myconnection;//定义一个数据库连接对象
        public MainForm()
        {
            InitializeComponent();
        }
        //数据库连接
        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {                
                myconnection = new SqlConnection("Integrated Security=SSPI;Initial Catalog=人事管理系统;Data Source=SHAOYONG-PC\\MYSQLSERVER;User ID=sa;Password=gis123");
                myconnection.Open();     //打开数据库 
                label1.Text = "数据库连接成功！";   
            }
            catch (Exception ee)
            {
                MessageBox.Show("数据库连接失败！" + ee.ToString());
            }
        }

        private void btQueryAll_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "select * From 部门表";
                SqlDataAdapter objDataAdpter = new SqlDataAdapter();
                objDataAdpter.SelectCommand = new SqlCommand(strSQL, myconnection);
                DataSet ds = new DataSet();
                objDataAdpter.Fill(ds, "部门表");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show("查询失败！" + ee.ToString());
            }
        }

        private void btInsertToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL1 = "insert into 部门表(部门名,部门号,管理者) values('销售部',97003,'李四')";
                SqlDataAdapter objDataAdpter = new SqlDataAdapter();
                SqlCommand thisCommand = new SqlCommand(strSQL1, myconnection);
                thisCommand.ExecuteNonQuery();
                string strSQL2 = "select * From 部门表";
                SqlDataAdapter objDataAdpter1 = new SqlDataAdapter();
                objDataAdpter1.SelectCommand = new SqlCommand(strSQL2, myconnection);
                DataSet ds = new DataSet();
                objDataAdpter1.Fill(ds, "部门表");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show("插入数据失败！" + ee.ToString());
            }
        }

        private void btModifiFeildValue_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL1 = "update 部门表 set 管理者='张五' where 部门号=97002";
                SqlCommand thisCommand = new SqlCommand(strSQL1, myconnection);
                thisCommand.ExecuteNonQuery();
                string strSQL2 = "select * From 部门表";
                SqlDataAdapter objDataAdpter1 = new SqlDataAdapter();
                objDataAdpter1.SelectCommand = new SqlCommand(strSQL2, myconnection);
                DataSet ds = new DataSet();
                objDataAdpter1.Fill(ds, "部门表");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show("更新数据失败！" + ee.ToString());
            }
        }

        private void btDeleteFeildValue_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL1 = "delete from 部门表 where 部门号=97002";
                SqlCommand thisCommand = new SqlCommand(strSQL1, myconnection);
                thisCommand.ExecuteNonQuery();
                string strSQL2 = "select * From 部门表";
                SqlDataAdapter objDataAdpter1 = new SqlDataAdapter();
                objDataAdpter1.SelectCommand = new SqlCommand(strSQL2, myconnection);
                DataSet ds = new DataSet();
                objDataAdpter1.Fill(ds, "部门表");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ee)
            {
                MessageBox.Show("删除数据失败！" + ee.ToString());
            }
        }
        /// <summary>
        //断开与SQL Server数据库的连接
        /// </summary>
        public string DisConnect()
        {
            string Result;
            try
            {
                myconnection.Close();
                Result = "数据连接已断开！";
            }
            catch (Exception e)
            {
                MessageBox.Show("数据库断开失败！" + e.ToString());
                Result = "连接成功！";
            }
            return Result;
        }

        private void btDisConnect_Click(object sender, EventArgs e)
        {
            label1.Text = DisConnect();
        }

       
    }
}
