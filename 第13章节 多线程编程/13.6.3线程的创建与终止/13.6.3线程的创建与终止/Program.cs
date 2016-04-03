using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._6._3线程的创建与终止
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建并启动线程
            Thread th = new Thread(new ThreadStart(threadmethod));
            th.Start();
            Thread.Sleep(1000);//将主线程 暂停一秒
            //通过主线程终止新开的线程
            Console.WriteLine("主线程正在终止新开的线程...");
            th.Abort("EXIT");//终止线程
            th.Join();//等待新开的线程结束
            Console.WriteLine("新线程结束，主线程停止.");
            Console.ReadKey();
        }
        static void threadmethod()//新线程的执行函数
        {
            try 
            {
                while (true)
                {
                    Console.WriteLine("新线程正在运行.....");
                    Thread.Sleep(1000);
                }
            }
            catch(ThreadAbortException e)
            {
                Console.WriteLine("新线程异常，消息：{0}",e.Message);
            }
        }
    }
}
