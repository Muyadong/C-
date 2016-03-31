using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._5._2异常的继承关系
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null;//定义空字符串
            //使用try..catch语句处理异常
            try
            {
                Console.WriteLine("进入try语段.....");
                Console.WriteLine("将字符串小写：" + s.ToLower());
                Console.WriteLine("离开try语段...");
            }
            //使用catch捕获异常
            catch (Exception e)
            {
                Console.WriteLine("进入catch语段 ...");
                Console.WriteLine("其他异常被捕获！");
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)//应该考虑异常之间的继承关系
            {//这个catch 将永远不会被执行，成为无用代码。！！！！！！！！！！！！！！！！
            }
        }
    }
}
