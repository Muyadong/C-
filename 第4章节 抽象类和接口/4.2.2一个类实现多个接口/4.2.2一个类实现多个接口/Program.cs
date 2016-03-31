using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._2._2一个类实现多个接口
{
    interface ILoggable
    {
        //ILpggable接口中的Log()方法
       // void Log(string filename);
        void Write(string filename);//实现多接口同名方法！！！！！！！！！
    }
    interface IFile
    {
        //IFile接口的成员方法
        string ReadLine();
        void Write(string s);
    }
    public class MyFile : ILoggable, IFile
    {
        //私有成员变量
        private string filename;
        //MyFile类的构造函数
        public MyFile(string filename)
        {
            this.filename = filename;
        }
        //实现ILoggable接口的Log（）方法
       // public void Log(string filename)
        void ILoggable.Write(string filename)//不需要再用public来修饰
        {
            Console.WriteLine("在'{0}'文件中记录活动信息！",filename);
        }
        //实现IFile接口的ReadLine（）方法
        public string ReadLine()
        {
            return "读出MyFile中的一行！";
        }
        //实现IFile接口的Write（）方法
        public void Write(string s)
        {
            Console.WriteLine("向'{0}'文件中写入：'{1}'",filename,s);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {//创建MyFile类的对象
            MyFile afile = new MyFile("MyFile.txt");
            //调用afile对象的成员方法
           // afile.Log("C:\\csharp.txt");
            afile.Write("HelloWorld!");

            ILoggable logger = afile;
            logger.Write("C:\\csharp.txt");

            Console.WriteLine(afile.ReadLine());
        }
    }
}
