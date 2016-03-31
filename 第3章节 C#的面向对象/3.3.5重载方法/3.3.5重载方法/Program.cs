using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3._5重载方法
{
    public class Student
    {
        public string strName;
        public int nAge;
        /// <summary>
        /// 成长一岁
        /// </summary>
        /// <param name="args"></param>
        public void Grow()
        {
            this.nAge++;
        }
        /// <summary>
        /// 成长_nAgeSpan
        /// </summary>
        /// <param name="args"></param>
        public void Grow(int _nAgeSpan)
        {
            this.nAge += _nAgeSpan;
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.nAge = 20;

            s.Grow();
            Console.WriteLine(s.nAge);//输出21
            s.Grow(2);
            Console.WriteLine(s.nAge);//输出23

            Console.WriteLine();
        }
    }
    public class CollegeStudent : Student
    {
        public string strInstitute;//所在系
        //获得大学生 所有信息
        public void GetAllInfo()
        {
            base.Grow();
            Console.WriteLine("Institute: "+this.strInstitute);
        }
    }
}
