using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._3._3线程的同步
{
    class Program
    {
        int count = 1000;
        public void Add()
        {
            Monitor.Enter(this);//使用Add函数获取   ~排它锁~
            for (int i = 0; i < 5; i++)
            {
                count = count + 10;
                Console.WriteLine("加10后："+ count.ToString()+"\n");//输出加10后的变量
            }
            Monitor.Exit(this);//释放排它锁
        }
        public void Decrease()
        {
            Monitor.Enter(this);
            for (int i = 0; i < 5; i++)
            {
                count = count - 5;
                Console.WriteLine("减5后："+ count.ToString()+"\n");
            }
            Monitor.Exit(this);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread t1 = new Thread(new ThreadStart(p.Add));//实例化线程一
            Thread t2 = new Thread(new ThreadStart(p.Decrease));//二

            try
            {
                t1.Start();//启动线程
                t2.Start();
                t1.Join();//阻塞调用 线程，直到当前线程终止！
                t2.Join();
                Console.ReadLine();
            }
            catch (ThreadStartException ex)//捕获线程状态异常！！1
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)//捕获其它异常！！！
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
