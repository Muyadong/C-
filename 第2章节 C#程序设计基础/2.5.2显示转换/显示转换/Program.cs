using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 显示转换
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = 5.00;
            int n;
            n = Convert.ToInt32(m);
            Console.WriteLine("n="+n);
            Console.ReadKey();
        }
    }
}