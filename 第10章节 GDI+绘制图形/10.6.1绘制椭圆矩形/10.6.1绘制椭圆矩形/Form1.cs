using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._6._1绘制椭圆矩形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black,2);//创建画笔
            Rectangle rect = new Rectangle(10,10,240,120);//定义区域
            e.Graphics.DrawRectangle(pen,rect);//画矩形
            e.Graphics.DrawEllipse(pen,rect);//画椭圆
            pen.Dispose();

            //10.6.2使用Drawstring绘制居中文本!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Font font = new Font("宋体",18);//定义字体
            StringFormat sf = new StringFormat();//定义字符串格式对象
            sf.Alignment = StringAlignment.Center;//指定文本水平居中
            int x = this.Width / 2;//获取水平居中的坐标
            e.Graphics.DrawString("正常排列的文本",font,Brushes.Black,x,20);
            e.Graphics.DrawString("水平居中的文本",font,Brushes.Red,x,100,sf);
            
            //10.6.3使用drawtext绘制居中文本
            Point point = new Point(this.Width, 200);//定义坐标
            TextRenderer.DrawText(e.Graphics, "水平居中的文本！", font, point,
                SystemColors.ControlText, TextFormatFlags.HorizontalCenter);

            
            base.OnPaint(e);
        }
       
    }
}
