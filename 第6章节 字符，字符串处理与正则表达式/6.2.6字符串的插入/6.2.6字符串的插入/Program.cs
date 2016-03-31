using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._2._6字符串的插入
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello World!";
            //向字符串a位置0处插入字符串“Hello”，并输出结果
            string b = a.Insert(0,"Hello ");
            Console.WriteLine(b);
            //向字符串a的位置倒数第二个字符处插入字符串“World”，并输出结果
            string c = b.Insert(b.Length-1," World");
            Console.WriteLine(c);

            //字符串的删除
            string d = c.Remove(23);//删除23之后的字符串
            Console.WriteLine(d);

            string e = d.Remove(0,10);//删除0到10 之间的字符串
            Console.WriteLine(e);

            //字符串的替换！！！！！！
            string f = a.Replace('!','.');//将字符串a中的“！”替换为“.”
            Console.WriteLine(f);

            string g = f.Replace("Hello","HELLO");//将字符串f中的“Hello”替换为“HELLO”
            Console.WriteLine(g);

            Console.ReadLine();
        }
    }
}
