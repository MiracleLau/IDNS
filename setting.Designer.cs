namespace IDNS
{
    partial class setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.autoStart = new System.Windows.Forms.CheckBox();
            this.autoStartServer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Location = new System.Drawing.Point(40, 33);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(89, 19);
            this.autoStart.TabIndex = 0;
            this.autoStart.Text = "开机自启";
            this.autoStart.UseVisualStyleBackColor = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.AutoStart_CheckedChanged);
            // 
            // autoStartServer
            // 
            this.autoStartServer.AutoSize = true;
            this.autoStartServer.Location = new System.Drawing.Point(40, 93);
            this.autoStartServer.Name = "autoStartServer";
            this.autoStartServer.Size = new System.Drawing.Size(194, 19);
            this.autoStartServer.TabIndex = 1;
            this.autoStartServer.Text = "软件启动后自动运行服务";
            this.autoStartServer.UseVisualStyleBackColor = true;
            this.autoStartServer.CheckedChanged += new System.EventHandler(this.AutoStartServer_CheckedChanged);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 157);
            this.Controls.Add(this.autoStartServer);
            this.Controls.Add(this.autoStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(353, 204);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(353, 204);
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高级设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoStart;
        private System.Windows.Forms.CheckBox autoStartServer;
    }
}