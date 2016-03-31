using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _11._2._6BinaryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"F:\VS C#文件\text.txt",FileMode.Open,FileAccess.Read);
            //通过文件流创建相应的binaryreader
            BinaryReader br = new BinaryReader(fs);
            //从文件中读取数据
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(br.ReadInt32());
            }
            br.Close();
            fs.Close();
        }
    }
}
