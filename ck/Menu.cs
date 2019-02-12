using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Manage
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btt_Add_Contact_Click(object sender, EventArgs e)
        {
            AddContact add = new AddContact();
            add.Show();
        }

        private void btt_Manage_Contact_Click(object sender, EventArgs e)
        {
            Contact_Manage query = new Contact_Manage();
            query.Show();
        }

        //修改密码
        private void btt_Modification_Password_Click(object sender, EventArgs e)
        {
            Modification_Password modif_Pwd = new Modification_Password();
            modif_Pwd.Show();
        }

        //更换头像
        private void btt_Change_Image_Click(object sender, EventArgs e)
        {
            Change_Image cImg = new Change_Image();
            cImg.Show();
        }

        //修改账户名
        private void btt_Mdfct_Username_Click(object sender, EventArgs e)
        {
            Mdfct_Acct_Username m = new Mdfct_Acct_Username();
            m.Show();
        }

      
    }
}