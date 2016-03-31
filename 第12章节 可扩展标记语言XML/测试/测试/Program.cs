using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace 测试
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.createEmptyXMLDocument();
        }
        private void createEmptyXMLDocument()
        {
            //创建一个XML文档
            XmlDocument xmlDocument = new XmlDocument();
            //添加XML声明
            XmlDeclaration xmldeclaration = xmlDocument.CreateXmlDeclaration("1.0","","yes");
            xmlDocument.PrependChild(xmldeclaration);
            //添加根元素
            XmlElement nodeElement = xmlDocument.CreateElement("TagEmployees" );
            xmlDocument.AppendChild(nodeElement);
            try
            {
                xmlDocument.Save("F://VS C#文件//第12章节 可扩展标记语言XML//测试//ttt.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    } 
}
