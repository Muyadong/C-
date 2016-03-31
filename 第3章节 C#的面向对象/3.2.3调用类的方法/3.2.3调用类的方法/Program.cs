using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2._3调用类的方法//解释说明    值传递   和   引用传递  的不同！！！
{
    class Program
    {
        /*
        //首先定义一个抽象类compute，它只能被继承！！！
        public abstract class Compute
        {
            public virtual int Method(int x, int y)//含有一个虚拟方法method（），该方法只能在他的包含类的派生类中被重写后才能使用！！
            {
                return(x+y);//返回值
            }
        }
        //然后定义compute的派生类use，并且use类中重写method 的方法，最后通过实例化use类！
        public class Use : Compute
        {
            public override int Method(int x, int y)//重写继承的方法或抽象的方法
            {
                return base.Method(x, y);
            }
        }
        static void Main(string[] args)
        {
            Use use = new Use();
            Console.WriteLine(use.Method(7,3));
            Console.ReadKey();
        }
         */
        public class Use
        {
            public int Method(int x)
            {
                x = 3 * x;
                return x;
            }
            public int Method2(ref int x)
            {
                x = 3 * x;
                return x;
            }
            static void Main(string[] args)
            {
                Use use= new Use();
                int x = 2;
                Console.WriteLine("输出的结果是：" + use.Method(x));//输出值传递的结果
                Console.WriteLine("输出结果是："+use.Method2(ref x));//输出引用传递的结果
                Console.WriteLine("输出的结果是："+use.Method(x));//输出值传递的结果
                Console.ReadKey();
            }
        }
    }
}
