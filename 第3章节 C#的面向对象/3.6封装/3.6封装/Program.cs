using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
//封装是指将对象的信息进行隐藏，是他的使用者无法看到，而只是提供一个访问接口。。。。
namespace _3._6封装//封装的用途是防止数据收到意外破坏！！
{
    class Test
    {
        private int a;
        public int wr()
        {
            return a;
        }
        public void rd(int value)
        {
            a = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test ts = new Test();
            ts.rd(3);
            ts.wr();
        }
    }
}
