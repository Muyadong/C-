using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._3._1Sort方法排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] {13,27,46,39,62,83,27,36};
            Console.WriteLine("数组排序前：");
            foreach (int i in myArray)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("指定数组元素排序");
            //对数组中从索引为1的元素开始的3个元素排序
            Array.Sort(myArray,1,3);///////////////////////////////////////////
            foreach (int i in myArray)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("数组元素排序后");
            //对数组中所有的元素进行排序
            Array.Sort(myArray);/////////////////////////////////////////
            foreach (int i in myArray)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine("\n");

            Console.ReadLine();
        }
    }
}
