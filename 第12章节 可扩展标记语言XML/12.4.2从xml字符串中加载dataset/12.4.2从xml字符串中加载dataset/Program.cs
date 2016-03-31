using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
namespace _12._4._2从xml字符串中加载dataset
{
    class Program
    {
        static void Main(string[] args)
        {
            //表示xml数据的字符串
            string strXML = @"<?xml version='1.0'?>
<Table>
<Employees>
<FirstName>zhangsan</FirstName>
<LastName>lisi</LastName>
</Employees>
<Employees>
<FirstName>pida</FirstName>
<LastName>pisa</LastName>
</Employees>
<Employees>
<FirstName>sabi</FirstName>
<LastName>doubi</LastName>
</Employees>
</Table>";

            DataSet ds = new DataSet();//创建dataset类的实例
            //加载xml数据到dataset类实例中，其中将字符串传入到一个textreader的派生类中
            ds.ReadXml(new StringReader(strXML));

            //显示dataset类实例中的数据表名称，即xml字符串中次级节点的名称
            Console.WriteLine("{0}表中的数据：",ds.Tables[0].TableName);

            //创建datatablereader类的实例，用于显示dataset类实例中的数据
            DataTableReader dr = ds.CreateDataReader();

            while (dr.Read())//在datatablereader类实例中循环显示数据
            {
                Console.WriteLine("{0} {1}",dr[0],dr[1]);

            }
            Console.ReadLine();

        }
    }
}
