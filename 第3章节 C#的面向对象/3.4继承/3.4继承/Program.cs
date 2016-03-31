using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//有关派生类在基类中的访问权限问题？
//（1）大多数而并非所有类都可以作为基类被继承，如带有sealed修饰的密封类。
//（2）基类中只有两种成员能被派生类访问，包括public和protected类型的成员，  其中protected类型是专为派生类设计的，该类型的成员
//只能在派生类中 进行访问！
//（3）在派生类中可以修改以下成员，包括虚拟成员（virtual）和抽象函数（abstract）。其中对虚拟函数的修改实在派生类中重写该成员的
//执行代码；而对于抽象函数而言，他的基类中没有执行代码，需要在派生类中进行添加。
namespace _3._4继承
{
    class Progrem
    {
        class classF
        {
            //公有字段
            public string name = "张三";
            public string age;
            //公有属性
            public string Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }
            //虚拟方法
            public virtual double Income(double time)
            {
                double income = time * 100.0 * 2000.0;
                return income;
            }
        }
        class classS : classF//类classS继承类classF
        {
            //重写虚拟方法
            public override double Income(double time)
            {
                double income = time * 100.0 * 2000.0;
                return income;
            }
        }
        static void Main(string[] args)
        {
            classS cs = new classS();
            Console.WriteLine("姓名：");
            //继承公有字段
            Console.WriteLine(cs.name);
            Console.WriteLine("工时：");
            //继承公有属性
            Console.WriteLine(cs.Age);
            Console.WriteLine("工资：");
            //继承虚拟方法
            Console.WriteLine(cs.Income(Convert.ToDouble(cs.Age)).ToString());
            Console.ReadLine();
        }
    }
}
