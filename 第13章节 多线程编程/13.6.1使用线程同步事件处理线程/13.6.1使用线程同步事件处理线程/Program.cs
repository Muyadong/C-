using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._6._1使用线程同步事件处理线程
{
    class Program
    {
        static ManualResetEvent ev1;
        static ManualResetEvent ev2;
        public static void firstthread()//第一个线程的入口函数
        {
            Console.WriteLine("线程1启动！");
            Console.WriteLine("线程1执行：");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine("\r\n线程1停止！");
            ev1.Set();//设置事件，启动线程2！
        }

        public static void secondthread()//第二个线程入口
        {
            Console.WriteLine("线程2等待线程1执行完毕");
            ev1.WaitOne();//阻止当前线程，直到收到信号
            Console.WriteLine("线程2启动");
            Console.WriteLine("线程2执行");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine("\r\n线程2停止");
            ev2.Set();

        }
        public static void thirdthread()
        {
            Console.WriteLine("线程3等待线程2执行完毕");
            ev2.WaitOne();
            Console.WriteLine("线程3启动");
            Console.WriteLine("线程3执行");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine("\r\n线程3停止");
        }

        static void Main(string[] args)
        {
            ev1 = new ManualResetEvent(false);
            ev2 = new ManualResetEvent(false);//创建三个线程
            Thread first = new Thread(new ThreadStart(firstthread));
            Thread second = new Thread(new ThreadStart(secondthread));
            Thread third = new Thread(new ThreadStart(thirdthread));
            third.Start();//首先启动第三个线程
            first.Start();
            second.Start();

            third.Join();//等待线程结束，只需等待第三个线程运行结束

            Console.WriteLine("线程3运行结束");
            Console.WriteLine("线程1的状态：{0}",first.ThreadState.ToString());
            Console.WriteLine("线程2状态：{0}",second.ThreadState.ToString());
            Console.WriteLine("按任意键退出...");
            Console.ReadKey();


        }
    }
}
