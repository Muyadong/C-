using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6._6._1正则表达式获取指定字符
{
    class Program
    {
        static void Main(string[] args)
        {
            //定义包含数据信息的字符串
            string strInfo = "[商品A]2007年10月10日的价格为23.10";
            string GoodsName = "";
            DateTime SaleDate = DateTime.Now;
            float SalePrice = 0f;
            string regName = @"\[(?<Name>\S*)\]";//获取商品名称的正则表达式字符串
            Match mName = new Regex(regName,RegexOptions.Compiled).Match(strInfo);
            if (mName.Length > 0)
            {
                GoodsName = mName.Result("${Name}");
            }
            //获取日期的正则表达式字符串
            string regDate = @"(?<Year>\d+)年(?<Month>\d+)月(?<Day>\d+)日";
            Match mDate = new Regex(regDate,RegexOptions.Compiled).Match(strInfo);
            if (mDate.Length > 0)
            {
                //将匹配结果赋值给日期型的变量
                SaleDate = DateTime.Parse(mDate.Result("${Year}-${Month}-${Day}"));
            }
            string regPrice = @"(?<Price>\d+\.\d+)";//获取商品价格的正则表达式字符串
            Match mPrice = new Regex(regPrice,RegexOptions.Compiled).Match(strInfo);
            if (mDate.Length > 0)
            {
                //将匹配结果赋值给浮点型的变量
                SalePrice = float.Parse(mPrice.Result("${Price}"));
            }
            Console.WriteLine("{0}\t{1}\t{2}",GoodsName,SalePrice,SaleDate);
            Console.ReadLine();
            
        }
    }
}
