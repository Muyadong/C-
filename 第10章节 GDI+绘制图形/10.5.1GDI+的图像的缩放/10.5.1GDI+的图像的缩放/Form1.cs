using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._5._1GDI_的图像的缩放
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private Graphics g;
        private Image im = Image.FromFile("200811280015133172.png");
        
        private void button1_Click(object sender, EventArgs e)
        {
            //g = this.CreateGraphics();
            g.DrawImage(im,new Point(0,0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Clear(this.BackColor);
            int width = Convert.ToInt32(Convert.ToDouble(comboBox1.Text)*im.Width);
            int height = Convert.ToInt32(Convert.ToDouble(comboBox1.Text)*im.Height);
            g.DrawImage(im ,0,0,width,height);
        }
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //        im.Dispose();
        //        g.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        
    }
}
