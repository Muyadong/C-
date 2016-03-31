using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._3._9多文档界面应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new Form();
            a.MdiParent = this;
            a.Show();
        }

        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form a in this.MdiChildren)
            {
                a.WindowState = FormWindowState.Minimized;
            }
        }

        private void 最大化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form a in this.MdiChildren)
            {
                a.WindowState = FormWindowState.Maximized;
            }
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form a in this.MdiChildren)
            {
                a.Close();
            }
        }
    }
}
