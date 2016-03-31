using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
namespace _7._7._5HashTable的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable myhashtable = new Hashtable();
            myhashtable.Add(1,"H");
            myhashtable.Add(2,"e");
            myhashtable.Add(3,"l");
            myhashtable.Add(4,"l");
            myhashtable.Add(5,"o");
            myhashtable.Add("int",2);
            myhashtable.Add("double",2.3);
            myhashtable.Add("bool",true);

            Console.WriteLine("\t键\t值");
            //遍历哈希表中的所有元素
            foreach (DictionaryEntry myde in myhashtable)
            {
                Console.WriteLine("\t{0}\t{1}",myde.Key,myde.Value);
            }
            //hashtable的查找
            //输出相应的查找结果
            Console.WriteLine("myhasgtable包含键1：{0}",myhashtable.Contains(1));
            Console.WriteLine("myhashtable包含键6：{0}",myhashtable.Contains(6));
            Console.WriteLine("myhashtable包含键true:{0}",myhashtable.ContainsValue(true));
            Console.WriteLine("myhashtable包含键3.3：{0}", myhashtable.ContainsValue(3.3));

            Console.ReadLine();
        }
    }
}
