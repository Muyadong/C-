using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._2._4字符串的比较
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别定义两个字符串“HelloWorld!”和“HEOOLWORLD!”
            string a = "HelloWorld!";
            string b = "HELLOWORLD!";
            int i = string.Compare(a,b,true);//忽略大小写比较两个字符串
            int j = string.Compare(a,b);//不忽略大小写比较两个字符串
            //输出结果惊醒比较
            Console.WriteLine("The return value of Compare is {0}",i);
            Console.WriteLine("The return value of Compare is {0}",j);
            Console.ReadLine();
        }
    }
}
