using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
namespace _12._4._3将对象层次结构映射到XML数据
{
    class Program
    {
        static void Main(string[] args)
        {
            //表示XML数据的字符串
            string strXML = @"<?xml version='1.0'?>
<!-- 表示操作记录的XML文档 -->
<!DOCTYPE 操作记录 [<!ENTITY 数据库 'Northwind'>]>
<操作记录>
<操作数据库>当前操作的数据库是：&数据库;</操作数据库>
<指令>CustOrderHist<参数 名称='@CustomerID'><![CDATA[<ALFKI>]]></参数></指令>
<条件>WHERE Total&#60;30</条件>
<最大字段字符>Original Frankfurter grune Sote</最大字段字符>
</操作记录>";

            XmlTextReader reader = null;//声明XML文本读取器
            try
            {
                //创建xmltextreader类的实例，使用stringreader类实例作为构造函数的参数
                reader = new XmlTextReader(new StringReader(strXML));
                while (reader.Read())
                {
                    switch (reader.NodeType)//读取节点的类型分支控制
                    {
                        case XmlNodeType.Element://元素
                            Console.WriteLine("<{0}>", reader.Name);
                            break;
                        case XmlNodeType.Text://节点的文本内容
                            Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.CDATA:
                            Console.WriteLine("<![CDATA[{0}]]>", reader.Value);
                            break;
                        case XmlNodeType.ProcessingInstruction://处理指令
                            Console.WriteLine("<?{0} {1}?>", reader.Name, reader.Value);
                            break;
                        case XmlNodeType.Comment://注释
                            Console.WriteLine("<!--{0}-->", reader.Value);
                            break;
                        case XmlNodeType.XmlDeclaration://xml声明
                            Console.WriteLine("<?xml version='1.0'?>");
                            break;
                        case XmlNodeType.Document://文档对象
                            break;
                        case XmlNodeType.DocumentType://文档类型声明
                            Console.WriteLine("<!DOCTYPE{0} [{1}]>", reader.Name, reader.Value);
                            break;
                        case XmlNodeType.EntityReference://实体引用
                            Console.WriteLine(reader.Name);
                            break;
                        case XmlNodeType.EndElement://元素结束标志
                            Console.WriteLine("</{0}>", reader.Name);
                            break;

                    }

                }
            }

            finally
            {
                if (reader != null)
                    reader.Close();
            }
            Console.ReadLine();
        }
    }
}
