using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._7._3使用try._._.catch捕获异常
{
    class MyException : Exception//自定义的异常类，继承于 Exception类
    {
        public MyException(string message)
            : base(message)//继承Exception类的构造函数
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //在try语句的外部声明变量，否则catch语句所包含的代码段无法识别i变量
            int i=0;
            try
            {
                i = int.Parse("Error");//此处代码在将字符串转换为整形是引起异常
            }
            catch//catch之后不带任何参数，表示处理任何异常
            {
                Console.WriteLine("不作异常捕捉的处理，变量i的值为：{0}",i);
            }
            try
            {
                ThrowException();
            }
                //在未明错误的情况下使用所有异常的基类来获取异常信息，不建议使用
            catch (Exception currerr)
            {
                Console.WriteLine("引起异常 的方法是：{0}",currerr.TargetSite.Name);
            }
            Console.ReadLine();
        }
        static void ThrowException()//抛出异常的方法
        {
            try
            {
                //创建一个自定义异常的实例
                MyException err = new MyException("自定义异常的信息");
                throw err;//抛出异常
            }
            catch (MyException e)//捕获指定类型的异常
            {
                Console.WriteLine(e.Message);
                //ThrowException方法的目的是为了传输异常，在此处抛出，使调用程序处理
                throw;
            }
        }
    }
}
