using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 枚举编程实例
{
    class Program
    {
        //定义Text枚举类型成员
        enum Test
        {
            A = 1,B,C,
            D,
            E,
            F = 10,G,
        };
        //定义程序的main（）方法。
        static void Main(string[] args)
        {
            int x = (int)(Test.A);
            int y = (int)(Test.B);
            int z = (int)(Test.F);
            int m = (int)(Test.G);
            //{0}{1}.....充当占位符 ，将后面的参数对号入座。
            Console.WriteLine("Test.A = {0}", x);
            Console.WriteLine("Test.B = {0}", y);
            Console.WriteLine("Test.F = {0}", z);
            Console.WriteLine("Test.G = {0}", m);
            Console.Read();

        }
    }
}
