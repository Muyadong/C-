using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._3._2_Lock关键字锁定线程
{
    class Program
    {
        int count = 0;
        public void test()
        {
            lock (this)//锁定代码
            {
                count++;//计数
                Console.WriteLine(count.ToString());//输出计数
                Thread.Sleep(1000);
            }
        }       //internal表示只能在此程序集中访问threads！！！！函数外部不能调用！！！
        static internal Thread[] threads = new Thread[10];//定义容量为10的数组
        static void Main(string[] args)
        {
            Program p = new Program();//实例化类  目的是调用里面的test函数
            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(p.test));
                threads[i] = t;
            }
            for (int i = 0; i < 10; i++)
            {
                threads[i].Start();
            }
            Console.ReadLine();
        }
    }
}
//加与不加lock关键字的区别是：加lock关键字后输出是每隔一秒输出一个数字，且输出的数字依次加一，不加则是一次性输出，且
//数字输出的顺序也不规则！！！！