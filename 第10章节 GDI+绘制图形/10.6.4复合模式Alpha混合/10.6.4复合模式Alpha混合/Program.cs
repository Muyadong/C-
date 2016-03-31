using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _10._6._4复合模式Alpha混合
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
