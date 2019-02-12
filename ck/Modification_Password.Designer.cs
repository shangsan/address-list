namespace Contact_Manage
{
    partial class Modification_Password
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
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Modif_Username = new System.Windows.Forms.TextBox();
            this.tB_Modif_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_Modif_NewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Modif_NewPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btt_Modification_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前用户";
            // 
            // tB_Modif_Username
            // 
            this.tB_Modif_Username.Location = new System.Drawing.Point(164, 41);
            this.tB_Modif_Username.Name = "tB_Modif_Username";
            this.tB_Modif_Username.Size = new System.Drawing.Size(146, 21);
            this.tB_Modif_Username.TabIndex = 1;
            // 
            // tB_Modif_Password
            // 
            this.tB_Modif_Password.Location = new System.Drawing.Point(164, 82);
            this.tB_Modif_Password.Name = "tB_Modif_Password";
            this.tB_Modif_Password.Size = new System.Drawing.Size(146, 21);
            this.tB_Modif_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "原密码";
            // 
            // tB_Modif_NewPassword
            // 
            this.tB_Modif_NewPassword.Location = new System.Drawing.Point(164, 121);
            this.tB_Modif_NewPassword.Name = "tB_Modif_NewPassword";
            this.tB_Modif_NewPassword.Size = new System.Drawing.Size(146, 21);
            this.tB_Modif_NewPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "修改密码";
            // 
            // tB_Modif_NewPassword2
            // 
            this.tB_Modif_NewPassword2.Location = new System.Drawing.Point(164, 161);
            this.tB_Modif_NewPassword2.Name = "tB_Modif_NewPassword2";
            this.tB_Modif_NewPassword2.Size = new System.Drawing.Size(146, 21);
            this.tB_Modif_NewPassword2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "确认密码";
            // 
            // btt_Modification_Password
            // 
            this.btt_Modification_Password.Location = new System.Drawing.Point(131, 209);
            this.btt_Modification_Password.Name = "btt_Modification_Password";
            this.btt_Modification_Password.Size = new System.Drawing.Size(75, 23);
            this.btt_Modification_Password.TabIndex = 8;
            this.btt_Modification_Password.Text = "修改";
            this.btt_Modification_Password.UseVisualStyleBackColor = true;
            // 
            // Modification_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.btt_Modification_Password);
            this.Controls.Add(this.tB_Modif_NewPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tB_Modif_NewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_Modif_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tB_Modif_Username);
            this.Controls.Add(this.label1);
            this.Name = "Modification_Password";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Modif_Username;
        private System.Windows.Forms.TextBox tB_Modif_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tB_Modif_NewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Modif_NewPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btt_Modification_Password;
    }
}