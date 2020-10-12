using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region 窗体拖拽 api

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        #endregion

        #region 注册快捷键 api

        [System.Runtime.InteropServices.DllImport("Kernel32.dll")]
        public static extern Int32 GlobalAddAtom(string lpString);// 向全局原子表添加一个字符串，并返回这个字符串的唯一标识符（原子ATOM）。

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);// 注册热键

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);// 取消热键注册

        public int 热键ID = 0;

        public enum 控制键类型 : uint
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            Windows = 8
        }

        #endregion

        #region 全局变量


        public Form2 背景窗体 = new Form2();
        public Form3 截图窗体 = new Form3();

        public enum 翻译类型
        {
            有道翻译,
            搜狗翻译
        }

        public 翻译类型 翻译类型枚举 = 翻译类型.有道翻译;


        #endregion

        #region 快捷键响应

        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    截图();
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }

        #endregion

        #region 截图

        #endregion

        private void 截图()
        {
            if (this.Visible)
            {
                this.隐藏();
            }

            截图窗体.截图();

            if (!this.Visible)
            {
                this.显示();
            }
        }

        public void 翻译()
        {
            输出盒子.Text = "";

            if (输入盒子.Text.Trim() == "")
            {
                输出盒子.Text = "     未输入";
                return;
            }
            if (翻译类型枚举 == 翻译类型.有道翻译)
            {
                有道翻译();
                return;
            }
            if (翻译类型枚举 == 翻译类型.搜狗翻译)
            {
                搜狗翻译();
                return;
            }
        }

        public void 搜狗翻译()
        {
            try
            {

                WebClient 客户端 = new WebClient();
                客户端.Credentials = CredentialCache.DefaultCredentials;//设置网络凭据

                Byte[] 网页数据 = 客户端.DownloadData("https://fanyi.sogou.com/?keyword=" + 输入盒子.Text.Trim()); //下载数据

                string 网页文本数据 = Encoding.UTF8.GetString(网页数据);

                网页文本数据 = 网页文本数据.Substring(网页文本数据.IndexOf("\"output-val\"") + 56);

                网页文本数据 = 网页文本数据.Substring(0, 网页文本数据.IndexOf("</p>"));

                输出盒子.Text = 网页文本数据.Trim();
                return;
            }
            catch (WebException webEx)
            {
                输出盒子.Text = webEx.Message.ToString();
            }
        }
        public void 有道翻译()
        {
            try
            {
                #region 获取网页

                WebClient 客户端 = new WebClient();
                客户端.Credentials = CredentialCache.DefaultCredentials;//设置网络凭据

                Byte[] 网页数据 = 客户端.DownloadData("http://dict.youdao.com/search?q=" + 输入盒子.Text.Trim()); //下载数据

                string 网页文本数据 = Encoding.UTF8.GetString(网页数据);

                string 网页文本数据副本 = 网页文本数据;
                int P索引 = 网页文本数据副本.IndexOf("\"phonetic\"");
                string 输出文本 = "";

                #endregion

                #region 截取音标

                if (P索引 > 0)
                {
                    网页文本数据副本 = 网页文本数据副本.Substring(P索引 + 11);

                    int S索引 = 网页文本数据副本.IndexOf("</span>");
                    if (S索引 >= 0)
                        输出文本 = "     英:" + 网页文本数据副本.Substring(0, S索引) + "     ";
                }

                P索引 = 网页文本数据副本.IndexOf("\"phonetic\"");

                if (P索引 > 0)
                {
                    网页文本数据副本 = 网页文本数据副本.Substring(P索引 + 11);

                    int S索引 = 网页文本数据副本.IndexOf("</span>");
                    if (S索引 >= 0)
                        输出文本 += "美:" + 网页文本数据副本.Substring(0, S索引) + "\r\n";
                }

                #endregion

                #region 截取翻译

                int C索引 = 网页文本数据.IndexOf("class=\"trans-container\"");
                if (C索引 == -1)
                {
                    输出盒子.Text = "     无结果";
                    return;
                }


                网页文本数据副本 = 网页文本数据.Substring(C索引 + 25);
                网页文本数据副本 = 网页文本数据副本.Substring(0, 网页文本数据副本.IndexOf("</div>") - 3);

                网页文本数据副本 = 网页文本数据副本.Replace("<li>", "").Replace("</li>", "").Replace("<ul>", "").Replace("</ul>", "").Replace("\n", "\r\n");

                int A索引 = 网页文本数据副本.IndexOf("class=\"additional\"");
                if (A索引 >= 0)
                {
                    网页文本数据副本 = 网页文本数据副本.Substring(0, A索引 - 3);
                }

                int P2索引 = 网页文本数据副本.IndexOf("</p>");
                if (P2索引 >= 0)
                {
                    网页文本数据副本 = 网页文本数据副本.Substring(P2索引 + 10);
                }
                P2索引 = 网页文本数据副本.IndexOf("</p>");
                if (P2索引 >= 0)
                {
                    网页文本数据副本 = 网页文本数据副本.Substring(0, P2索引);
                }

                int S2索引 = 网页文本数据副本.IndexOf("<span class=\"def\">");
                if (S2索引 >= 0)
                {
                    输出盒子.Text = "     无结果";
                    return;
                }

                #endregion

                输出盒子.Text = 输出文本 + "\r\n     " + 网页文本数据副本.Trim();
                return;
            }
            catch (WebException webEx)
            {
                输出盒子.Text = webEx.Message.ToString();
            }
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Thread 翻译线程 = new Thread(new ThreadStart(this.翻译));
                翻译线程.Start();
            }
        }

        #region 其他

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (截图窗体.Visible)
            {
                垃圾回收();
            }
            else
            {
                截图();
            }
        }
        public Form1()
        {
            //transparencyKey 颜色的R值不能等于B值，这样就可实现透明鼠标又不会穿透的效果！
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            背景窗体.Show();
            背景窗体.TopMost = true;
            this.TopMost = true;
            输入盒子.Focus();
            输入盒子.Select();
            CheckForIllegalCrossThreadCalls = false;  //允许跨线程访问

            //注：HotKeyId的合法取之范围是0x0000到0xBFFF之间，GlobalAddAtom函数得到的值在0xC000到0xFFFF之间，所以减掉0xC000来满足调用要求。
            this.热键ID = GlobalAddAtom("Screenshot") - 0xC000;   //注册快捷键

            if (this.热键ID == 0)
                this.热键ID = 0xBFFE;//如果获取失败，设定一个默认值；

            RegisterHotKey(Handle, 热键ID, (uint)控制键类型.Control | (uint)控制键类型.Alt, Keys.A);

        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
                System.Environment.Exit(0);
            if (((MouseEventArgs)e).Button == MouseButtons.Right)
                Application.Restart();
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            Thread 主窗体跟随拖动线程 = new Thread(new ThreadStart(this.主窗体跟随拖动));
            主窗体跟随拖动线程.Start();
            Form2.ReleaseCapture();
            Form2.SendMessage(背景窗体.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            this.TopMost = true;
            主窗体跟随拖动线程.Abort();
            GC.Collect();
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
        }
        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
        }
        private void 主窗体跟随拖动()
        {
            while (true)
            {
                this.Location = 背景窗体.Location;
            }
        }
        public void 显示()
        {
            背景窗体.Show();
            this.Show();
        }
        public void 隐藏()
        {
            this.Hide();
            背景窗体.Hide();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                UnregisterHotKey(this.Handle, 热键ID);
            }
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                if (this.Visible)
                {
                    隐藏();
                    GC.Collect();
                }
                else
                {
                    显示();
                }
            }
            if (((MouseEventArgs)e).Button == MouseButtons.Right)
            {
                等待(6000);
                if (截图窗体.Visible)
                {
                    垃圾回收();
                }
                截图();
            }
        }
        public static void 等待(int 等待时间)
        {
            DateTime curr = DateTime.Now;
            while (curr.AddMilliseconds(等待时间) > DateTime.Now)
            {
                Application.DoEvents();
            }
            return;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Thread 翻译线程 = new Thread(new ThreadStart(this.翻译));
            翻译线程.Start();
        }

        #endregion

        private void 输出盒子_DoubleClick(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Control.MousePosition);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (翻译类型枚举 == 翻译类型.有道翻译)
            {
                翻译类型枚举 = 翻译类型.搜狗翻译;
                toolStripMenuItem2.Text = "切换为有道翻译";
                goto 翻译;
            }
            if (翻译类型枚举 == 翻译类型.搜狗翻译)
            {
                翻译类型枚举 = 翻译类型.有道翻译;
                toolStripMenuItem2.Text = "切换为搜狗翻译";
                goto 翻译;
            }
        翻译:;

            Thread 翻译线程 = new Thread(new ThreadStart(this.翻译));
            翻译线程.Start();
        }

        private void 覆盖全部粘贴并翻译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            输入盒子.Text = Clipboard.GetText();

            Thread 翻译线程 = new Thread(new ThreadStart(this.翻译));
            翻译线程.Start();
        }
        private void 复制全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(输入盒子.Text);
        }

        private void 区域粘贴并翻译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            输入盒子.SelectedText = Clipboard.GetText();

            Thread 翻译线程 = new Thread(new ThreadStart(this.翻译));
            翻译线程.Start();
        }

        private void 区域复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(输入盒子.SelectedText);
        }

        private void 区域复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(输出盒子.SelectedText);
        }

        private void 全部复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(输出盒子.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }

        public void 垃圾回收()
        {
            if (截图窗体.色谱窗体 != null)
                截图窗体.色谱窗体.Dispose();
            截图窗体.色谱窗体 = null;

            截图窗体.放大镜线程.Abort();
            截图窗体.放大镜窗体.Dispose();

            截图窗体.GDI4.Dispose();
            截图窗体.画笔画板.Dispose();

            if (截图窗体.位图 != null)
                截图窗体.位图.Dispose();
            截图窗体.位图 = null;

            截图窗体.历史.Clear();
            截图窗体.历史 = null;

            截图窗体.Dispose();
            截图窗体 = new Form3();

            GC.Collect();
        }

        private void pictureBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                隐藏();
                GC.Collect();
            }
        }
    }
}
