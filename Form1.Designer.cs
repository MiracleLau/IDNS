namespace IDNS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startServerButton = new System.Windows.Forms.Button();
            this.stopServerButton = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.setting = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.启动服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(6, 24);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(100, 33);
            this.startServerButton.TabIndex = 0;
            this.startServerButton.Text = "开启服务";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.StartServer_Click);
            // 
            // stopServerButton
            // 
            this.stopServerButton.Location = new System.Drawing.Point(112, 24);
            this.stopServerButton.Name = "stopServerButton";
            this.stopServerButton.Size = new System.Drawing.Size(100, 33);
            this.stopServerButton.TabIndex = 0;
            this.stopServerButton.Text = "关闭服务";
            this.stopServerButton.UseVisualStyleBackColor = true;
            this.stopServerButton.Click += new System.EventHandler(this.StopServer_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.Black;
            this.log.ForeColor = System.Drawing.Color.Lime;
            this.log.Location = new System.Drawing.Point(6, 24);
            this.log.MaxLength = 999999999;
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log.Size = new System.Drawing.Size(528, 284);
            this.log.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startServerButton);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.about);
            this.groupBox1.Controls.Add(this.setting);
            this.groupBox1.Controls.Add(this.stopServerButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(425, 24);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 33);
            this.exit.TabIndex = 0;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(322, 24);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 33);
            this.about.TabIndex = 0;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.About_Click);
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(218, 24);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(100, 33);
            this.setting.TabIndex = 0;
            this.setting.Text = "高级设置";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.log);
            this.groupBox2.Location = new System.Drawing.Point(12, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 317);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(565, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 20);
            this.statusLabel.Text = "statusText";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "IDNS已最小化到托盘区";
            this.notifyIcon1.BalloonTipTitle = "提示";
            this.notifyIcon1.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon1_MouseDoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.启动服务ToolStripMenuItem,
            this.停止服务ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(139, 76);
            // 
            // 启动服务ToolStripMenuItem
            // 
            this.启动服务ToolStripMenuItem.Name = "启动服务ToolStripMenuItem";
            this.启动服务ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.启动服务ToolStripMenuItem.Text = "启动服务";
            this.启动服务ToolStripMenuItem.Click += new System.EventHandler(this.启动服务ToolStripMenuItem_Click);
            // 
            // 停止服务ToolStripMenuItem
            // 
            this.停止服务ToolStripMenuItem.Name = "停止服务ToolStripMenuItem";
            this.停止服务ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.停止服务ToolStripMenuItem.Text = "停止服务";
            this.停止服务ToolStripMenuItem.Click += new System.EventHandler(this.停止服务ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 438);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(583, 485);
            this.MinimumSize = new System.Drawing.Size(583, 485);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDNS By Radiation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.Button stopServerButton;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem 启动服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button exit;
    }
}

