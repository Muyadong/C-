using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._1GDI_的工作原理
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen redpen = new Pen(Color.Red, 1.0f);
            g.DrawLine(redpen, new Point(10, 10), new Point(ClientRectangle.Width, ClientRectangle.Height));
            g.Dispose();//释放资源
        }
    }
}
