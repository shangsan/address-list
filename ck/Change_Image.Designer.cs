namespace Contact_Manage
{
    partial class Change_Image
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
            this.btt_Change_Image = new System.Windows.Forms.Button();
            this.btt_Select_Image = new System.Windows.Forms.Button();
            this.pictrB_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictrB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // btt_Change_Image
            // 
            this.btt_Change_Image.Location = new System.Drawing.Point(59, 200);
            this.btt_Change_Image.Name = "btt_Change_Image";
            this.btt_Change_Image.Size = new System.Drawing.Size(101, 38);
            this.btt_Change_Image.TabIndex = 0;
            this.btt_Change_Image.Text = "确认";
            this.btt_Change_Image.UseVisualStyleBackColor = true;
            // 
            // btt_Select_Image
            // 
            this.btt_Select_Image.Location = new System.Drawing.Point(152, 81);
            this.btt_Select_Image.Name = "btt_Select_Image";
            this.btt_Select_Image.Size = new System.Drawing.Size(92, 35);
            this.btt_Select_Image.TabIndex = 1;
            this.btt_Select_Image.Text = "选择";
            this.btt_Select_Image.UseVisualStyleBackColor = true;
            // 
            // pictrB_Image
            // 
            this.pictrB_Image.Location = new System.Drawing.Point(8, 66);
            this.pictrB_Image.Name = "pictrB_Image";
            this.pictrB_Image.Size = new System.Drawing.Size(95, 69);
            this.pictrB_Image.TabIndex = 2;
            this.pictrB_Image.TabStop = false;
            // 
            // Change_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pictrB_Image);
            this.Controls.Add(this.btt_Select_Image);
            this.Controls.Add(this.btt_Change_Image);
            this.Name = "Change_Image";
            this.Text = "更改头像";
            ((System.ComponentModel.ISupportInitialize)(this.pictrB_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btt_Change_Image;
        private System.Windows.Forms.Button btt_Select_Image;
        private System.Windows.Forms.PictureBox pictrB_Image;
    }
}