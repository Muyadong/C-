using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._9._1数据类型与比较//比较结构和类  分别调用的  区别！！！
{
    class Program
    {
        static void Main(string[] args)
        {
            //结构是值类型的数据类型
            strcEmployee strcemp1 = new strcEmployee();
            strcemp1.strFirstName = "zhang san";
            strcemp1.strLastName = "li si";
            strcEmployee strcemp2 = strcemp1;
            strcemp2.strFirstName = "wang er";
            strcemp2.strLastName = "ma zi";

            //类是引用类型的数据类型
            clsEmployee clsemp1 = new clsEmployee();
            clsemp1.clsFirstName = "zhang san";
            clsemp1.clsLastName = "li si";
            clsEmployee clsemp2 = clsemp1;
            clsemp2.clsFirstName = "wang er";
            clsemp2.clsLastName = "ma zi";

            //显示赋值后原变量的数值变化
            Console.WriteLine(strcemp1.strFirstName + " " + strcemp1.strLastName);
            Console.WriteLine(clsemp1.clsFirstName + " " + clsemp1.clsLastName);
            Console.ReadLine();
        }
        struct strcEmployee//结构的定义
        {
            public string strFirstName;
            public string strLastName;
 
        }
        class clsEmployee//类的定义
        {
            public string clsFirstName;
            public string clsLastName;
 
        }
    }
}
