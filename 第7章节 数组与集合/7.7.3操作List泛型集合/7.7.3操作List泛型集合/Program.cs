using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7._7._3操作List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strlist = new List<string>();//创建泛型List类实例
            strlist.Add("10");//向List类实例中添加数据
            strlist.Add("11");
            strlist.Add("12");
            strlist.Add("13");
            //使用匿名委托显示字符串List的值
            Action<string> show = delegate(string strToShow)
            {
                Console.WriteLine("当前元素值{0}：", strToShow);
            };
            strlist.ForEach(show);//显示每个元素的值
            strlist.Insert(2,"15");//在 指定位置插入元素
            Console.WriteLine("包含{0}个元素，可包含{1}个元素",strlist.Count,strlist.Capacity);//未压缩前的list容量
            strlist.TrimExcess();//压缩list
            Console.WriteLine("包含{0}个元素，可包含{1}个元素",strlist.Count,strlist.Capacity);//压缩之后的容量

            Console.WriteLine("是否包含\"15\"：{0}",strlist.Contains("15"));//检查list中是否包含指定数据
            Console.WriteLine("第二个数据：{0}",strlist[2]);//使用索引值访问指定元素
            strlist.Remove("15");//从list中删除指定元素
            //创建转换list的匿名委托
            Converter<string, int> converter = delegate(string strIn)
            {
                return int.Parse(strIn);
            };
            //使用匿名委托显示整型list的值
            Action<int> Print = delegate(int intToPrint)
            {
                Console.WriteLine("当前元素值：{0}", intToPrint);
            };
            //使用匿名委托将字符串list类实例专为整型list类实例
            List<int> ilist = strlist.ConvertAll<int>(converter);
            ilist.ForEach(Print);//显示每个元素的值

            Console.ReadLine();

        }
    }
}
///////////////////注释~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//两个Action类的匿名委托的作用：是作为ForEach的参数遍历集合，将元素的值输出到屏幕上
///////使用ForEach方法能够避免遍历时的  装箱~~~~~操作，提高遍历效率，并避免装箱操作所带来的不安全因素

//Converter类的匿名委托，用来将字符串数据类型元素的集合转换为整型数据类型元素的集合




