using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._3GDI_绘制曲线
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font myfont = new System.Drawing.Font("黑体",5);//通过指定的大小初始化
            Brush b = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);

            g.DrawLine(new Pen(Color.Blue),0,100,this.Width,100);
            g.DrawLine(new Pen(Color.Red),10,0,10,this.Height);

            for (int i = 0; i < 100; i++)
            {
                double y = 10 * Math.Sin(i) + 100;
                g.DrawString("*",myfont,b,10*i+10,(float)y);
            }

        }
    }
}
