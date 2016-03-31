using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._1._5代理做方法的参数
{
    class Program
    {
        //定义代理
        delegate int MyDelegate(int p,int q);
        static void Main(string[] args)
        {
            //创建MyDelegate类型的引用
            MyDelegate arithMethod = null;
            //打印输出提示信息
            Console.WriteLine("选择对3和4执行的算数操作：");
            Console.WriteLine("按“+”键执行加法运算：");
            Console.WriteLine("按“-”键执行减法运算：");
            Console.WriteLine("按“m”键求两个数的最大值：");
            char choice = (char)Console.Read();
            //根据用户输入进行不同的处理
            switch (choice)
            {
                case '+':
                    arithMethod = new MyDelegate(Add);
                    break;
                case'-':
                    arithMethod = new MyDelegate(Subtract);
                    break ;
                case'm':
                    arithMethod = new MyDelegate(Max);
                    break;
                default:
                    arithMethod = new MyDelegate(Add);
                    break;
            }
            PerformArithoperation(3,4,arithMethod);
        }
        //使用MyDelegate类型变量作为方法参数
        static void PerformArithoperation(int a, int b, MyDelegate arithOperation)
        {
            int r = arithOperation(a, b);
            Console.WriteLine("\n对3和4执行算数操作后的结果是：{0}",r);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
