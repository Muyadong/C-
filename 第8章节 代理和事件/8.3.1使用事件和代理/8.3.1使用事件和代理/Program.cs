using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._3._1使用事件和代理
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pnts = new Point(0,0);
            //为事件添加处理方法，该方法的返回类型和参数必须与代理声明一致
            pnts.Create += new Point.OnCreate(pnts_Create);
            pnts = new Point(100,200);
            Console.ReadLine();
        }
        //事件的处理方法  返回类型和参数必须与代理声明一致！！！
        static void pnts_Create(object Sender, EventArgs e)
        {
            Console.WriteLine("点实例已创建！");
        }
    }
    class Point//表示点的类
    {
        private double _X;
        public double X
        {
            get { return _X; }
            set { _X = value; }
        }
        private double _Y;
        public double Y
        {
            get { return _X; }
            set { _X = value; }
        }
        private static event OnCreate _Create;
        public event OnCreate Create//表示创建的事件
        {
            add { _Create += value; }
            remove { { _Create -= value; } }
        }
        //表示创建事件处理方法的代理声明
        public delegate void OnCreate(object Sender, EventArgs e);
        //定义私有的构造函数，阻止外部程序使用 默认构造函数创建实例
        private Point()
        { 
        }
        public Point(double x, double y)
        {
            _X = x;
            _Y = y;
            NewPoint(this);//激活事件
        }
        private static void NewPoint(object sender)
        {
            if (_Create != null)//判断事件中的代理是否为空
            {
                _Create(sender, new EventArgs());//执行代理所包含的事件处理方法
            }
        }
    }
}
