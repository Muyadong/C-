using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._1._2转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            //直接用writeline方法输出一行并换行
            Console.WriteLine("直接用writeline方法输出一行并换行!");
            //使用转义字符\n输出换行
            Console.Write("使用转义字符\n输出换行!");
            //使用转义字符\n输出两个句子
            Console.Write("使用转义字符输出换行!\n使用换行转义字符换行！");
            Console.ReadLine();
        }
    }
}
