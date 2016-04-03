using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace _13._4线程中的异常
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(test));//实例化线程
            t.Start();
        }

        private delegate void SetTextCallback();//定义一个委托~~~
        private void send()
        {
            listBox1.Items.Add("aaaaa\n");
            Thread.Sleep(1000);
        }
        private void test()
        {
            SetTextCallback st = new SetTextCallback(send);//实例化委托，参数是要调用的方法
            Invoke(st);//启动线程
        }
    }
}
