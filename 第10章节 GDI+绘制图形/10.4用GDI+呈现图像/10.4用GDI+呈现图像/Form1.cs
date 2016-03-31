using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._4用GDI_呈现图像
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(@"G:\图片\tupian\200811280015133172.png");
            Graphics g = this.CreateGraphics();
            g.DrawImage(b,10,10);
        }
    }
}
