using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._6._2同步线程的创建和使用
{
    class Program
    {
        private static Mutex mut = new Mutex();//所使用的互斥体对象
        private const int iteration = 1;//模拟的访问次数
        private const int threadcount = 3;//模拟的线程数目

        //线程入口函数，该函数将使用公共的资源
        private static void headproc()
        {
            for (int i = 0; i < iteration; i++)
            {
                usesource();
            }
        }
        //使用资源的 函数，该函数能保证 某一时刻 只有一个线程使用资源
        private static void usesource()
        {
            mut.WaitOne();//请求使用资源，如果其他线程正在使用，则等待>
            Console.WriteLine("线程{0}开始使用资源",Thread.CurrentThread.Name);//获取当前正在使用资源的名字
            Thread.Sleep(500);//使用资源的代码
            Console.WriteLine("线程{0}使用资源完毕",Thread.CurrentThread.Name);
            mut.ReleaseMutex();//释放互斥体！！
        }
        static void Main(string[] args)
        {
            //创建多个线程，这些线程都将使用同一个资源
            Thread[] arrthread = new Thread[threadcount];
            for (int i = 0; i < threadcount; i++)
            {
                arrthread[i] = new Thread(new ThreadStart(headproc));
                arrthread[i].Name = string.Format("Thread{0}",i+1);
                arrthread[i].Start();
            }
        }
    }
}
