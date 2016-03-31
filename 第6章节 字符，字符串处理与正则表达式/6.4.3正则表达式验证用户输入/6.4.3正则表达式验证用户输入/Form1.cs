using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace _6._4._3正则表达式验证用户输入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"^\d{3}-\d{8}$");
            string inp = this.textBox1.Text;
            if (rg.Match(inp).Success == false)
            {
                MessageBox.Show("格式不正确！", "验证结果", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("输入成功！", "验证结果", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
