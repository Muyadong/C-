using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10._5._4图像的切换显示
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image im1 = Image.FromFile("20100823223752349.png");
        private Image im2 = Image.FromFile("200811280015133172.png");

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            timer1.Enabled = true;
            timer2.Enabled = false;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = im1;
            timer1.Enabled = false;
           
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = im2;
            timer2.Enabled = false;
           
            timer1.Enabled = true;
        }

       
    }
}
