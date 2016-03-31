using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11._1._2目录
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"F:\VS C#文件\text");
            if (Directory.Exists(@"F:\VS C#文件\text"))
                Console.WriteLine("创建成功！");
            Directory.Delete(@"F:\VS C#文件\text");
            if (!Directory.Exists(@"F:\VS C#文件\text"))
                Console.WriteLine("删除成功！");

            DirectoryInfo dir = new DirectoryInfo(@"F:\VS C#文件\text");
            if (!dir.Exists)
            {
                dir.Create();
            }
            else
            {
                Console.WriteLine("该目录已存在！");
            }
            dir.Delete();
        }
    }
}
