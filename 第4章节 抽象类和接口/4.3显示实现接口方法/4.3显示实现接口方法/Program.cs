using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._3显示实现接口方法
{
    interface intfA//接口A
    {
        void MyMethod();
    }
    interface intfB//接口B
    {
        void MyMethod();//与接口A的方法同名
    }
    class clsA : intfA, intfB
    {
        public void MyMethod()//隐式实现方法intfA和intfB接口
        {
            Console.WriteLine("两个接口共用一个实现方法的实例。");
        }
    }
    class clsB : intfA, intfB
    {
       // #region intfA
        void intfA.MyMethod()//显示实现intfA接口
        {
            Console.WriteLine("显示实现intfA的MyMethod的方法");
        }
       // #endregion
        void intfB.MyMethod()//显示实现intfB接口
        {
            Console.WriteLine("显示实现intfB的MyMethod的方法");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsA clsa = new clsA();//创建clsA的实例
            intfA intfa = (intfA)clsa;
            intfa.MyMethod();
            intfB intfb = (intfB)clsa;
            intfb.MyMethod();

            clsB clsb = new clsB();//创建clsB的实例
            intfa = (intfA)clsb;
            intfa.MyMethod();
            intfb = (intfB)clsb;
            intfb.MyMethod();
            Console.ReadLine();
        }
    }
}
