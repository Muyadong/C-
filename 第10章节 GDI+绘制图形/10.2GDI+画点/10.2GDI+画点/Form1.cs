using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._2GDI_画点
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font myfont = new System.Drawing.Font("黑体",20);
            Brush b = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);

            g.DrawString("*",myfont,b,50+i,50+i);
            g.DrawString("*",myfont,b,50+i,100+i);
            g.DrawString("*",myfont,b,100+i,50+i);
            g.DrawString("*",myfont,b,100+i,100+i);
            i = i + 10;

        }
    }
}
