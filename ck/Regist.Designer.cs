namespace Contact_Manage
{
    partial class Regist
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_Regist_Username = new System.Windows.Forms.TextBox();
            this.tB_Regist_Password2 = new System.Windows.Forms.TextBox();
            this.tB_Regist_Password1 = new System.Windows.Forms.TextBox();
            this.pctrB_Regist_Image = new System.Windows.Forms.PictureBox();
            this.btt_ChangeImage = new System.Windows.Forms.Button();
            this.btt_Regist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Regist_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // tB_Regist_Username
            // 
            this.tB_Regist_Username.Location = new System.Drawing.Point(97, 52);
            this.tB_Regist_Username.Name = "tB_Regist_Username";
            this.tB_Regist_Username.Size = new System.Drawing.Size(220, 21);
            this.tB_Regist_Username.TabIndex = 3;
            // 
            // tB_Regist_Password2
            // 
            this.tB_Regist_Password2.Location = new System.Drawing.Point(97, 112);
            this.tB_Regist_Password2.Name = "tB_Regist_Password2";
            this.tB_Regist_Password2.Size = new System.Drawing.Size(220, 21);
            this.tB_Regist_Password2.TabIndex = 4;
            // 
            // tB_Regist_Password1
            // 
            this.tB_Regist_Password1.Location = new System.Drawing.Point(97, 79);
            this.tB_Regist_Password1.Name = "tB_Regist_Password1";
            this.tB_Regist_Password1.Size = new System.Drawing.Size(220, 21);
            this.tB_Regist_Password1.TabIndex = 5;
            // 
            // pctrB_Regist_Image
            // 
            this.pctrB_Regist_Image.Location = new System.Drawing.Point(388, 60);
            this.pctrB_Regist_Image.Name = "pctrB_Regist_Image";
            this.pctrB_Regist_Image.Size = new System.Drawing.Size(125, 55);
            this.pctrB_Regist_Image.TabIndex = 6;
            this.pctrB_Regist_Image.TabStop = false;
            // 
            // btt_ChangeImage
            // 
            this.btt_ChangeImage.Location = new System.Drawing.Point(392, 159);
            this.btt_ChangeImage.Name = "btt_ChangeImage";
            this.btt_ChangeImage.Size = new System.Drawing.Size(80, 34);
            this.btt_ChangeImage.TabIndex = 7;
            this.btt_ChangeImage.Text = "更换头像";
            this.btt_ChangeImage.UseVisualStyleBackColor = true;
            // 
            // btt_Regist
            // 
            this.btt_Regist.Location = new System.Drawing.Point(86, 194);
            this.btt_Regist.Name = "btt_Regist";
            this.btt_Regist.Size = new System.Drawing.Size(108, 33);
            this.btt_Regist.TabIndex = 8;
            this.btt_Regist.Text = "注册";
            this.btt_Regist.UseVisualStyleBackColor = true;
            // 
            // Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 262);
            this.Controls.Add(this.btt_Regist);
            this.Controls.Add(this.btt_ChangeImage);
            this.Controls.Add(this.pctrB_Regist_Image);
            this.Controls.Add(this.tB_Regist_Password1);
            this.Controls.Add(this.tB_Regist_Password2);
            this.Controls.Add(this.tB_Regist_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Regist";
            this.Text = "注册";
            ((System.ComponentModel.ISupportInitialize)(this.pctrB_Regist_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_Regist_Username;
        private System.Windows.Forms.TextBox tB_Regist_Password2;
        private System.Windows.Forms.TextBox tB_Regist_Password1;
        private System.Windows.Forms.PictureBox pctrB_Regist_Image;
        private System.Windows.Forms.Button btt_ChangeImage;
        private System.Windows.Forms.Button btt_Regist;
    }
}