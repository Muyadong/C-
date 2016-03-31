using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._2._3数组元素清空
{
    class Program
    {
        //Array.Clear方法定义
        //public static void Clear(Array array,int index,int length)
        //参数array为要进行删除操作的数组，index为要清除的一系列元素的起始索引，length为要清除的元素个数
        static void Main(string[] args)
        {
            int[] myArray = new int[] {1,2,3,4,5};
            //输出未清空时 的数组的元素值
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
            Array.Clear(myArray, 2, 3);//从myarray数组的2号索引元素开始清空3个元素值
            //输出变化后的结果和数组长度
            Console.WriteLine("清空操作后：");
            Console.WriteLine("数组清空操作后的长度：{0}",myArray.Length);

            //输出变化后数组的内容
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
