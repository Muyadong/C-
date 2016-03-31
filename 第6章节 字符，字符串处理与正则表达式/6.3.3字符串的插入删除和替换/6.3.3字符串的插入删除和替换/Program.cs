using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._3._3字符串的插入删除和替换
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("aaaaa");//追加字符串aaaaa
            sb.Insert(1,"ssss");//在第一个a后面添加字符串ssss
            Console.WriteLine(sb);
            sb.Replace('s','b');//将字符s替换为b
            Console.WriteLine(sb);
            sb.Remove(1,4);//从索引值为1的地方开始删除4个字符
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
