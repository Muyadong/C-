using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11._1._3文件
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //设置所要创建文件的绝对路径
            string path = @"F:\VS C#文件\test.txt";
            //以路径为参数创建文件
            File.Create(path);
        }
    }
}
