using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._3._4使用线程池
{
    class Program
    {
        private int count;//线程的计数
        public Program(int count)
        {
            this.count = count;
        }
        public int Count            //设置Count属性
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }
        public static void test(object obj)
        {
            Console.WriteLine("启动线程{0}",((Program)obj).Count);
            Thread.Sleep(5000);                                         //主线程睡眠5秒
            Console.WriteLine("结束线程{0}",((Program)obj).Count);
        }
        static void Main(string[] args)
        {
            WaitCallback wcb = new WaitCallback(Program.test);//实例化 回掉函数！

           
            ThreadPool.QueueUserWorkItem(wcb,new Program(1));//往线程池里添加第一个线程！
            ThreadPool.QueueUserWorkItem(wcb,new Program(2));//二
            ThreadPool.QueueUserWorkItem(wcb,new Program(3));
            ThreadPool.QueueUserWorkItem(wcb,new Program(4));
            ThreadPool.QueueUserWorkItem(wcb,new Program(5));
           
            Console.ReadKey();
        }
    }
}
//线程池的缺点是：对线程不能进行控制，也没法设置线程的优先级！！！！！！！
