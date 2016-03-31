using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._3._2使用代理
{
    class Program
    {
        //声明返回类型为person类的实例的代理
        delegate Person CreatePersonHandle(string FirstName,string LastName,int Age);
        //声明参数为Employee 类实例的代理
        delegate void ShowEmployeeHandle(Employee emp);

        static void Main(string[] args)
        {
            //代理的协变，代理的返回类型比方法返回类型的抽象级别高，进行隐式转换
            CreatePersonHandle eh = CreateEmployee;
            Employee employee = ((Employee)eh("pony","smith",41));

            //代理的逆变，代理的抽象类型比方法参数的抽象类型级别低，进行隐式转换
            ShowEmployeeHandle ph = ShowPerson;
            ph(employee);
            Console.ReadLine();
        }
        //创建员工类实例的方法
        static Employee CreateEmployee(string FirstName ,string LastName,int Age)
        {
            return new Employee(FirstName, LastName, Age, "");
        }
        //显示person类属性的方法   其中参数指定为person类的实例
        static void ShowPerson(Person persontoshow)
        {
            Console.WriteLine("人员数据 姓名：{0} {1} 年龄：{2}",persontoshow.FirstName,persontoshow.LastName,persontoshow.Age);
        }
    }
    class Person//表示人 的类
    {
        private string firstname;
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public Person(string strFirstName, string strLastName, int iAge)
        {
            firstname = strFirstName;
            lastname = strLastName;
            age = iAge;
        }
    }
    class Employee : Person//表示员工的类
    {
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public Employee(string strFirstName, string strLastName, int iAge, string strDeparment):base(strFirstName,strLastName,iAge)
        {
            department = strDeparment;
        }
    }
}
