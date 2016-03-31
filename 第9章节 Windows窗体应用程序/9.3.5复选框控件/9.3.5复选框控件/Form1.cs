using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._3._5复选框控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = string.Empty;
            if (checkBox1.Checked)
            {
                answer += "A";
            }
            if (checkBox2.Checked)
            {
                answer += "B";
            }
            if (checkBox3.Checked)
            {
                answer += "C";
            }
            if (checkBox4.Checked)
            {
                answer += "D";
            }
            if (answer == "ABCD")
            {
                MessageBox.Show("恭喜你，答对了！！！");
            }
            else
            {
                MessageBox.Show("正确答案是ABCD，你答错了！！！");
            }
        }

      
    }
}
