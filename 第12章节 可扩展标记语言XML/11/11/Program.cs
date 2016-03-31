using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace CreateXml
{
    class Program
    {
        static void Main(string[] args)
        {
            Program app = new Program();
            app.CreateXmlFile();
        }
        public void CreateXmlFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("User");
            xmlDoc.AppendChild(root);
            CreateNode(xmlDoc, root, "name", "xuwei");
            CreateNode(xmlDoc, root, "sex", "male");
            CreateNode(xmlDoc, root, "age", "25");
            try
            {
                xmlDoc.Save("F://VS C#文件//第12章节 可扩展标记语言XML//11//ppp.xml");//前面可以加@符号，就不需要区分//和\的问题！！！
            }
            catch (Exception e)
            {
                //显示错误信息  
                Console.WriteLine(e.Message);
            }
            //Console.ReadLine();  

        }

        /// <summary>    
        /// 创建节点    
        /// </summary>    
        /// <param name="xmldoc"></param>  xml文档  
        /// <param name="parentnode"></param>父节点    
        /// <param name="name"></param>  节点名  
        /// <param name="value"></param>  节点值  
        ///   
        public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        {
            XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
            node.InnerText = value;
            parentNode.AppendChild(node);
        }
    }
}  
