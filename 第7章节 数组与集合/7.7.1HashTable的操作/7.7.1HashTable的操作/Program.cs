using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _7._7._1HashTable的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myhashtable = new Hashtable();
            //插入相应的键和值组成的元素
            myhashtable.Add(1,"H");
            myhashtable.Add(2,"e");
            myhashtable.Add(3,"l");
            myhashtable.Add(4,"l");
            myhashtable.Add(5,"o");
            myhashtable.Add("int",1);
            myhashtable.Add("double",2.3);
            myhashtable.Add("bool",true);

            //Console.WriteLine("哈希表中的元素个数为：{0}",myhashtable.Count);
            ////调用Clear方法对myhashtable进行清空
            ////myhashtable.Clear();
            ////调用remove方法删除键为1和int的元素
            //myhashtable.Remove(1);
            //myhashtable.Remove("int");
            //Console.WriteLine("哈希表中的元素个数为：{0}",myhashtable.Count);

            //修改相应的键和值组成的元素
            myhashtable["int"] = 23;
            myhashtable["double"] = 15;
            myhashtable["bool"] = false;
            //输出相应的键和值组成的元素
            Console.WriteLine(myhashtable[1]);
            Console.WriteLine(myhashtable[2]);
            Console.WriteLine(myhashtable[3]);
            Console.WriteLine(myhashtable[4]);
            Console.WriteLine(myhashtable[5]);
            Console.WriteLine(myhashtable["int"]);
            Console.WriteLine(myhashtable["double"]);
            Console.WriteLine(myhashtable["bool"]);


            Console.ReadLine();
        }
    }
}
