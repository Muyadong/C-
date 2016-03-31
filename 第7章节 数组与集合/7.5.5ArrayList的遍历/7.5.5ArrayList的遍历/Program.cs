using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _7._5._5ArrayList的遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarraylist = new ArrayList(5);
            //向Arraylist中添加元素 
            myarraylist.Add("H");
            myarraylist.Add("e");
            myarraylist.Add("l");
            myarraylist.Add("l");
            myarraylist.Add("o");
            //遍历arraylist中的所有元素并输出
            foreach (string i in myarraylist)
            {
                Console.WriteLine(i);
            }
            //元素的查找
            Console.WriteLine("myarraylist包含元素\"H\":");
            Console.WriteLine(myarraylist.Contains("H"));
            Console.WriteLine("myarraylist包含元素\"W\":");
            Console.WriteLine(myarraylist.Contains("W"));

            Console.ReadLine();

        }
    }
}
