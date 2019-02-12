namespace Contact_Manage
{
    partial class Menu
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
            this.btt_Add_Contact = new System.Windows.Forms.Button();
            this.btt_Manage_Contact = new System.Windows.Forms.Button();
            this.btt_Modification_Password = new System.Windows.Forms.Button();
            this.btt_Change_Image = new System.Windows.Forms.Button();
            this.btt_Mdfct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btt_Add_Contact
            // 
            this.btt_Add_Contact.Location = new System.Drawing.Point(75, 24);
            this.btt_Add_Contact.Name = "btt_Add_Contact";
            this.btt_Add_Contact.Size = new System.Drawing.Size(77, 31);
            this.btt_Add_Contact.TabIndex = 0;
            this.btt_Add_Contact.Text = "添加";
            this.btt_Add_Contact.UseVisualStyleBackColor = true;
            // 
            // btt_Manage_Contact
            // 
            this.btt_Manage_Contact.Location = new System.Drawing.Point(75, 71);
            this.btt_Manage_Contact.Name = "btt_Manage_Contact";
            this.btt_Manage_Contact.Size = new System.Drawing.Size(77, 31);
            this.btt_Manage_Contact.TabIndex = 1;
            this.btt_Manage_Contact.Text = "管理";
            this.btt_Manage_Contact.UseVisualStyleBackColor = true;
            // 
            // btt_Modification_Password
            // 
            this.btt_Modification_Password.Location = new System.Drawing.Point(75, 108);
            this.btt_Modification_Password.Name = "btt_Modification_Password";
            this.btt_Modification_Password.Size = new System.Drawing.Size(77, 31);
            this.btt_Modification_Password.TabIndex = 2;
            this.btt_Modification_Password.Text = "修改密码";
            this.btt_Modification_Password.UseVisualStyleBackColor = true;
            // 
            // btt_Change_Image
            // 
            this.btt_Change_Image.Location = new System.Drawing.Point(75, 156);
            this.btt_Change_Image.Name = "btt_Change_Image";
            this.btt_Change_Image.Size = new System.Drawing.Size(77, 31);
            this.btt_Change_Image.TabIndex = 3;
            this.btt_Change_Image.Text = "更改头像";
            this.btt_Change_Image.UseVisualStyleBackColor = true;
            // 
            // btt_Mdfct
            // 
            this.btt_Mdfct.Location = new System.Drawing.Point(75, 205);
            this.btt_Mdfct.Name = "btt_Mdfct";
            this.btt_Mdfct.Size = new System.Drawing.Size(77, 31);
            this.btt_Mdfct.TabIndex = 4;
            this.btt_Mdfct.Text = "修改账户名";
            this.btt_Mdfct.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btt_Mdfct);
            this.Controls.Add(this.btt_Change_Image);
            this.Controls.Add(this.btt_Modification_Password);
            this.Controls.Add(this.btt_Manage_Contact);
            this.Controls.Add(this.btt_Add_Contact);
            this.Name = "Menu";
            this.Text = "菜单";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Add_Contact;
        private System.Windows.Forms.Button btt_Manage_Contact;
        private System.Windows.Forms.Button btt_Modification_Password;
        private System.Windows.Forms.Button btt_Change_Image;
        private System.Windows.Forms.Button btt_Mdfct;
    }
}