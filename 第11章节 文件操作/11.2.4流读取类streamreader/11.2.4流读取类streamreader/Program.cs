using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._2._4流读取类streamreader
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //以绝对路径方式构造streamreader对象
                StreamReader sr = new StreamReader(@"F:\VS C#文件\text.txt");

                //用readtoend 方法将文件夹中的数据全部读入字符串date中 ，并关闭streamreader
                string date = sr.ReadToEnd();
                Console.WriteLine(date);
                sr.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("there is an io exception!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
