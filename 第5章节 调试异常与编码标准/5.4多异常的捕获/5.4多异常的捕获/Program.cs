using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._4多异常的捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义字符串变量
            string s = "Hello World";//正常显示结果
            //string s = null;//将字符串S的值设置为null，将产生NullReferenceException异常
            int[] i = new int[3];
            //使用try和catch结构处理异常
            try
            {
                Console.WriteLine("进入try语段....\n");
                //可能引发NullReferenceException异常
                Console.WriteLine("将字符串小写："+s.ToLower());
                //可能引发NullReferenceException异常和IndexOutOfRangeException异常
                Console.WriteLine("数组中的第一个元素是：" + i[0].ToString());
               // Console.WriteLine("数组中的第一个元素是：" + i[5].ToString());//尝试输出数据为第五个数据将产生IndexOutOfRangeException异常
                //可能引发除数为零的异常
                i[0] = 3;
                //i[0] = 0;//将i的值改为0；将产生DivideByZeroException异常
                i[1] = 4 / i[0];
                Console.WriteLine("\n离开try语段");
            }
            //使用catch捕获不同的异常
            catch (NullReferenceException e)
            {
                Console.WriteLine("\n进入catch语段...");
                Console.WriteLine("NullReferenceException异常被捕获！");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("\n进入catch语段.....");
                Console.WriteLine("IndexOutOfRangeException异常被捕获！");
            }
            catch (Exception e)
            {
                //打印异常信息
                Console.WriteLine("\n进入catch语段.....");
                Console.WriteLine("其它异常被捕获！！！");
                Console.WriteLine(e.Message);
            }
        }
    }
}
