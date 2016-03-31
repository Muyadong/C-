using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._3._8菜单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了【新建】菜单");
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了【打开】菜单");
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了【添加】菜单");
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("你点击了【关闭】菜单");
        }
    }
}
