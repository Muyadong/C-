using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._3._3复制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string SourceFileName = @"F:\VS C#文件\test.txt";//源文件路径及文件名
            string DestinationFileName = @"F:\VS C#文件\text.txt";//目标文件路径及文件名
            try
            {
                if (!File.Exists(SourceFileName))//判断源文件是否存在
                {
                    Console.WriteLine("找不到源文件！！");
                }
                else if (File.Exists(DestinationFileName))//判断目标文件是否存在
                {
                    Console.WriteLine("目标文件已存在，是否覆盖？（Y/N）");
                    if (Console.ReadKey(false).Key == ConsoleKey.Y)
                    {
                        File.Copy(SourceFileName, DestinationFileName, true);//覆盖文件
                        Console.ReadLine();
                        Console.WriteLine("文件复制成功！");
                    }
                    else
                    {
                        Console.ReadLine();
                        Console.WriteLine("取消文件复制！！！");
                    }
                }
                else
                {
                    File.Copy(SourceFileName, DestinationFileName, true);//覆盖文件
                    Console.WriteLine("复制文件成功！");
                }
            }
            catch
            {
                Console.WriteLine("文件复制失败！");

            }
            Console.ReadLine();
        }
    }
}
