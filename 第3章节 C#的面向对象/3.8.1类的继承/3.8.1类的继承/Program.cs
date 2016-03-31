using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._8._1类的继承
{
    class Person//表示 人 的类
    {
        private string firstname;
        public string FirstName//表示名字的前半部分属性
        {
            get { return firstname; }
            set { firstname = value; }
        }
        private string lastname;
        public string LastName//表示名字的后半部分属性
        {
            get { return lastname; }
            set { lastname = value; }
        }
        private int age;
        public int Age//表示年龄的属性
        {
            get { return age; }
            set { age = value; }
        }
        //构造函数，使用参数给类的字段赋值
        public Person(string strfirstname, string strlastname, int iage)
        {
            firstname = strfirstname;
            lastname = strlastname;
            age = iage;
        }
        public void AddAge(int Addition)//添加年龄的方法！
        {
            age += Addition;
        }
    }
    class Employee : Person//表示员工的类，从person类继承
    {
        private string department;
        public string Department//表示部门的属性
        {
            get { return department; }
            set { department = value; }
        }
        //构造函数，使用参数给类的字段赋值
        public Employee(string strfirstname, string strlastname, int iage, string strdepartment)
            : base(strfirstname, strlastname, iage)
        {
            department = strdepartment;
        }
        public void changeDepartment(string newdepartment)//修改部门的方法
        {
            department = newdepartment;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //创建员工类的实例
            Employee emp = new Employee("hello","world",21,"engineer");
            Console.WriteLine("修改前数据");
            Console.WriteLine("姓名：{0}",emp.FirstName +" "+emp.LastName);
            Console.WriteLine("年龄：{0}", emp.Age);
            Console.WriteLine("部门：{0}",emp.Department);
            emp.AddAge(1);//调用员工类的基类的方法；；；
            emp.changeDepartment("sale");//调用员工类的方法
            Console.WriteLine("修改后的数据");
            Console.WriteLine("姓名：{0}",emp.FirstName+" "+emp.LastName);
            Console.WriteLine("年龄：{0}",emp.Age);
            Console.WriteLine("部门：{0}",emp.Department);
            Console.ReadLine();
        }
    }
}
