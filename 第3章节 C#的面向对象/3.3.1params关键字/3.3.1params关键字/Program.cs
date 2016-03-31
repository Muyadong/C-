using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _3._3._1params关键字
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        public string strName;
        public int nAge;
        public Student(string _strName, int _nAge)
        {
            this.strName = _strName;
            this.nAge = _nAge;
        }
        public System.Collections.ArrayList strArrHobby =new ArrayList();//爱好
        /// <summary>
        /// 为爱好赋值
        /// </summary>
        /// <param name="args"></param>
        public void SetHobby(params string[] _strArrHobby)
        {
            for (int i = 0; i < _strArrHobby.Length; i++)
            {
                this.strArrHobby.Add(_strArrHobby[i]);
                //Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Student s = new Student("张三",20);
            s.SetHobby("游泳","篮球","足球");//作用  如何实现？
            Console.WriteLine(s.nAge);
        }
    }
}
