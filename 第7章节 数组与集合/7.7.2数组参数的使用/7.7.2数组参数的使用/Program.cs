using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._7._2数组参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NewChangeArray = new int[5] { 1, 2, 3, 4, 5 };
            NewChange(NewChangeArray);//调用重新创建数组并修改值得方法
            Console.WriteLine("调用NewChange方法后的数组："+ShowArray(NewChangeArray));

            int[] OnlyChangeArray = new int[5] {1,2,3,4,5};
            OnlyChange(OnlyChangeArray);//调用直接修改数组值得的方法
            Console.WriteLine("调用OnlyChangeArray方法后的数组："+ShowArray(OnlyChangeArray));

            //ref关键字生命的数组参数必须在方法外部明确赋值
            int[] RefArray = new int[] {6,7,8,9,10 };
            MethodWithRefArrayParam(ref RefArray);//使用ref关键字声明数组参数
            Console.WriteLine("调用MethodWithRefArrayParam方法后的数组："+ShowArray(RefArray));

            int[] OutArray = new int[] {20,21,22};
            MethodWithOutArrayParam(out OutArray);//使用out关键字声明数组参数
            Console.WriteLine("调用MethodWithOutArrayParam方法后的数组："+ShowArray(OutArray));

            Console.ReadLine();
        }
        static void NewChange(int[] arrayparam)
        { 
            //在方法中使用new关键字重新创建数组
            arrayparam = new int[] {1,2,3,4,5 };
            arrayparam[2] = 6;
        }
        static void OnlyChange(int[] arrayparam)
        { 
            arrayparam[2] = 6;
        }
        static void MethodWithRefArrayParam(ref int[] arrayparam)
        { 
            //即使在方法中使用new关键字重新创建数组，数组仍然指向原先的内存空间
            arrayparam = new int[] {32,33,34 };
            arrayparam.SetValue(11,2);
        }
        static void MethodWithOutArrayParam(out int[] arrayparam)
        { 
            //out关键字声明的数组参数必须在方法内部明确赋值
            arrayparam = new int[] {11,12,13,14,15};
        }
        static string  ShowArray(int[] ArrayWillShow)
        {
            string list = "";
            foreach (int ivalue in ArrayWillShow)
            {
                list = list + ivalue.ToString() +",";
            }
            list = list.Remove(list.Length-1);
            return list;
        }
    }
}
