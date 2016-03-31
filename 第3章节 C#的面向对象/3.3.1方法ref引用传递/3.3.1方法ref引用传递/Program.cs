using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3._1方法ref引用传递
{
    public class Student
    {
        public string strName;//姓名
        public int nAge;//年龄

        //构造函数
        public Student(string _strName, int _nAge)
        {
            this.strName =_strName;
            this.nAge =_nAge;
        }
        /// <summary>
        /// 长大 _nSpan岁
        /// </summary>
        /// <param name="args"></param>。
      /*  public void Grow(int _nSpan,ref int _nOutCurrentAge)//使用ref关键字进行引用传递
        {
            this.nAge += _nSpan;
            _nOutCurrentAge = this.nAge;//
        }*/
        public void Grow(int _nSpan, out int _nOutCurrentAge)//使用out关键字传出参数值
        {
            this.nAge += _nSpan;
            _nOutCurrentAge = this.nAge;//
        }
        static void Main(string[] args)
        {
            Student s=new Student("张三",20);
           // int nCurrentAge = 0;//
           // s.Grow(3,ref nCurrentAge);//用ref。。。在调用Grow方法之前，需要定义一个变量并进行初始化，否则会出错！
            int nCurrentAge;
            s.Grow(3, out nCurrentAge);//用out。。在调用时，便可以不用初始化变量参数。
            Console.WriteLine(s.strName);
            Console.WriteLine(s.nAge);//输出23
        }
    }
}






