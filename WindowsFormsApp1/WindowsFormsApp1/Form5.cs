using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
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

        int 索引;
        Color 颜色1;

        public Color 颜色
        {
            get { return 颜色1; }
            set
            {
                颜色1 = Color.FromArgb(trackBar1.Value, value);
                Program.主窗体.截图窗体.笔2 = new Pen(颜色1, 5);
                Program.主窗体.截图窗体.笔3 = new Pen(颜色1, 5);
                Program.主窗体.截图窗体.toolStripTextBox1.ForeColor = 颜色1;
                label1.Text = "Argb:" + 颜色1.ToArgb().ToString("X");
            }
        }



        public Form5()
        {
            InitializeComponent();
            颜色 = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                颜色 = colorDialog1.Color;
                pictureBox2.BackColor = colorDialog1.Color;
            }
        }

        private void 更换色谱ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (索引 == 0)
            {
                pictureBox1.BackgroundImage = Properties.Resources.色谱;
                索引 = 1;
                return;
            }
            if (索引 == 1)
            {
                pictureBox1.BackgroundImage = Properties.Resources.色谱4;
                索引 = 2;
                return;
            }
            if (索引 == 2)
            {
                pictureBox1.BackgroundImage = Properties.Resources.色谱3;
                索引 = 0;
                return;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                timer1.Start();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer1.Stop();

                Bitmap 位图 = new Bitmap(1, 1);
                Graphics.FromImage(位图).CopyFromScreen(Control.MousePosition, new Point(0, 0), new Size(1, 1));
                pictureBox2.BackColor = 位图.GetPixel(0, 0);
                颜色 = pictureBox2.BackColor;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap 位图 = new Bitmap(1, 1);
            Graphics.FromImage(位图).CopyFromScreen(Control.MousePosition, new Point(0, 0), new Size(1, 1));
            pictureBox2.BackColor = 位图.GetPixel(0, 0);
        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            Form2.ReleaseCapture();
            Form2.SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void trackBar1_MouseLeave(object sender, EventArgs e)
        {
            颜色 = 颜色;
        }

        private void trackBar1_MouseEnter(object sender, EventArgs e)
        {
            颜色 = 颜色;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            颜色 = 颜色;
        }

        private void 复制颜色值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(颜色.ToArgb().ToString("X"));
        }
    }
}
