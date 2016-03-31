using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._1._3文件信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置所要检测文件的绝对路径，以路径构造对象
            //string path = @"F:\VS C#文件\text";
            //FileInfo t_path = new FileInfo(path);


            FileInfo path = new FileInfo(@"F:\VS C#文件\text");
            //检测文件是否存在
            if (path.Exists)
            {
                Console.WriteLine("文件存在！");
            }
            else
            {
                Console.WriteLine("文件不存在！");
            }

        }
    }
}
