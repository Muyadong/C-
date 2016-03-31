using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _9._3._1按钮控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("你点击了按钮！！");
            //9.3.2标签控件
                count++;
                label1.Text = "共点击了" + count.ToString() + "次按钮！！";      
            }
            int count = 0;
    }
}
