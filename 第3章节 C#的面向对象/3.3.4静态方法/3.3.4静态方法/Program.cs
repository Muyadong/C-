using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3._4静态方法
{
    public class sqrt
    {
        /// <summary>
        /// 静态方法的例子
        /// </summary>
        public static void GetArea(double _dwidth, double _dheight)
        {
            //静态方法中不能使用this关键字引用类的属性或方法，因为this是指实例化后的对象本身，
            //而静态方法的调用是不需要实例化对象的。
            Console.WriteLine(_dwidth*_dheight);
        }
        static void Main(string[] args)
        {
            sqrt.GetArea(20,10);//直接使用sqrt类引用这个方法，不需要实例化一个矩形对象！
        }
    }
}
