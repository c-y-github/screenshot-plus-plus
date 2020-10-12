using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);
        }

        public void 放大镜()
        {
            while (true)
            {
                if (Control.MousePosition.X > Program.主窗体.Location.X
                    & Control.MousePosition.Y > Program.主窗体.Location.Y
                    & Control.MousePosition.X < Program.主窗体.Location.X + Program.主窗体.Width
                    & Control.MousePosition.Y < Program.主窗体.Location.Y + Program.主窗体.Height
                    )
                {
                    Hide();
                }
                else if (Program.主窗体.截图窗体.Visible)
                {
                    Show();
                }

                this.Location = new Point(Control.MousePosition.X + 40, Control.MousePosition.Y + 40);

                Bitmap 位图 = new Bitmap(80, 80);
                Graphics.FromImage(位图).CopyFromScreen(
                         new Point(Cursor.Position.X - 40,
                                   Cursor.Position.Y - 40),
                         new Point(0, 0),
                         new Size(80, 80));

                this.BackgroundImage = 位图;

                this.TopMost = true;
            }
        }
    }
}
