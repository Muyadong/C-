using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._1._3代理使用
{
    class Program
    { 
        //定义MyDelegate代理
        delegate int MyDelegate(int p,int q);

        static void Main(string[] args)
        {
            //创建MyDelegate类型的引用
            MyDelegate arithMethod = null;
            string myoperate = null;
            
            //打印输出提示信息
            Console.WriteLine("选择对3和4执行的算数操作：");
            Console.WriteLine("按“+”键执行加法操作：");
            Console.WriteLine("按“-”键执行加法操作：");
            Console.WriteLine("按“m”求两个数的最大值：");

            char choice = (char)Console.Read();
            //根据用户输入不同进行不同处理
            switch (choice)
            {
                case'+':
                    arithMethod = new MyDelegate(add);
                    myoperate = "加法";
                    break;
                case'-':
                    //使用arithmethod引用指向subtract（）方法
                    arithMethod = new MyDelegate(subtract);
                    myoperate = "减法";
                    break;
                case'm':
                    arithMethod = new MyDelegate(max);
                    myoperate = "求最大值";
                    break;
                default:
                    //默认使用arithmetic引用指向add（）方法
                    arithMethod = new MyDelegate(add);
                    myoperate = "加法";
                    break;
            }
            //通过arithmethod引用调用相应方法
            int r = arithMethod(3,4);
            Console.WriteLine("\n对3和4执行{0}操作后的结果：{1}",myoperate,r);
            
           
        }
        //定义符合mydelegate代理类型的Add（）方法
        static int add(int a, int b)
        {
            return a + b;
        }
        static int subtract(int a, int b)
        {
            return a - b;
        }
        static int max(int a, int b)
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
