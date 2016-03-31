using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._6._4复合模式Alpha混合
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width,this.Height);//定义一个weitu
            Graphics g = Graphics.FromImage(bitmap);//从位图中获取graphics对象
            //定义红色画刷
            SolidBrush rebrush = new SolidBrush(Color.FromArgb(160,255,0,0));
            //定义绿色画刷
            SolidBrush greenbrush = new SolidBrush(Color.FromArgb(160,0,255,0));
            //定义绿色画刷，用于绘制背景
            SolidBrush bgbrush = new SolidBrush(Color.FromArgb(50, 0, 0, 255));
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
            g.FillRectangle(bgbrush, 0, 0, this.Width, this.Height);//绘制背景
            g.FillEllipse(rebrush,0,0,150,180);//绘制椭圆
            g.FillEllipse(greenbrush,30,30,150,180);//绘制椭圆
            SolidBrush colorbrush = new SolidBrush(Color.Yellow);
            e.Graphics.FillRectangle(colorbrush,120,150,100,100);//绘制一个黄色的矩形
            e.Graphics.DrawImage(bitmap,0,0);//绘制位置

            base.OnPaint(e);
        }

    }
}
