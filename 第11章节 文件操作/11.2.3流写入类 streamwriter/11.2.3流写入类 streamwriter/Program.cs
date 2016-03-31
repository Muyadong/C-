using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._2._3流写入类_streamwriter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //保留文件现有数据，以追加写入的方式打开文件
                StreamWriter sw = new StreamWriter(@"F:\VS C#文件\text.txt", true);
                //向文件写入新字符串，并关闭streamwriter
                sw.WriteLine("Another file operation methhod!");
                sw.Close();
            }
            catch(IOException ex)
            {
                Console.WriteLine("出现错误！！");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("成功写入！！");
        }
    }
}
