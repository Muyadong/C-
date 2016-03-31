using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _11._2._2文件流读写
{
    class Program
    {
        static void Main(string[] args)
        {
        //    byte[] bdw = new byte[100];
        //    char[] cdw = new char[100];
        //    try
        //    {
        //        //创建文件对象
        //        FileStream fs = new FileStream(@"F:\VS C#文件\text.txt", FileMode.OpenOrCreate);
        //        //将要写入的字符串转换成字符数组
        //        cdw = "my first file operation".ToCharArray();
        //        //通过utf—8编码方法将字符数组 转换成字节数组
        //        Encoder enc = Encoding.UTF8.GetEncoder();
        //        enc.GetBytes(cdw, 0, cdw.Length, bdw, 0, true);

        //        //设置流的当前位置 为文件开始位置
        //        fs.Seek(0, SeekOrigin.Begin);
        //        fs.Write(bdw, 0, bdw.Length);..........................................................

        //    }
        //    catch(IOException ex)
        //    {
        //        Console.WriteLine("there is an ioexception");
        //        Console.WriteLine(ex.Message);
        //        Console.ReadLine();
        //    }
        //    Console.WriteLine("write to file succeed!");
      
            byte[] bdr = new byte[100];
            char[] cdr = new char[100];
            try
            {
                //创建文件对象
                FileStream fs = new FileStream(@"F:\VS C#文件\text.txt", FileMode.Open);
               
                //设置流的当前位置 为文件开始位置
                fs.Seek(0, SeekOrigin.Begin);
                //将文件的内容读入字节数组中...........................................................
                fs.Read(bdr,0,100);

            }
            catch (IOException ex)
            {
                Console.WriteLine("there is an ioexception");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            //通过utf—8编码方法将字节数组 转换成字符数组
            Decoder dc = Encoding.UTF8.GetDecoder();
            dc.GetChars(bdr,0,bdr.Length,cdr,0);
            Console.WriteLine("read from file succed !");
            Console.WriteLine(cdr);

        }
    }
}
