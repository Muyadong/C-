using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace _7._5._1ArrayList类的常用操作
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myarraylist = new ArrayList(3);
            //分别插入hello和world两个字符串到myarraylist尾部
            myarraylist.Add("Hello ");
            myarraylist.Add("World!");
            //分别输出myarraylist中的两个元素
            Console.WriteLine(myarraylist[0]);
            Console.WriteLine(myarraylist[1]);

            //输出添加后的元素个数
            Console.WriteLine("Count:{0}",myarraylist.Count);
            //myarraylist.Clear();//清除myarraylist中的所有元素并输出
            //Console.WriteLine("Count:{0}",myarraylist.Count);

            //myarraylist.Remove("Hello ");//移除myarraylist中的hello字符串
            //Console.WriteLine("Count:{0}",myarraylist.Count);

            myarraylist.RemoveAt(0);//删除索引值为0的元素，即hello
            Console.WriteLine(myarraylist[0]);
            Console.WriteLine("Count:{0}",myarraylist.Count);
            Console.ReadLine();
        }
    }
}
