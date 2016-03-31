using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._8._3方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一次比较结果：{0}", Compare("A", "a"));
            //根据参数的数目和数据类型，自动调用相应的重载方法。
            Console.WriteLine("第二次比较的结果：{0}",Compare("A","a",true));
            Console.ReadLine();
        }
        static bool Compare(string strA, string strB)
        {
            return strA == strB;
        }
        //对比两个字符串的重载方法，ignoreCase参数表示是否忽略大小写。。。。
        static bool Compare(string strA, string strB, bool ignoreCase)
        {
            if (ignoreCase)
            {
                return strA.ToLower() == strB.ToLower();
            }
            else
            {
                return strA == strB;
            }
        }
    }
}
