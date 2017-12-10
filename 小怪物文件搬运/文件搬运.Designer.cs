namespace 小怪物文件搬运
{
    partial class 文件搬运
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(文件搬运));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tc_mian = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_run = new System.Windows.Forms.Button();
            this.tb_log = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_t = new System.Windows.Forms.Button();
            this.btn_s = new System.Windows.Forms.Button();
            this.tb_t = new System.Windows.Forms.TextBox();
            this.tb_s = new System.Windows.Forms.TextBox();
            this.tc_mian.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件原始地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1189, 266);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // tc_mian
            // 
            this.tc_mian.Controls.Add(this.tabPage1);
            this.tc_mian.Controls.Add(this.tabPage2);
            this.tc_mian.Location = new System.Drawing.Point(12, 12);
            this.tc_mian.Name = "tc_mian";
            this.tc_mian.SelectedIndex = 0;
            this.tc_mian.Size = new System.Drawing.Size(1420, 661);
            this.tc_mian.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1412, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "说明";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_run);
            this.tabPage2.Controls.Add(this.tb_log);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btn_t);
            this.tabPage2.Controls.Add(this.btn_s);
            this.tabPage2.Controls.Add(this.tb_t);
            this.tabPage2.Controls.Add(this.tb_s);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1412, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文件搬运";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(1275, 116);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(80, 30);
            this.btn_run.TabIndex = 11;
            this.btn_run.Text = "开始";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(166, 116);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.Size = new System.Drawing.Size(1103, 506);
            this.tb_log.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "记录";
            // 
            // btn_t
            // 
            this.btn_t.Location = new System.Drawing.Point(1275, 63);
            this.btn_t.Name = "btn_t";
            this.btn_t.Size = new System.Drawing.Size(80, 30);
            this.btn_t.TabIndex = 5;
            this.btn_t.Text = "浏览";
            this.btn_t.UseVisualStyleBackColor = true;
            this.btn_t.Click += new System.EventHandler(this.btn_t_Click);
            // 
            // btn_s
            // 
            this.btn_s.Location = new System.Drawing.Point(1275, 13);
            this.btn_s.Name = "btn_s";
            this.btn_s.Size = new System.Drawing.Size(80, 30);
            this.btn_s.TabIndex = 4;
            this.btn_s.Text = "浏览";
            this.btn_s.UseVisualStyleBackColor = true;
            this.btn_s.Click += new System.EventHandler(this.btn_s_Click);
            // 
            // tb_t
            // 
            this.tb_t.Location = new System.Drawing.Point(166, 64);
            this.tb_t.Name = "tb_t";
            this.tb_t.Size = new System.Drawing.Size(1103, 29);
            this.tb_t.TabIndex = 3;
            // 
            // tb_s
            // 
            this.tb_s.Location = new System.Drawing.Point(166, 14);
            this.tb_s.Name = "tb_s";
            this.tb_s.Size = new System.Drawing.Size(1103, 29);
            this.tb_s.TabIndex = 2;
            // 
            // 文件搬运
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 685);
            this.Controls.Add(this.tc_mian);
            this.Font = new System.Drawing.Font("隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "文件搬运";
            this.Text = "小怪物文件搬运";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.文件搬运_FormClosing);
            this.tc_mian.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tc_mian;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_t;
        private System.Windows.Forms.Button btn_s;
        private System.Windows.Forms.TextBox tb_t;
        private System.Windows.Forms.TextBox tb_s;
        private System.Windows.Forms.TextBox tb_log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_run;
    }
}

