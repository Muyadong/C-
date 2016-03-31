using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace 手写
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CreateXMLfile();
        }
        public void CreateXMLfile()
        {
            //
            XmlDocument xd = new XmlDocument();
            XmlNode node = xd.CreateXmlDeclaration("1.0","utf-8","yes");
            xd.AppendChild(node);
            //创建根节点
            XmlNode root = xd.CreateElement("users");
            xd.AppendChild(root);

            XmlNode mode1 = xd.CreateNode(XmlNodeType.Element,"user",null);
            CreateNode(xd,mode1,"name","zhangan");
            CreateNode(xd,mode1,"sex","male");
            CreateNode(xd,mode1,"age","1234");
            root.AppendChild(mode1);

            XmlNode node2 = xd.CreateNode(XmlNodeType.Element,"user",null);
            CreateNode(xd,node2,"name","lisi");
            CreateNode(xd,node2,"sex","remale");
            CreateNode(xd,node2,"age","4567");
            root.AppendChild(node2);

            try
            {
                xd.Save("F://VS C#文件//第12章节 可扩展标记语言XML//手写//sx.xml");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// 创建节点
        /// </summary>
        /// <param name="xd"></param>xml文档
        /// <param name="parentnode"></param>父节点
        /// <param name="name"></param>节点名
        /// <param name="value"></param>节点值
        public void CreateNode(XmlDocument xd,XmlNode parentnode,string name,string value)
        {
            XmlNode node = xd.CreateNode(XmlNodeType.Element,name,null);
            node.InnerText = value;
            parentnode.AppendChild(node);
        }
        
    }
}
