using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3._2构造函数
{
    public class Student
    {
        private string strName;
        /// <summary>
        /// 构造函数，为学生起名
        /// </summary>
        /// <param name="args"></param>
        public Student(string _strName)//构造函数
        {
            this.strName = _strName;
        }
        ~Student()//析构函数
        {
            Console.WriteLine("call destruct method.");
        }
        static void Main(string[] args)
        {
            Student s = new Student("张三");
            Console.WriteLine(s.strName);
        }
    }
}
