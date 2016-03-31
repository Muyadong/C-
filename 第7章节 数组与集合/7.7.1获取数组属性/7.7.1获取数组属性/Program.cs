using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._7._1获取数组属性
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyIntArray = new int[] {1,2,3,4,5};//定义一个一维数组
            //定义一个二维数组
            long[,] MyLongArray = new long[,] { { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };
            //定义一个交错数组
            float[][] MyFloatArray = {new float[]{1.0f,1.1f,1.2f},new float[]{1.3f,1.4f,1.5f} };
            Console.WriteLine("MyIntArray长度是否固定："+ MyIntArray.IsFixedSize);
            Console.WriteLine("MyIntArray是否只读：" + MyIntArray.IsReadOnly);
            Console.WriteLine("MyIntArray是否同步访问："+ MyIntArray.IsSynchronized);
            Console.WriteLine("MyIntArray长度："+ MyIntArray.Length);
            Console.WriteLine("MyIntArray维数："+ MyIntArray.Rank);
            Console.WriteLine("MyIntArray同步访问对象："+ MyIntArray.SyncRoot);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("MyLongArray长度是否固定：" + MyLongArray.IsFixedSize);
            Console.WriteLine("MyLongArray是否只读：" + MyLongArray.IsReadOnly);
            Console.WriteLine("MyLongArray是否同步访问：" + MyLongArray.IsSynchronized);
            Console.WriteLine("MyLongArray长度：" + MyLongArray.Length);
            Console.WriteLine("MyLongArray维数：" + MyLongArray.Rank);
            Console.WriteLine("MyLongArray同步访问对象：" + MyLongArray.SyncRoot);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("MyFloatArray长度是否固定：" + MyFloatArray.IsFixedSize);
            Console.WriteLine("MyFloatArray是否只读：" + MyFloatArray.IsReadOnly);
            Console.WriteLine("MyFloatArray是否同步访问：" + MyFloatArray.IsSynchronized);
            Console.WriteLine("MyFloatArray长度：" + MyFloatArray.Length);
            Console.WriteLine("MyFloatArray维数：" + MyFloatArray.Rank);
            Console.WriteLine("MyFloatArray同步访问对象：" + MyFloatArray.SyncRoot);
            Console.WriteLine("-------------------------------------------------------");

            lock (MyIntArray.SyncRoot)//锁定数组同步对象的实例
            {
                Console.Write("MyIntArray的元素列表：");
                foreach (int ivalue in MyIntArray)
                {
                    Console.Write(ivalue+",");
                }
            }
            Console.WriteLine();
            lock (MyLongArray.SyncRoot)
            {
                Console.Write("MyLongArray的元素列表：");
                foreach (long ivalue in MyLongArray)
                {
                    Console.Write(ivalue+",");
                }
            }
            Console.WriteLine();
            //lock (MyFloatArray.SyncRoot)
            //{
            //    Console.Write("MyFloatArray的元素列表：");
            //    foreach (float[] ivalue in MyFloatArray)//有误 ！！！！！！！！
            //    {
            //        Console.Write(ivalue +",");
            //    }
            //}
            Console.ReadLine();
        }
    }
}
