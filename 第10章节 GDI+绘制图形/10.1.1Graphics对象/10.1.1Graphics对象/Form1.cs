using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._1._1Graphics对象
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
            Pen p = new Pen(Color.Red);
            g.DrawLine(p,100,100,200,200);
            //MessageBox.Show(g.ToString());
        }
        //font类的用法
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //运用solidbrush先绘制背景颜色
            Brush br = new SolidBrush(Color.White);
            g.FillRectangle(br,ClientRectangle);
            //画“arial”字体加倾斜
            Rectangle r1 = new Rectangle(0,0,200,200);
            using (Font f = new Font("Arial", 12, FontStyle.Italic))
            {
                g.DrawString("I Like C#!!",f ,Brushes.Black,r1);
            }
            //画“times new roman”字体下加下划线
            Rectangle r2 = new Rectangle(0,40,200,200);
            using (Font f = new Font("times new roman", 18, FontStyle.Underline))
            {
                g.DrawString("I Like C#!!!",f ,Brushes.Blue,r2);
            }
            //画加粗且带删除线的宋体
            Rectangle r3 = new Rectangle(0,80,300,200);
            using (Font f = new Font("宋体", 18, FontStyle.Strikeout))
            {
                g.DrawString("我喜欢C#编程！！",f,Brushes.Red,r3);
            }
        }

       
    }
}
