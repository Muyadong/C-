using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 结构编程实例
{
    /*
    //定义point类
    class Point
    {
        //公共类型成员变量；
        public int x, y, z;
        //定义类的成员方法 ；
        public Point()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
     */
    struct Point
    {
        public int x, y, z;
        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
    //定义Program类
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[10000];
            //执行对象points的初始化，其中每个点的坐标值分别为（x，y，z）=（i，i*2,i*3）;
            for (int i = 0; i < 10000; i++)
            {
                points[i] = new Point(i, i*2, i*3);
            }
        }
    }
}
