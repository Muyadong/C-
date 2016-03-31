using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._2._2String和Char
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义字符串Hello world!
            string ch1 = "HelloWorld";
            //定义字符串ch2和ch3,分别赋值为字符串ch1的第一个和第二个字符
            char ch2 = ch1[0];
            char ch3 = ch1[5];
            //输出字符串ch1的第一个和第六个字符
            Console.WriteLine("输出字符串ch1的第一个字符{0}",ch2);
            Console.WriteLine("输出字符串ch1的第6个字符{0}",ch3);

            //通过字符串的length属性获得字符串的长度，并将其输出至控制台中
            Console.WriteLine("ch1的长度为：{0}",ch1.Length);

            Console.ReadLine();
        }
    }
}
