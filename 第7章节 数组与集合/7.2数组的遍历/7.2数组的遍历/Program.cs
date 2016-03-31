using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._2数组的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            //C#提供了foreach语句以实现数组的遍历功能
            int[] myArray = new int[] {1,2,3,4,5};

            //采用foreach语句对myArray进行遍历
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
