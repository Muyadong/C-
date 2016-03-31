using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._2._1定义接口
{
    interface IWindow
    {
        //定义IWindow的position的属性
        Point Position
        {
            get;
            set;
        }
        //定义IWindow接口的Title属性
        string Title
        {
            get;
            set;
        }
        //定义IWindow接口的成员方法
        void Draw();
        void Minimize();
    }
    //Point 数据类型的定义
    public struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    //继承IWindow接口的RectanngularWindow类
    public class RectangularWindow : IWindow
    {
        //私有成员
        string title;
        Point position;
        //RectanngularWindow类的构造函数
        public RectangularWindow(string title, Point position)
        {
            this.title = title;
            this.position = position;
        }
        //实现IWindow接口中的Position属性
        public Point Position
        {
            get
            {
                return position;
            }
            set
            {
                position=value;
            }
        }
        //实现IWindow接口中的Title属性
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        //IWindow接口中的成员方法
        public void Draw()
        {
            Console.WriteLine("绘制矩形窗体");
        }
        public void Minimize()
        {
            Console.WriteLine("最小化矩形窗体");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
        }
    }
}
