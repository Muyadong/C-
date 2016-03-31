using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._5定义用户异常的方法
{
    class InvalidArgumentException : ApplicationException
    {
        public InvalidArgumentException()
            : base("Divide By Zero Error")
        { }
        public InvalidArgumentException(string Message)
            : base(Message)
        { }
    }
    class Program
    {
        static double Divide(double a, double b)
        {
            //对分母B的值进行判断，抛出异常
            if (b == 0)
            {
                throw new InvalidArgumentException();
            }
            double c = a / b;
            return c;
        }
        static void Main(string[] args)
        {
            //使用try...catch结构处理异常
            try
            {
                Console.WriteLine("进入try语段...");
                double d = Divide(3, 0);
                Console.WriteLine("\t除法的结果：{0}", d);

            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine("\n进入catch语段....");
                Console.WriteLine("\nSystem.InvalidArgumentException异常被捕获.....");
                Console.WriteLine("\n错误:"+e.Message);
            }
        }
    }
}
