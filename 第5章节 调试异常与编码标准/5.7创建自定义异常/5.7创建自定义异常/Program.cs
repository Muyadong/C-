using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._7创建自定义异常
{
    class MyException : Exception
    {
        public MyException()//默认构造函数
        {
            AddData();//在构造函数实例的同时增加异常类数据
        }
        public MyException(string message):base(message)//继承的构造函数，message表示异常的提示信息
        {
            AddData();
        }
        //继承的构造函数，message表示异常的提示信息，inner表示包含的其他异常类实例
        public MyException(string message, Exception inner)
            : base(message, inner)
        {
            AddData();
        }
        private void AddData()//为异常类实例提供数据的方法
        {
            this.Data.Add("名称","自定义的异常");//添加 键值为“名称”的字符串！！
            this.Data.Add("描述","用户根据业务规则定义的异常");
            this.Data.Add("关系","继成与Exception类");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyException myerr = new MyException();//创建一个异常类的实例
            Console.WriteLine("自定义异常的名称：{0}",myerr.Data["名称"].ToString());
            Console.WriteLine("自定义异常的描述：{0}",myerr.Data["描述"].ToString());
            Console.WriteLine("自定义异常的关系：{0}",myerr.Data["关系"].ToString());
            Console.ReadLine();
            throw myerr;//在程序中直接抛出 异常，至此程序不能继续执行。。。。
        }
    }
}
