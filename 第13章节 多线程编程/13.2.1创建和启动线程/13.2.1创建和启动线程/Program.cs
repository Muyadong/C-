using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._2._1创建和启动线程
{
    class Program
    {
        public void Task()//定义一个简单的任务
        {
            Console.WriteLine("我的第一个线程！！！");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(new ThreadStart(p.Task));//创建线程
            t1.Start();//启动线程
            Console.Read();
        }
    }
}
