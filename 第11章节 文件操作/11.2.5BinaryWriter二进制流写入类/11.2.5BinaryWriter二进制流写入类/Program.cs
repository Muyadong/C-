using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._2._5BinaryWriter二进制流写入类
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"F:\VS C#文件\text.txt",FileMode.Create);
            //通过文件流创建相应的binarywriter
            BinaryWriter bw = new BinaryWriter(fs);
            for (int i = 0; i < 11; i++)
            {
                //向文件中写入数据
                bw.Write((int)i);
            }
            bw.Close();
            fs.Close();
            Console.WriteLine("写入成功！！！");
        }
    }
}
