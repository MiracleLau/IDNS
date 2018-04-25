using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using ARSoft.Tools.Net.Dns;
using System.Net;
using System.Diagnostics;
using ARSoft.Tools.Net;
using System.IO;
using System.Runtime.Caching;

namespace IDNS
{
    public partial class Form1 : Form
    {
        private DnsServer server = new DnsServer(10, 10);
        private bool isRun = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            StartServer(0);
            
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
            StopServer(0);

        }

#pragma warning disable CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        static async Task  OnQueryReceived(object sender, QueryReceivedEventArgs e)
#pragma warning restore CS1998 // 异步方法缺少 "await" 运算符，将以同步方式运行
        {
            DnsMessage query = e.Query as DnsMessage;
            if (query == null)
                return;
            DnsMessage response = query.CreateResponseInstance();
            if (query.Questions.Count == 1)
            {
                if (query.Questions[0].RecordType == RecordType.A)
                {
                    string url = query.Questions[0].Name.ToString();
                    ObjectCache oc = MemoryCache.Default;
                    string ips = oc[url] as string;
                    if (ips == null)
                    {
                        CacheItemPolicy cip = new CacheItemPolicy();
                        cip.AbsoluteExpiration = DateTime.Now.AddMinutes(10);
                        HttpClient client = new HttpClient();
                        var responseString = client.GetStringAsync("http://119.29.29.29/d?dn=" + url);
                        ips = responseString.Result;
                        oc.Set(url, ips, cip);
                    }
                    if (ips != "")
                    {
                        response.ReturnCode = ReturnCode.NoError;
                        var Allip = ips.Split(';');
                        for(int i = 0; i < Allip.Count(); i++)
                        {
                            response.AnswerRecords.Add(new ARecord(DomainName.Parse(url), 600, IPAddress.Parse(Allip[i])));
                        }
                        
                    }
                    else
                    {
                        response.ReturnCode = ReturnCode.ServerFailure;
                    }
                    
                }else{
                    response.ReturnCode = ReturnCode.ServerFailure;
                }
            }
            e.Response = response;
        }

        //向日志文本框中写入日志
        private void SendLog(string msg)
        {
            log.Text += msg + "\r\n";
        }

        //主窗体加载事件
        private void Form1_Load(object sender, EventArgs e)
        {
            SendLog("程序准备就绪");
            SetStatus();
            if (File.Exists("auto"))
            {
                StartServer(0);
            }
        }

        //托盘图标双击显示主窗体
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                this.Show();
                this.WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        //最小化后的提示
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
                this.notifyIcon1.ShowBalloonTip(3000);
            }
        }

        //托盘右键菜单停止服务的点击事件
        private void 停止服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopServer(1);  
        }

        //托盘右键菜单退出程序的点击事件
        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        //托盘右键菜单启动服务的点击事件
        private void 启动服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartServer(1);
        }

        /// <summary>
        /// 显示右下角提示
        /// </summary>
        /// <param name="msg">显示的内容</param>
        private void SendNotify(String msg)
        {
            this.notifyIcon1.BalloonTipText = msg;
            this.notifyIcon1.ShowBalloonTip(2000);
        }

        /// <summary>
        /// 设置服务状态
        /// </summary>
        private void SetStatus()
        {
            if (isRun)
            {
                statusLabel.Text = "正在运行";
                statusLabel.ForeColor = Color.Green;
                this.notifyIcon1.Text = "服务正在运行";
            }
            else
            {
                statusLabel.Text = "未运行";
                statusLabel.ForeColor = Color.Red;
                this.notifyIcon1.Text = "服务未运行";
            }
        }

        //设置按钮点击事件
        private void Setting_Click(object sender, EventArgs e)
        {
            var setForm = new setting();
            setForm.Show();
        }

        //关于按钮点击事件
        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者:Radiation\r\n博客:b.zlweb.cc\r\n使用：开启服务后，将网卡的dns服务器设置为127.0.0.1即可。");
        }

        /// <summary>
        /// 启动本地DNS服务
        /// </summary>
        /// <param name="i">是否显示右下角提示，1提示，不填不提示</param>
        private void StartServer(int i=0)
        {
            SendLog("开始启动DNS服务...");
            if (isRun)
            {
                SendLog("服务已运行");
                if(i==1)
                    SendNotify("服务已运行");
            }
            else
            {
                server.QueryReceived += OnQueryReceived;
                try
                {
                    server.Start();
                    SendLog("启动成功，服务开始运行");
                    if (i == 1)
                        SendNotify("启动成功，服务开始运行");
                    this.isRun = true;
                    SetStatus();
                }
                catch (Exception ex)
                {
                    SendLog("启动失败!错误:" + ex.Message);
                    if (i == 1)
                        SendNotify("启动失败!错误:" + ex.Message);

                }
            }
        }
        
        /// <summary>
        /// 停止本地DNS服务
        /// </summary>
        /// <param name="i">是否显示右下角提示，1提示，不填或其他不提示</param>
        private void StopServer(int i=0)
        {
            SendLog("尝试关闭DNS服务...");
            if (isRun)
            {
                try
                {
                    server.Stop();
                    SendLog("关闭成功!");
                    this.isRun = false;
                    SetStatus();
                    if(i==1)
                        SendNotify("成功关闭服务!");
                }
                catch (Exception ex)
                {
                    SendLog("错误:" + ex.Message);
                    if(i==1)
                        SendNotify("错误:" + ex.Message);
                }
            }
            else
            {
                SendLog("服务没有运行，无需关闭！");
                if(i==1)
                    SendNotify("服务没有运行，无需关闭！");
            }
        }

        //退出按钮点击事件
        private void exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

    }
}
