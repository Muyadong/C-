using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._9._3for语句
{
    class Program
    {
        static void Main(string[] args)
        {
            //循环式列1///////////////////////
            int sum = 1;//保存阶乘值的变量
            //最常见的for语句，首先声明并初始化迭代器变量i，然后是循环条件，最后是迭代器自增语句
            for (int i = 1; i <= 10; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine("循环式列1（计算阶乘）结果为: "+sum);

            //循环式列2 ///////////////
            string str = "My test string.";//声明一个字符串
            string result = "";
            for (int i = 0; ; i++)//省略循环语句的判断条件
            {
                result = result + str[i].ToString() + " ";//使用空格间隔字符串
                if (str[i] == '.')
                    break;//遇到句号跳出循环
            }
            Console.WriteLine("循环式列2（间隔字符串）结果为：" + result);

            //循环式列3//////////////////
            //以下是只有判断条件的for循环语句，只有按下“Q”键时循环才能结束，否则将一直循环
            for (; Console.ReadKey(true).Key != ConsoleKey.Q; )
            {
                Console.WriteLine("按下Q键退出。");
            }
            for (; Console.ReadKey(true).Key != ConsoleKey.A; )
            {
                Console.WriteLine("试试的试试！！");
            }
        }
    }
}










