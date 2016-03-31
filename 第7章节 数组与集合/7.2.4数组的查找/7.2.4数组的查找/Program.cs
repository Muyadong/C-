using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._2._4数组的查找
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1,2,3,2,5};
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

            //在数组myarray中寻找第一个出现的值为2的元素位置
            int m = Array.IndexOf(myArray,2);
            Console.WriteLine("2在数组中第一次出现的位置是：{0}",m);
            //在数组myarray中寻找最后一个出现的值为2的元素位置
            int n = Array.LastIndexOf(myArray,2);
            Console.WriteLine("2在数组中最后一次出现的位置是：{0}",n);

            //在数组myarray中寻找索引号在0-3之间的值为2的元素的位置
            int w = Array.IndexOf(myArray,2,0,3);
            Console.WriteLine("2在数组0-3号元素中出现的位置是：{0}",w);
            Console.ReadLine();
        }
    }
}
