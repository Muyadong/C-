using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._7._2获取异常信息
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //试图将字符串赋值给整形变量时 将会引起异常，从而输出异常信息。
                int.Parse("Error");
                
            }
            catch (Exception err)
            {
                //获取并输出描述异常的文字信息
                Console.WriteLine("当前异常的描述为："+err.Message);
                //获取并输出引发异常的方法名称
                Console.WriteLine("引起异常的方法是："+err.TargetSite.Name);
                //获取并输出异常的来源名称，通常是应用程序的名称
                Console.WriteLine("异常的来源名称是："+err.Source);
                //获取并输出异常产生时，调用堆栈上的程序位置
                Console.WriteLine("异常在堆栈中的帧："+err.StackTrace);
                Console.ReadLine();
            }
        }
    }
}
