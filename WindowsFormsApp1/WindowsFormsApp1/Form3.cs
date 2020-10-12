using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Tesseract;
using static WindowsFormsApp1.Program;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        Pen 笔 = new Pen(Color.FromArgb(17, 145, 250), 3);
        public Pen 笔2 = new Pen(Brushes.Red, 5);
        AdjustableArrowCap 箭头 = new AdjustableArrowCap(6, 6, true);
        public Pen 笔3 = new Pen(Brushes.Red, 5);

        Point 点a;
        Point 点b;
        Point 起点;
        int 高;
        int 宽;
        public Bitmap 位图;
        public Bitmap 画笔画板;  //画图模式.画笔
        bool 标志;  //画图模式.文字

        public Graphics GDI4;
        public Form5 色谱窗体;
        public Thread 放大镜线程;
        public Form4 放大镜窗体;

        public ArrayList 历史 = new ArrayList();

        enum 画图模式
        {
            框选翻译,
            箭头,
            文字,
            画笔,
            矩形,
            实心矩形,
            取色
        }


        画图模式 画图模式枚举 = 画图模式.框选翻译;

        public Form3()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            笔.DashStyle = DashStyle.Dash;

            箭头.MiddleInset = 3f;
        }
        public void 截图()
        {
            this.TopMost = true;
            Bitmap 背景图片 = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height); //开辟内存
            Graphics GDI = Graphics.FromImage(背景图片);  //引用内存
            GDI.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size, CopyPixelOperation.SourceCopy);  //将屏幕颜色数据写入引用的内存
            //GDI.FillRectangle(new SolidBrush(Color.FromArgb(64, Color.Gray)), Screen.PrimaryScreen.Bounds);
            // // ------------- ---------------------------------------------- ----------------------------
            // //   矩形填充                 灰色，通明度64                              矩形范围
            GDI.Dispose();
            this.BackgroundImage = 背景图片;
            历史.Add(this.BackgroundImage.Clone());

            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;

            画笔画板 = new Bitmap(this.Width, this.Height);
            GDI4 = Graphics.FromImage(画笔画板);
            GDI4.SmoothingMode = SmoothingMode.AntiAlias;


            this.Location = Screen.PrimaryScreen.Bounds.Location;
            this.Show();
            this.TopMost = false;
            主窗体.背景窗体.TopMost = true;
            主窗体.TopMost = true;

            放大镜窗体 = new Form4();
            放大镜窗体.Show();
            放大镜线程 = new Thread(new ThreadStart(放大镜窗体.放大镜));
            放大镜线程.Start();
        }
        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            点a = Control.MousePosition;
            if (e.Button == MouseButtons.Left)
            {
                if (画图模式枚举 == 画图模式.框选翻译)
                    timer1.Start();
                if (画图模式枚举 == 画图模式.箭头)
                    timer2.Start();
                if (画图模式枚举 == 画图模式.文字)
                { }
                if (画图模式枚举 == 画图模式.画笔)
                    timer4.Start();
                if (画图模式枚举 == 画图模式.矩形)
                    timer5.Start();
                if (画图模式枚举 == 画图模式.实心矩形)
                    timer6.Start();
                if (画图模式枚举 == 画图模式.取色)
                    timer7.Start();
            }
        }
        private void Form3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (画图模式枚举 == 画图模式.框选翻译)
                {
                    timer1.Stop();

                    if (宽 > 10 & 高 > 10)
                    {
                        Graphics GDI = this.CreateGraphics();
                        GDI.SmoothingMode = SmoothingMode.AntiAlias;
                        GDI.DrawRectangle(笔, 起点.X, 起点.Y, 宽, 高);

                        位图 = new Bitmap(宽, 高);
                        Graphics GDI2 = Graphics.FromImage(位图);
                        GDI2.DrawImage(this.BackgroundImage, 0, 0, new Rectangle(起点.X, 起点.Y, 宽, 高), GraphicsUnit.Pixel);
                        //pictureBox1.Image = 位图;

                        Thread 文字识别翻译线程 = new Thread(new ThreadStart(文字识别翻译));
                        文字识别翻译线程.Start();
                    }
                    else
                    {
                        this.Refresh();
                    }
                }
                if (画图模式枚举 == 画图模式.箭头)
                {
                    timer2.Stop();

                    历史.Add(this.BackgroundImage.Clone());

                    笔2.CustomStartCap = new AdjustableArrowCap(2, (float)(Math.Sqrt((double)(Math.Pow(高 / 10, 2) + Math.Pow(宽 / 10, 2))) * 2 - 1.28), true);
                    笔2.CustomEndCap = 箭头;

                    Graphics GDI = Graphics.FromImage(this.BackgroundImage);
                    GDI.SmoothingMode = SmoothingMode.AntiAlias;

                    GDI.DrawLine(笔2, 点a, 点b);

                    this.Refresh();
                }
                if (画图模式枚举 == 画图模式.文字)
                {
                    if (!标志)
                    {
                        contextMenuStrip1.Show(Control.MousePosition);
                        toolStripTextBox1.Focus();

                        标志 = true;
                    }
                    else
                    {

                        if (toolStripTextBox1.Text == "")
                        {
                            contextMenuStrip1.Show(Control.MousePosition);
                            toolStripTextBox1.Focus();
                            return;
                        }

                        历史.Add(this.BackgroundImage.Clone());

                        标志 = false;

                        Graphics GDI = Graphics.FromImage(this.BackgroundImage);
                        GDI.SmoothingMode = SmoothingMode.AntiAlias;

                        int 宽度 = TextRenderer.MeasureText(toolStripTextBox1.Text, toolStripTextBox1.Font).Width;

                        GDI.DrawString(toolStripTextBox1.Text,
                            new Font("Segoe UI Symbol",
                                14.825F, FontStyle.Bold,
                                GraphicsUnit.Point, 0),
                            new SolidBrush(笔3.Color),
                            contextMenuStrip1.Location.X + (contextMenuStrip1.Width - 宽度) / 2 + 8,
                            contextMenuStrip1.Location.Y + 5);

                        this.Refresh();
                        contextMenuStrip1.Hide();
                        toolStripTextBox1.Text = "";
                        contextMenuStrip1.Width = 60;
                        toolStripTextBox1.Width = 60;
                    }
                }
                if (画图模式枚举 == 画图模式.画笔)
                {
                    timer4.Stop();

                    历史.Add(this.BackgroundImage.Clone());

                    Graphics GDI = Graphics.FromImage(this.BackgroundImage);
                    GDI.SmoothingMode = SmoothingMode.None;

                    GDI.DrawImage(画笔画板, 0, 0);

                    画笔画板 = new Bitmap(this.Width, this.Height);
                    GDI4 = Graphics.FromImage(画笔画板);
                    GDI4.SmoothingMode = SmoothingMode.AntiAlias;

                    this.Refresh();

                }
                if (画图模式枚举 == 画图模式.矩形)
                {
                    timer5.Stop();

                    历史.Add(this.BackgroundImage.Clone());

                    Graphics GDI = Graphics.FromImage(this.BackgroundImage);
                    GDI.SmoothingMode = SmoothingMode.AntiAlias;

                    int 圆角半径 = 6;

                    if (宽 < 18)
                        圆角半径 = 2;
                    if (高 < 18)
                        圆角半径 = 2;
                    if (宽 < 9)
                        圆角半径 = 1;
                    if (高 < 9)
                        圆角半径 = 1;
                    if (宽 < 5)
                        圆角半径 = 4;
                    if (高 < 5)
                        圆角半径 = 4;


                    Rectangle 矩形 = new Rectangle(起点.X, 起点.Y, 宽, 高);

                    GraphicsPath 路径 = new GraphicsPath();
                    路径.StartFigure();
                    路径.AddArc(new Rectangle(new Point(矩形.X, 矩形.Y), new Size(2 * 圆角半径, 2 * 圆角半径)), 180, 90);
                    路径.AddLine(new Point(矩形.X + 圆角半径, 矩形.Y), new Point(矩形.Right - 圆角半径, 矩形.Y));
                    路径.AddArc(new Rectangle(new Point(矩形.Right - 2 * 圆角半径, 矩形.Y), new Size(2 * 圆角半径, 2 * 圆角半径)), 270, 90);
                    路径.AddLine(new Point(矩形.Right, 矩形.Y + 圆角半径), new Point(矩形.Right, 矩形.Bottom - 圆角半径));
                    路径.AddArc(new Rectangle(new Point(矩形.Right - 2 * 圆角半径, 矩形.Bottom - 2 * 圆角半径), new Size(2 * 圆角半径, 2 * 圆角半径)), 0, 90);
                    路径.AddLine(new Point(矩形.Right - 圆角半径, 矩形.Bottom), new Point(矩形.X + 圆角半径, 矩形.Bottom));
                    路径.AddArc(new Rectangle(new Point(矩形.X, 矩形.Bottom - 2 * 圆角半径), new Size(2 * 圆角半径, 2 * 圆角半径)), 90, 90);
                    路径.AddLine(new Point(矩形.X, 矩形.Bottom - 圆角半径), new Point(矩形.X, 矩形.Y + 圆角半径));
                    路径.CloseFigure();
                    //GDI.FillPath(笔3.Brush, 路径);
                    GDI.DrawPath(笔3, 路径);

                    this.Refresh();
                }
                if (画图模式枚举 == 画图模式.实心矩形)
                {
                    timer6.Stop();

                    历史.Add(this.BackgroundImage.Clone());

                    Graphics GDI = Graphics.FromImage(this.BackgroundImage);
                    GDI.SmoothingMode = SmoothingMode.AntiAlias;

                    int 圆角半径 = 4;

                    if (宽 < 18)
                        圆角半径 = 2;
                    if (高 < 18)
                        圆角半径 = 2;
                    if (宽 < 9)
                        圆角半径 = 1;
                    if (高 < 9)
                        圆角半径 = 1;
                    if (宽 < 4)
                        goto 返回;
                    if (高 < 4)
                        goto 返回;

                    Rectangle 矩形 = new Rectangle(起点.X, 起点.Y, 宽 - (圆角半径 / 2), 高 - (圆角半径 / 2));

                    GraphicsPath 路径 = new GraphicsPath();
                    路径.StartFigure();
                    路径.AddArc(new Rectangle(new Point(矩形.X, 矩形.Y), new Size(2 * 圆角半径, 2 * 圆角半径)), 180, 90);
                    路径.AddLine(new Point(矩形.X + 圆角半径, 矩形.Y), new Point(矩形.Right - 圆角半径, 矩形.Y));
                    路径.AddArc(new Rectangle(new Point(矩形.Right - 2 * 圆角半径, 矩形.Y), new Size(2 * 圆角半径, 2 * 圆角半径)), 270, 90);
                    路径.AddLine(new Point(矩形.Right, 矩形.Y + 圆角半径), new Point(矩形.Right, 矩形.Bottom - 圆角半径));
                    路径.AddArc(new Rectangle(new Point(矩形.Right - 2 * 圆角半径, 矩形.Bottom - 2 * 圆角半径), new Size(2 * 圆角半径, 2 * 圆角半径)), 0, 90);
                    路径.AddLine(new Point(矩形.Right - 圆角半径, 矩形.Bottom), new Point(矩形.X + 圆角半径, 矩形.Bottom));
                    路径.AddArc(new Rectangle(new Point(矩形.X, 矩形.Bottom - 2 * 圆角半径), new Size(2 * 圆角半径, 2 * 圆角半径)), 90, 90);
                    路径.AddLine(new Point(矩形.X, 矩形.Bottom - 圆角半径), new Point(矩形.X, 矩形.Y + 圆角半径));
                    路径.CloseFigure();
                    GDI.FillPath(笔3.Brush, 路径);//
                    GDI.DrawPath(笔3, 路径);

                返回:;
                    this.Refresh();
                }
                if (画图模式枚举 == 画图模式.取色)
                {
                    timer7.Stop();

                    Bitmap 位图 = new Bitmap(1, 1);
                    Graphics.FromImage(位图).CopyFromScreen(Control.MousePosition, new Point(0, 0), new Size(1, 1));
                    色谱窗体.颜色 = 位图.GetPixel(0, 0);
                    色谱窗体.pictureBox2.BackColor = 位图.GetPixel(0, 0);
                }

                if (历史.Count > 4)
                {
                    历史.Reverse();
                    ((Image)历史[4]).Dispose();
                    历史.RemoveAt(4);
                    历史.Reverse();
                }
            }
        }
        public void 文字识别翻译()
        {
            TesseractEngine OCR = new TesseractEngine(AppDomain.CurrentDomain.BaseDirectory + @"\tessdata", "eng", EngineMode.Default);
            主窗体.输入盒子.Text = OCR.Process(位图).GetText();
            OCR.Dispose();

            主窗体.翻译();
        }

        private void 计算坐标()
        {
            点b = Control.MousePosition;

            if (点a.X > 点b.X)
            {
                宽 = 点a.X - 点b.X;
                起点.X = 点b.X;
            }
            else
            {
                宽 = 点b.X - 点a.X;
                起点.X = 点a.X;
            }
            if (点a.Y > 点b.Y)
            {
                高 = 点a.Y - 点b.Y;
                起点.Y = 点b.Y;
            }
            else
            {
                高 = 点b.Y - 点a.Y;
                起点.Y = 点a.Y;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            计算坐标();

            Graphics GDI = this.CreateGraphics();

            this.Refresh();
            GDI.DrawRectangle(笔, 起点.X, 起点.Y, 宽, 高);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            计算坐标();

            笔2.CustomStartCap = new AdjustableArrowCap(2, (float)(Math.Sqrt((double)(Math.Pow(高 / 10, 2) + Math.Pow(宽 / 10, 2))) * 2 - 1.28), true);
            笔2.CustomEndCap = 箭头;

            Graphics GDI = this.CreateGraphics();
            GDI.SmoothingMode = SmoothingMode.None;

            this.Refresh();
            GDI.DrawLine(笔2, 点a, 点b);
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            int 宽度 = TextRenderer.MeasureText(toolStripTextBox1.Text, toolStripTextBox1.Font).Width;

            if (10 < 宽度)
            {
                contextMenuStrip1.Width = 宽度;
                toolStripTextBox1.Width = 宽度;
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            点b = Control.MousePosition;

            Graphics GDI3 = this.CreateGraphics();
            GDI3.SmoothingMode = SmoothingMode.None;

            GDI3.DrawLine(笔3, 点a, 点b);
            GDI4.DrawLine(笔3, 点a, 点b);

            点a = Control.MousePosition;

            GDI4.DrawLine(笔3, 点a, 点b);

        }

        #region 菜单
        private void 框选翻译ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.框选翻译;
            框选翻译ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;

            放大镜窗体 = new Form4();
            放大镜窗体.Show();
            放大镜线程 = new Thread(new ThreadStart(放大镜窗体.放大镜));
            放大镜线程.Start();
        }

        private void 箭头ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.箭头;
            箭头ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;
        }

        private void 文字ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.文字;
            文字ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;
        }

        private void 画笔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.画笔;
            画笔ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;
        }

        private void 圆角矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.矩形;
            圆角矩形ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;
        }

        private void 实心圆角矩形ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.实心矩形;
            实心圆角矩形ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;
        }
        private void 取色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            着色器();
            画图模式枚举 = 画图模式.取色;
            取色ToolStripMenuItem.ForeColor = Color.DeepSkyBlue;
            色谱窗体 = new Form5();
            色谱窗体.Show();

            放大镜窗体 = new Form4();
            放大镜窗体.Show();
            放大镜线程 = new Thread(new ThreadStart(放大镜窗体.放大镜));
            放大镜线程.Start();
        }

        public void 着色器()
        {
            框选翻译ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            箭头ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            文字ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            画笔ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            圆角矩形ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            实心圆角矩形ToolStripMenuItem.ForeColor = SystemColors.ControlText;
            取色ToolStripMenuItem.ForeColor = SystemColors.ControlText;

            if (色谱窗体 != null)
                色谱窗体.Dispose();

            if (放大镜线程.IsAlive)
                放大镜线程.Abort();

            if (放大镜窗体 != null)
                放大镜窗体.Dispose();
        }

        #endregion

        private void timer5_Tick(object sender, EventArgs e)
        {
            计算坐标();

            Graphics GDI = this.CreateGraphics();
            GDI.SmoothingMode = SmoothingMode.None;

            this.Refresh();
            GDI.DrawRectangle(笔3, 起点.X, 起点.Y, 宽, 高);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            计算坐标();

            Graphics GDI = this.CreateGraphics();
            GDI.SmoothingMode = SmoothingMode.None;

            this.Refresh();
            GDI.FillRectangle(笔3.Brush, 起点.X, 起点.Y, 宽, 高);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/截图"))
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/截图");

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/截图"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "/截图");

            if (画图模式枚举 == 画图模式.框选翻译)
                if (位图 != null)
                {
                    位图.Save(
                        Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                        + "/截图/"
                        + DateTime.Now.ToString()
                           .Replace("/", "-")
                           .Replace(" ", "__")
                           .Replace(":", "-")
                        + ".png"
                        , System.Drawing.Imaging.ImageFormat.Png
                    );
                    return;
                }


            this.BackgroundImage.Save(
                Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
                + "/截图/"
                + DateTime.Now.ToString()
                   .Replace("/", "-")
                   .Replace(" ", "__")
                   .Replace(":", "-")
                + ".png"
                , System.Drawing.Imaging.ImageFormat.Png
            );
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            Bitmap 位图 = new Bitmap(1, 1);
            Graphics.FromImage(位图).CopyFromScreen(Control.MousePosition, new Point(0, 0), new Size(1, 1));
            色谱窗体.pictureBox2.BackColor = 位图.GetPixel(0, 0);
        }

        private void contextMenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            timer8.Start();
        }

        private void contextMenuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            timer8.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Control.MousePosition);
        }

        private void 撤销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (历史.Count > 1)
            {
                this.BackgroundImage = (Image)历史[历史.Count - 1];
                历史.RemoveAt(历史.Count - 1);
                this.Refresh();
            }
        }
    }
}
