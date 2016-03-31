using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._3异常处理语句
{
    /// <summary>
    /// 未使用异常处理机制实例
    /// </summary>
   /* public class Shuchu
    {
        public void test()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= 6; i++)//i==6时越界了
            {
                Console.WriteLine(arr[i]);
            }

        }
    }*/
    public class Shuchu
    {
        public void test_withtry()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 0; i <= 6; i++)//i==6时越界了
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exit test_withtry()");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shuchu s = new Shuchu();
            s.test_withtry();
        }
    }
}
