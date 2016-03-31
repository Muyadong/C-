using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._3._2日志文件的读写
{
    class Program
    {
        //表示日志文件路径及文件名称的字符串
        const string filename = @"F:\VS C#文件\test.txt";

        static void Main(string[] args)
        {
            writelogfile(filename,"日志信息一");//写入日志信息
            writelogfile(filename,"日志信息二");
            Console.WriteLine(readlogfile(filename));//读取日志文件
            Console.ReadLine();

        }
        static string readlogfile(string filenamewithpath)
        {
            //从指定的目录以打开或者创建的形式读取日志文件
            FileStream fs = new FileStream(filenamewithpath,FileMode.OpenOrCreate,FileAccess.Read);
            //定义输出字符串
            StringBuilder output = new StringBuilder();
            //初始化该字符串的长度为0
            output.Length = 0;
            //为上面创建的文件流创建读取数据流
            StreamReader read = new StreamReader(fs);
            //设置当前流的起始位置为文件流的起始点
            read.BaseStream.Seek(0,SeekOrigin.Begin);
            //读取文件
            while (read.Peek() > -1)
            {
                //取文件的一行内容并换行
                output.Append(read.ReadLine()+"\n");
            }
            //关闭释放读数据流
            read.Close();
            //返回读到的日志文件内容
            return output.ToString();
        }
        static void writelogfile(string filenamewithpath, string Message)
        {
            //定义文件信息对象
            FileInfo finfo = new FileInfo(filenamewithpath);
            //判断文件是否存在及是否大于2K
            if (finfo.Exists && finfo.Length > 2048)
            {
                //删除该文件
                finfo.Delete();
            }
            //创建只写文件流
            using (FileStream fs = finfo.OpenWrite())
            {
                //根据上面的创建的文件流 创建写数据流
                StreamWriter sw = new StreamWriter(fs);
                //设置写数据流的起始位置为文件的末尾
                sw.BaseStream.Seek(0,SeekOrigin.End);
                //写入log Entry
                sw.Write("Log Entry: ");
                //写入当前系统时间并换行
                sw.Write("{0} {1} \r\n",DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
                //写入日志内容并换行
                sw.Write(Message + "\n");
                //写入--------------------------------------------并换行
                sw.Write("----------------------------------------\n");
                //清空缓冲区内容，并把缓冲区内容写入基础流
                sw.Flush();
                sw.Close();
            }
        }
    }
}
