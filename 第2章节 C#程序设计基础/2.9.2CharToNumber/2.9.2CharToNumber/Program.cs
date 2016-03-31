using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._9._2CharToNumber//字符类型与数字类型的转换
{
    class Program
    {
        static void Main(string[] args)
        {
            char testchar1 = 'a';
            int testint1 = testchar1;//隐式转换，将 char 类型赋值给int 类型
            Console.WriteLine("字符{0}的数值是： {1}",testchar1,testint1);

            decimal testdecimal2 = 114.9923m;//decimal类型变量赋值加扩展名“m”
            char testchar2 = (char)testdecimal2;//显示转换，将decimal类型转换为char类型
            Console.WriteLine("小数{0}表示的字符是： {1}",testdecimal2,testchar2);
            Console.ReadLine();
        }
    }
}
