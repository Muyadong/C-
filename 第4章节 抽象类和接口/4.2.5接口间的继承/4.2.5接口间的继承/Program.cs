using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._2._5接口间的继承
{
    interface IWriteable
    { 
       //定义IWriteable接口的成员方法
        void Write(string s);
    }
    interface IReadable
    {
        //定义IReadable接口的成员方法
        string ReadLine();
    }
    //定义继承IWriteable接口和IReadable接口的IFile接口
    interface IFile : IWriteable, IReadable
    {
        void Open(string filename);
        void Close();
    }
    public class MyFile : IFile
    {
        private string filename;
        public void Open(string filename)
        {
            this.filename = filename;
            Console.WriteLine("打开{0}文件！",filename);
        }
        public string ReadLine()
        {
            return "读出MyFile中的一行！";
        }
        public void Write(string s)
        {
            Console.WriteLine("向{0}文件中写入{1}",filename,s);
        }
        public void Close()
        {
            Console.WriteLine("关闭文件{0}！",filename);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyFile afile = new MyFile();
            afile.Open("zhangsansan");
            afile.Write("lisisi");
            Console.WriteLine(afile.ReadLine());
            afile.Close();
        }
    }
}
