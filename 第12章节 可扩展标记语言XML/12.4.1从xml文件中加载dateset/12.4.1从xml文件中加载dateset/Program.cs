using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace _12._4._1从xml文件中加载dateset
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();//创建一个类实例
            ds.ReadXml(@"F:\VS C#文件\第12章节 可扩展标记语言XML\12.4.1从xml文件中加载dateset\12.4.1从xml文件中加载dateset//Employee.xml");
            //显示数据的名称，数据表的名称对应的xml文件中的次级结点名
            Console.WriteLine("{0}表中的数据：",ds.Tables[0].TableName);
            DataTableReader dr = ds.CreateDataReader();//创建类实例

            while (dr.Read())//在datetablereader类实例中循环输出数据
            {
                Console.WriteLine("{0} {1}",dr[0],dr[1]);

            }
            Console.ReadLine();
        }
    }
}
