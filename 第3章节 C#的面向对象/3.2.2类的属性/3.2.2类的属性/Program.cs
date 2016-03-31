using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._2._2类的属性
{
    class Program
    {
        private string name;
        public string Name
        {
            get//用于读
            {
                return name;
            }
            set//用于写
            {
                name = value;
            }
            ////以上get和set如有某一个缺少  表示只读或只写
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Name = "dog";
            Console.WriteLine("这是："+ program.Name);
            Console.ReadKey();
        }
    }
}
