using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._1._3代理引用的声明和使用
{
    class Program
    {
        //定义MyDelegate代理
        delegate int MyDelegate(int p,int q);
        //定义符合MyDelegate代理类型的方法
        static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            //创建一个指向add方法的代理的引用
            MyDelegate arithMethod = new MyDelegate(add);
            //通过代理引用调用add（）方法
            int r = arithMethod(3,4);
            Console.WriteLine("3和4相加的结果是：{0}",r);
        }
    }
}
