using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._3._2冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 98, 85, 76, 91, 64, 90, 89, 63, 83, 94 };//定义数组存储成绩
            int temp;//临时变量
            //开始冒泡排序
            for (int i = 0; i < scores.Length; i++)
            {
                //将最大的元素交换到最后
                for (int j = 0; j < scores.Length-i-1; j++)
                {
                    if (scores[j] > scores[j + 1])
                    {
                        //交换元素
                        temp = scores[j];
                        scores[j] = scores[j + 1];
                        scores[j + 1] = temp;
                    }
                }
            }
            //排序后输出
            Console.WriteLine("排序后的成绩为：");
            foreach (int item in scores)
            {
                Console.Write("{0}\t",item.ToString());
            }
            Console.ReadLine();
        }
       
        
    }
}
