using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _6._4._3正则表达式验证用户输入
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
