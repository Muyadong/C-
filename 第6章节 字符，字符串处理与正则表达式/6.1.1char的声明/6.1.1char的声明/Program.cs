using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._1._1char的声明
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义部分字符
            char ch1 = 'a';
            char ch2 = '1';
            char ch3 = 'B';
            char ch4 = '.';
            char ch5 = '|';
            char ch6 = ' ';
            //判断该字符ch1是否为字母
            Console.WriteLine("char.Isletter(ch1) is {0}",char.IsLetter(ch1));
            //判断该字符ch2是否为数字
            Console.WriteLine("char.IsDigit(ch2) is {0}",char.IsDigit(ch2));
            //判断该字符ch1是否为字母或数字
            Console.WriteLine("char.IsLetterOrDigit(ch1) is {0}",char.IsLetterOrDigit(ch1));
            //判读该字符ch1是否为小写字母
            Console.WriteLine("char.IsLower(ch1) is {0}",char.IsLower(ch1));
            //判断该字符ch3是否为大写字母
            Console.WriteLine("char.IsUpper(ch3) is {0}",char.IsUpper(ch3));
            //判断该字符ch4是否为标点符号
            Console.WriteLine("char.IsPunctuation(ch4) is {0}",char.IsPunctuation(ch4));
            //判断该字符ch5是否为分隔符
            Console.WriteLine("char.IsSeparator(ch5) is {0}",char.IsSeparator(ch5));
            //判断该字符ch6是否为空白
            Console.WriteLine("char.IsWhiteSpace(ch6) is {0}",char.IsWhiteSpace(ch6));
            Console.ReadLine();
        }
    }
}
