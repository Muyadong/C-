using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._2._5字符串的获取
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义初始字符串a
            string a = "Hello World!";
            //获取a的子字符串，从位置6开始到字符串a结束，并输出
            string b = a.Substring(6);
            Console.WriteLine("Substring is :{0}",b);
            //获取a的子字符串，从位置12开始到字符串a结束，并输出
            string c = a.Substring(12);
            Console.WriteLine("Substring is :{0}",c);
            //获取a的子字符串，从位置0开始到字符串5结束，并输出
            string d = a.Substring(0, 5);
            Console.WriteLine("Substring  is :{0}",d);
            //获取a的子字符串，从位置0开始到字符串0结束，并输出
            string e = a.Substring(0,0);
            Console.WriteLine("Substring is :{0}",e);
            Console.ReadLine();
        }
    }
}
