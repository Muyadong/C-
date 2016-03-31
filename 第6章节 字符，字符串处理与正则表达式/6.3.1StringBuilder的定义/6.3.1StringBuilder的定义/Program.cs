using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._3._1StringBuilder的定义
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb1 = new StringBuilder("C#是很好的编程语言：");
            sb1.Append("我喜欢C#！！！");
            Console.WriteLine(sb1);
            Console.ReadLine();
        }
    }
}
