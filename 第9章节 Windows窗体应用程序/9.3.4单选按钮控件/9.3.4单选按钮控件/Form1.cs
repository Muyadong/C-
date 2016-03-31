using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._3._4单选按钮控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("正确答案是D，你打错了！");
            }
            if (radioButton2.Checked)
            {
                MessageBox.Show("正确答案是D，你打错了！");
            }
            if (radioButton3.Checked)
            {
                MessageBox.Show("正确答案是D，你打错了！");
            }
            if (radioButton4.Checked)
            {
                MessageBox.Show("恭喜你答对了！！");
            }
        }
    }
}
