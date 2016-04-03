using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._2._3中断和终止线程
{
    class Program
    {
        public static Thread sleeper;
        public static Thread awaker;

        public void SleepThread()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + ",");
                if (i == 4 || i == 8)
                {
                    Console.WriteLine("Thread is sleep at "+ i);
                    try
                    {
                        Thread.Sleep(20);//暂停线程
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
        public void AwakerThread()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.Write(i + ",");
                if (sleeper.ThreadState == System.Threading.ThreadState.WaitSleepJoin)
                {
                    Console.WriteLine("Thread is awaker at "+ i);
                    sleeper.Interrupt();//中断线程
                }
            }
        }


        static void Main(string[] args)//Thread类的构造函数的参数是Delegate类型~~~~
        {
            Program p = new Program();      //CLR专门提供了ThreadStart委托类！！！
            sleeper = new Thread(new ThreadStart(p.SleepThread));//创建第一个线程
            awaker = new Thread(new ThreadStart(p.AwakerThread));//创建第二个线程

            sleeper.Start();//启动第一个线程
            awaker.Start();//启动第二个线程

            Console.Read();
        }
    }
}
