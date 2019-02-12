namespace Contact_Manage
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tB_Account_Username = new System.Windows.Forms.TextBox();
            this.tB_Account_Password = new System.Windows.Forms.TextBox();
            this.pctrB_Image = new System.Windows.Forms.PictureBox();
            this.btt_Login = new System.Windows.Forms.Button();
            this.lb_Regist = new System.Windows.Forms.Button();
            this.lb_Logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // tB_Account_Username
            // 
            this.tB_Account_Username.Location = new System.Drawing.Point(113, 61);
            this.tB_Account_Username.Name = "tB_Account_Username";
            this.tB_Account_Username.Size = new System.Drawing.Size(120, 21);
            this.tB_Account_Username.TabIndex = 0;
            // 
            // tB_Account_Password
            // 
            this.tB_Account_Password.Location = new System.Drawing.Point(113, 98);
            this.tB_Account_Password.Name = "tB_Account_Password";
            this.tB_Account_Password.Size = new System.Drawing.Size(120, 21);
            this.tB_Account_Password.TabIndex = 1;
            // 
            // pctrB_Image
            // 
            this.pctrB_Image.Location = new System.Drawing.Point(2, 59);
            this.pctrB_Image.Name = "pctrB_Image";
            this.pctrB_Image.Size = new System.Drawing.Size(46, 59);
            this.pctrB_Image.TabIndex = 2;
            this.pctrB_Image.TabStop = false;
            // 
            // btt_Login
            // 
            this.btt_Login.Location = new System.Drawing.Point(113, 147);
            this.btt_Login.Name = "btt_Login";
            this.btt_Login.Size = new System.Drawing.Size(70, 30);
            this.btt_Login.TabIndex = 3;
            this.btt_Login.Text = "登录 ";
            this.btt_Login.UseVisualStyleBackColor = true;
            // 
            // lb_Regist
            // 
            this.lb_Regist.Location = new System.Drawing.Point(202, 148);
            this.lb_Regist.Name = "lb_Regist";
            this.lb_Regist.Size = new System.Drawing.Size(70, 27);
            this.lb_Regist.TabIndex = 4;
            this.lb_Regist.Text = "注销";
            this.lb_Regist.UseVisualStyleBackColor = true;
            // 
            // lb_Logout
            // 
            this.lb_Logout.Location = new System.Drawing.Point(4, 150);
            this.lb_Logout.Name = "lb_Logout";
            this.lb_Logout.Size = new System.Drawing.Size(74, 25);
            this.lb_Logout.TabIndex = 5;
            this.lb_Logout.Text = "注册";
            this.lb_Logout.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lb_Logout);
            this.Controls.Add(this.lb_Regist);
            this.Controls.Add(this.btt_Login);
            this.Controls.Add(this.pctrB_Image);
            this.Controls.Add(this.tB_Account_Password);
            this.Controls.Add(this.tB_Account_Username);
            this.Name = "Login";
            this.Text = "登陆";
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Account_Username;
        private System.Windows.Forms.TextBox tB_Account_Password;
        private System.Windows.Forms.PictureBox pctrB_Image;
        private System.Windows.Forms.Button btt_Login;
        private System.Windows.Forms.Button lb_Regist;
        private System.Windows.Forms.Button lb_Logout;
    }
}

