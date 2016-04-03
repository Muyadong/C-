using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace _13._3._5使用定时器
{
    class Program
    {
        public void time(object o)
        {
            Console.WriteLine("登录{0}",o);
            Console.WriteLine("等待5秒....");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            TimerCallback tcb = new TimerCallback(p.time);
            Timer timer = new Timer(tcb,"你好",0,5000);//设定定时器回掉方法的延迟为0秒，定时器间隔为5秒
            Console.ReadKey();
        }
    }
}
