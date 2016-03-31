using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._1._7多重代理的实现方法
{
    class Program
    {  //定义代理
        delegate void MyMulticastDelegate(int p,int q);
        static void Main(string[] args)
        {
            //创建MyMulticastDelegate类型的引用
            MyMulticastDelegate arithMethod = null;
            //使用arithMethod引用指向不同的方法
            arithMethod = new MyMulticastDelegate(Add);
            arithMethod += new MyMulticastDelegate(Substract);//实现多重（+=）
            arithMethod += new MyMulticastDelegate(Max);
            //通过arithMethod引用调用方法
            arithMethod(3,4);
            Console.WriteLine("\n从多重代理中移除Substract（）方法后，当前代理所指向的方法：");
            arithMethod -= new MyMulticastDelegate(Substract);//实现移除（-=）
            arithMethod(3,4);
           
        }
        static void Add(int p, int q)
        {
            Console.WriteLine("3和4的和是：{0}",p+q);
        }
        static void Substract(int p, int q)
        {
            Console.WriteLine("3和4的差是：{0}",p-q);
        }
        static void Max(int p, int q)
        {
            if (p > q)
            {
                Console.WriteLine("3和4 的最大值是:{0}", p);
            }
            else
            {
                Console.WriteLine("3和4的最大值是：{0}",q);
            }
        }
    }
}
