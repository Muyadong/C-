using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试调用函数
{
    class Program
    {
        public class Use
        {
            public int Test(int x)
            {
                while(x>60)
                {
                    Console.WriteLine("jige!!");
                    break;
                   // return x;
                }
                while (x == 80)
                {
                    Console.WriteLine("lianghaio");
                    break;
                }
                return 0;
            }
            static void Main(string[] argc)
            {
                Use use= new Use();
                int x = 80;
                Console.WriteLine("输出的结果是: "+ use.Test(x));
            }
        }
        /*
        static void Main(string[] args)
        {
            int i = 0;
           
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
               // Console.ReadLine();
               // break;
              
            }
        }
         */

        
    }
}
