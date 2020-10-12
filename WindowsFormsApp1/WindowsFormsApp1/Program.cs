using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        public static Form1 主窗体;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            主窗体 = new Form1();
            Application.Run(主窗体);
        }
    }
}
