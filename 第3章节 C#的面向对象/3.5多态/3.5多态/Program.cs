using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//多态主要是通过在派生类中对基类中的成员进行替换或重定义完成！！！
namespace _3._5多态
{
    class Program
    {
        /*
        //基类
        class ClassF
        {
            public virtual void Out()
            {
                Console.WriteLine("调用了基类中的方法！");
            }
        }
        //派生类
        class ClassS1 : ClassF
        {
            public override void Out()
            {
                Console.WriteLine("调用了派生类1中的方法！！");
            }
        }
        //派生类2
        class ClassS2 : ClassF
        {
            public override void Out()
            {
                Console.WriteLine("调用了派生类2中的方法！！！");
            }
        }
        //输出结果

        static void Main(string[] args)
        {
            ClassF[] cf = new ClassF[3];
            cf[0] = new ClassF();
            cf[1] = new ClassS1();
            cf[2] = new ClassS2();
            foreach (ClassF c in cf)//foreach语法格式：foreach(数据类型 标识符 in 表达式)  {循环体}；
            {                       //foreach语句用于循环访问集合以获取所需信息，但不应用于更改集合内容，避免产生不可预知的副作用
                c.Out();
 
            }
            Console.ReadLine();
        }
         */
        //如果在派生类中隐藏基类中的非虚成员，可以使用new关键字！！！！
       // /*
        class ClassF
        {
            public void Out()
            {
                Console.WriteLine("调用了基类中的方法！");
            }
        }
        class ClassS1 : ClassF
        {
            public new void Out()
            {
                Console.WriteLine("调用了派生类1中的方法！！");
            }
        }
        class Test
        {
            static void Main(string[] args)
            {
                ClassS1 cs = new ClassS1();
                Console.WriteLine(cs.Out().ToString());//调用派生类中的方法
                Console.WriteLine(((ClassF)cs).Out().ToString());//调用基类中的方法
                Console.ReadLine();
            }
        }//*/
    }
}
