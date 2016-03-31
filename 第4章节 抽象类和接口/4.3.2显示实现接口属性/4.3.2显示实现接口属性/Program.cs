using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._3._2显示实现接口属性
{
    //声明英制单位接口
    interface IEnglishDimentions
    {
        double Length();
        double Width();
    }
    //声明公制单位接口
    interface IMetricDimentions
    {
        double Length();
        double Width();
    }
    class Box : IEnglishDimentions, IMetricDimentions//继承两个接口的类Box
    {
        private double length;
        private double width;
        #region IEnglishDimentions 成员
        double IEnglishDimentions.Length()//显示实现IEnglishDimentions的length属性
        {
            return length * 2.54;
        }
        double IEnglishDimentions.Width()//显示实现IEnglishDimentions的width属性
        {
            return width * 2.54;
        }
        #endregion

        double IMetricDimentions.Length()//显示实现IMetricDimentions的length 属性
        {
            return length;
        }
        double IMetricDimentions.Width()//显示实现IMetricDimentions的width 属性
        {
            return width;
        }

        public Box(double dlength, double dwidth)//Box类的构造函数
        {
            length = dlength;
            width = dwidth;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box mybox = new Box(200,100);//声明类实例mybox
            //声明英制单位接口的实例
            IEnglishDimentions edimentions = (IEnglishDimentions)mybox;
            //声明公制单位接口的实例
            IMetricDimentions mdimentions = (IMetricDimentions)mybox;
            Console.WriteLine("英制单位尺寸（in）：{0}*{1}",edimentions.Length(),edimentions.Width());
            Console.WriteLine("公制单位尺寸（cm）：{0}*{1}",mdimentions.Length(),mdimentions.Width());
            Console.ReadLine();
        }
    }
}


