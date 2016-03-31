using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._2._3字符串的查找
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别定义字符串m和字符n，并分别为其赋初值为：“HelloWorld!”和‘l’
            string m = "HelloWorld!";
            char n = 'l';
            //搜索字符'l'在字符串“HelloWorld!”中第一次出现的位置
            int position1 = m.IndexOf(n);
            Console.WriteLine("搜索字符'l'在字符串“HelloWorld!”中第一次出现的位置是：{0}",position1);
            //搜索字符'l'在字符串“HelloWorld!”中最后一次出现的位置
            int position2= m.LastIndexOf(n);
            Console.WriteLine("搜索字符'l'在字符串“HelloWorld!”中最后一次出现的位置是：{0}",position2);
            Console.ReadLine();
        }
    }
}
