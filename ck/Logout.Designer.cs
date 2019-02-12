namespace Contact_Manage
{
    partial class Logout
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
            this.lable1 = new System.Windows.Forms.Label();
            this.btt_Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Logout_Username = new System.Windows.Forms.TextBox();
            this.tB_Logout_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(10, 38);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(89, 12);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "要注销的用户名";
            // 
            // btt_Logout
            // 
            this.btt_Logout.Location = new System.Drawing.Point(87, 187);
            this.btt_Logout.Name = "btt_Logout";
            this.btt_Logout.Size = new System.Drawing.Size(87, 30);
            this.btt_Logout.TabIndex = 1;
            this.btt_Logout.Text = "注销";
            this.btt_Logout.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "确认密码";
            // 
            // tB_Logout_Username
            // 
            this.tB_Logout_Username.Location = new System.Drawing.Point(119, 38);
            this.tB_Logout_Username.Name = "tB_Logout_Username";
            this.tB_Logout_Username.Size = new System.Drawing.Size(150, 21);
            this.tB_Logout_Username.TabIndex = 3;
            // 
            // tB_Logout_Password
            // 
            this.tB_Logout_Password.Location = new System.Drawing.Point(111, 75);
            this.tB_Logout_Password.Name = "tB_Logout_Password";
            this.tB_Logout_Password.Size = new System.Drawing.Size(157, 21);
            this.tB_Logout_Password.TabIndex = 4;
            // 
            // Logout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tB_Logout_Password);
            this.Controls.Add(this.tB_Logout_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_Logout);
            this.Controls.Add(this.lable1);
            this.Name = "Logout";
            this.Text = "注销";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button btt_Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Logout_Username;
        private System.Windows.Forms.TextBox tB_Logout_Password;
    }
}