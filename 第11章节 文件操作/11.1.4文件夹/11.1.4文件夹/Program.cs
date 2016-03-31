using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._1._4文件夹
{
    class Program
    {
        static void Main(string[] args)
        {
            //文件夹类 directory
            //设置所要创建文件夹的绝对路径
            //string path = @"F:\VS C#文件\text";
            //Directory.CreateDirectory(path);

            //文件夹信息类 directoryinfo
            //设置所要检测的文件夹绝对路径
            string path = @"F:\VS C#文件\text";
            //以路径为参数 构造directoryinfo 对象
            DirectoryInfo paths = new DirectoryInfo(path);
            if (paths.Exists)
            {
                Console.WriteLine("文件夹存在！");
            }
            else
            {
                Console.WriteLine("文件夹不存在！");
            }

            Console.WriteLine(Path.GetDirectoryName(path));//获得目录名
            Console.WriteLine(Path.GetFileName(path));//获取文件名

        }
    }
}
