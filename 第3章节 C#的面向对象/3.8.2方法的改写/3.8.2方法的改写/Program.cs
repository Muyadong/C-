using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._8._2方法的改写
{
    class Person//表示人的类
    {
        public string FirstName;
        public string LastName;
        public int Age;
        //Person类的构造函数，由参数指定类实例的字段值
        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
        //获得字段值组成的字符串的方法，该方法为虚函数，可以在子类中重写
        public virtual string GetInfo()
        {
            return FirstName + " " + LastName + "," + Age.ToString();
        }
    }
    class Employee : Person
    {
        public string Department;
        //员工类的构造函数，继承于person类的构造函数
        public Employee(string firstname, string lastname, int age, string department)
            : base(firstname, lastname, age)
        {
            Department = department;
        }
        //改写
        public override string GetInfo()
        {
            return base.GetInfo() + "," + Department;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("小","小三",41,"Enhineer");
            Console.WriteLine("员工类实例数据："+ emp.GetInfo());
            Console.ReadLine();
        }
    }
}
