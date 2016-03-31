using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._6._1算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int chinese = 90; //语文成绩
            int mathScores = 100;//数学成绩
            int english = 70;//英语成绩
            int sportsScores = 100;//体育成绩
            int totalScore;//总成绩
            int diffen;//成绩差
            double average;//平均分

            Console.WriteLine("以下为小伟的各科成绩： ");
        //输出 语文成绩，数学，英语，体育各科的成绩，“\t”,"\n"，的作用后面进行解释。
            Console.WriteLine("语文：" + chinese + "\t" + "数学：" + mathScores + "\n" + "英语：" + english + "\t" + "体育：" + sportsScores);
       //计算各科的总成绩；
            totalScore = chinese + mathScores + english + sportsScores;
       //计算最高分和最高分只差
            diffen = sportsScores - english;
        //计算平均分；
            average = totalScore / 4;

            Console.WriteLine("小伟的总成绩是："+totalScore);//输出总成绩
            Console.WriteLine("最高分和最低分的差："+diffen);//输出分数差
            Console.WriteLine("平均分为："+average);//输出平均分
            Console.ReadLine();
        }
    }
}
