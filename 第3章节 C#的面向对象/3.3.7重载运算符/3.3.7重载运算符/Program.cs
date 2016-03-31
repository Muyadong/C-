using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3._3._7重载运算符
{
    public class Complex
    {
        public int real;//实部
        public int imaginary;//虚部
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="args"></param>
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 
        public static Complex operator + (Complex c1, Complex c2)
        {
            Complex result = new Complex(c1.real + c2.real,c1.imaginary + c2.imaginary);
            return result;
        }
        static void Main(string[] args)
        {
            Complex c1 = new Complex(1,2);
            Complex c2 = new Complex(2,3);
            Complex c3 = c1 + c2;//3+5i
            
        }
    }
}
