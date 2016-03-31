using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4._1定义抽象类
{
    public abstract class TaxCalculator
    {
        //定义TaxCalculator类的成员变量
        protected double itemPrice;//商品价格
        protected double tax;//应交税金
        //定义TaxCalculator类的抽象成员函数
        public abstract double CalculatorTax();
        //定义TaxCalculator类的Tax属性
        public double Tax
        {
            get
            {
                return tax;
            }
        }
        //定义TaxCalculator类的ItemPrice属性
        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
        }
    }
    //定义继承TaxCalculator类的SalesTaxCalculator类
    public class SalesTaxCalculator : TaxCalculator
    {
        //SalesTaxCalculator类的构造函数
        public SalesTaxCalculator(double itemPrice)
        {
            this.itemPrice = itemPrice;
        }
        //对CalculatorTax()抽象方法进行重写
        public override double CalculatorTax()
        {
            tax = 0.3 * itemPrice;
            return tax + itemPrice;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SalesTaxCalculator salesTaxCalc = new SalesTaxCalculator(250);
            //调用CalculatorTax抽象方法
            double newPrice = salesTaxCalc.CalculatorTax();
            Console.WriteLine("由于增加税收的原因，商品价格从{0}￥涨到{1}￥！",salesTaxCalc.ItemPrice,newPrice);
            Console.WriteLine("商品的税金是：{0}￥！",salesTaxCalc.Tax);
        }
    }
}
