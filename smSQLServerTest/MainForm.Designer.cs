namespace smSQLServerTest
{
    partial class MainForm
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
            this.btConnect = new System.Windows.Forms.Button();
            this.btQueryAll = new System.Windows.Forms.Button();
            this.btInsertToDatabase = new System.Windows.Forms.Button();
            this.btModifiFeildValue = new System.Windows.Forms.Button();
            this.btDeleteFeildValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btDisConnect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(24, 44);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 0;
            this.btConnect.Text = "连接";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btQueryAll
            // 
            this.btQueryAll.Location = new System.Drawing.Point(116, 44);
            this.btQueryAll.Name = "btQueryAll";
            this.btQueryAll.Size = new System.Drawing.Size(75, 23);
            this.btQueryAll.TabIndex = 1;
            this.btQueryAll.Text = "查询";
            this.btQueryAll.UseVisualStyleBackColor = true;
            this.btQueryAll.Click += new System.EventHandler(this.btQueryAll_Click);
            // 
            // btInsertToDatabase
            // 
            this.btInsertToDatabase.Location = new System.Drawing.Point(210, 44);
            this.btInsertToDatabase.Name = "btInsertToDatabase";
            this.btInsertToDatabase.Size = new System.Drawing.Size(75, 23);
            this.btInsertToDatabase.TabIndex = 2;
            this.btInsertToDatabase.Text = "插入";
            this.btInsertToDatabase.UseVisualStyleBackColor = true;
            this.btInsertToDatabase.Click += new System.EventHandler(this.btInsertToDatabase_Click);
            // 
            // btModifiFeildValue
            // 
            this.btModifiFeildValue.Location = new System.Drawing.Point(302, 44);
            this.btModifiFeildValue.Name = "btModifiFeildValue";
            this.btModifiFeildValue.Size = new System.Drawing.Size(75, 23);
            this.btModifiFeildValue.TabIndex = 3;
            this.btModifiFeildValue.Text = "修改";
            this.btModifiFeildValue.UseVisualStyleBackColor = true;
            this.btModifiFeildValue.Click += new System.EventHandler(this.btModifiFeildValue_Click);
            // 
            // btDeleteFeildValue
            // 
            this.btDeleteFeildValue.Location = new System.Drawing.Point(395, 44);
            this.btDeleteFeildValue.Name = "btDeleteFeildValue";
            this.btDeleteFeildValue.Size = new System.Drawing.Size(75, 23);
            this.btDeleteFeildValue.TabIndex = 4;
            this.btDeleteFeildValue.Text = "删除";
            this.btDeleteFeildValue.UseVisualStyleBackColor = true;
            this.btDeleteFeildValue.Click += new System.EventHandler(this.btDeleteFeildValue_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "操作状态";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(544, 241);
            this.dataGridView1.TabIndex = 6;
            // 
            // btDisConnect
            // 
            this.btDisConnect.Location = new System.Drawing.Point(493, 44);
            this.btDisConnect.Name = "btDisConnect";
            this.btDisConnect.Size = new System.Drawing.Size(75, 23);
            this.btDisConnect.TabIndex = 7;
            this.btDisConnect.Text = "断开连接";
            this.btDisConnect.UseVisualStyleBackColor = true;
            this.btDisConnect.Click += new System.EventHandler(this.btDisConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 357);
            this.Controls.Add(this.btDisConnect);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDeleteFeildValue);
            this.Controls.Add(this.btModifiFeildValue);
            this.Controls.Add(this.btInsertToDatabase);
            this.Controls.Add(this.btQueryAll);
            this.Controls.Add(this.btConnect);
            this.Name = "MainForm";
            this.Text = "SQLServerTest";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btQueryAll;
        private System.Windows.Forms.Button btInsertToDatabase;
        private System.Windows.Forms.Button btModifiFeildValue;
        private System.Windows.Forms.Button btDeleteFeildValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btDisConnect;

    }
}

