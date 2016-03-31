using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._5._2图像的剪切
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
            g.DrawImage(im,new Point(0,0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle r1 = new Rectangle(0, 200, 128, 128);
                Rectangle r2 = new Rectangle(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));

                g.DrawImage(im, r1, r2, GraphicsUnit.Pixel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
