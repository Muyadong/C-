using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._3._1创建日志文件
{
    class Program
    {
        const string filename = @"F:\VS C#文件\logfile.txt";
        static void Main(string[] args)
        {
            //从指定的目录以打开或者创建的形势读取日志文件
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write))
            {
                //创建日志文件的写入流
                StreamWriter sw = new StreamWriter(fs);
                //向日志文件中写入日志文件
                log("日志创建成功！",sw);//向文件日志 写入日志信息
                sw.Close();
                Console.WriteLine("日志文件已被创建！");

            }
            //读取并显示日志文件
            using (StreamReader sr = new StreamReader(filename, Encoding.UTF8))
            {
                string strcontent = sr.ReadToEnd();//读取所有数据
                sr.Close();
                Console.WriteLine(strcontent);
            }
            Console.ReadLine();

        }
        static void log(string message, TextWriter wtr)
        {
            wtr.Write("log entry: ");
            wtr.WriteLine("{0}{1}",DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
            wtr.WriteLine(" :");
            wtr.WriteLine(" :{0}",message);
            Console.WriteLine("--------------------------------");
            wtr.Flush();//将缓冲区的文件内容更新到日志文件中！
        }

    }
}
