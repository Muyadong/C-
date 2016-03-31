using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//实例构造函数：用于创建和初始化类的实例，可以带有参数和修饰符，能被调用  ！
//静态构造函数：用于对类的静态成员的初始化，不能带有参数和修饰符，不能被调用！
namespace _3._2._5类的构造函数
{
    /// <summary>
    /// 实例构造函数和静态构造函数的区别！！！！
    /// </summary>
    class Student
    {
        public static int x;
        public int y;
        public int z;
        public int m;
        public int n;
        //构造函数1
        public Student()
        {
            y = 2;
            z = 2;
        }
        //构造函数2
        public Student(int m,int n)
        {
            this.m = m;
            this.n = n;
      
        }
        //构造函数3
        static Student()
        {
            x = 5;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("x="+Student.x);
            Student std1 = new Student();
            Console.WriteLine("y={0},z={1}", std1.y, std1.z);
            Student std2 = new Student(3,3);
            Console.WriteLine("m={0},n={1}",std2.m,std2.n);
            Console.ReadKey();
        }
        //一下实例  继承类！！！
        public class dog : Student//C#只支持单继承！即一个类只能继承一个父类！！！
        {
            public void swim()
            {

            }
        }
    }
}
