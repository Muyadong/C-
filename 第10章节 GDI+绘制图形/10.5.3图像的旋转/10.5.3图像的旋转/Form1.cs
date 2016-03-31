using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._5._3图像的旋转
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
            g.Clear(this.BackColor);
            Image im = Image.FromFile("200811280015133172.png");
            //获取当前窗口的中心点
            Rectangle r = new Rectangle(0,0,this.ClientSize.Width,this.ClientSize.Height);
            PointF center = new PointF(r.Width/2,r.Height/2);

            float offsetX = 0;
            float offsetY = 0;
            offsetX = center.X - im.Width / 2;
            offsetY = center.Y - im.Height / 2;
            //构造图片显示区域，让图片的中心点与窗口的中心点一致

            RectangleF picrect = new RectangleF(offsetX,offsetY,im.Width,im.Height);
            PointF pcenter = new PointF(picrect.X+picrect.Width/2,picrect.Y+picrect.Height/2);
            //实现旋转
            g.TranslateTransform(pcenter.X,pcenter.Y);
            g.RotateTransform(Convert.ToSingle(textBox1.Text));
            g.TranslateTransform(-pcenter.X,-pcenter.Y);
            //显示图像
            g.DrawImage(im,picrect);
            //重置所有操作
            g.ResetTransform();
        }
    }
}
