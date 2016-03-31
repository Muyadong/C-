using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _7._5._4ArrayList元素的获取
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarraylist = new ArrayList(3);

            myarraylist.Add("元素1");
            myarraylist.Add("元素2");
            myarraylist.Add("元素3");
            myarraylist.Add("元素4");

            //分别输出myarraylist的容量和元素个数
            Console.WriteLine("容量：{0}",myarraylist.Capacity);
            Console.WriteLine("元素个数：{0}",myarraylist.Count);
            //输出myarraylist的4个元素
            Console.WriteLine(myarraylist[0]);
            Console.WriteLine(myarraylist[1]);
            Console.WriteLine(myarraylist[2]);
            Console.WriteLine(myarraylist[3]);

            Console.ReadLine();
        }
    }
}
