using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _8._2._2时钟事件
{
    public class ClockTimerArgs : EventArgs
    {
        private int tickCount;
        public ClockTimerArgs(int tickCount)//定义类的构造函数
        {
            this.tickCount = tickCount;
        }
        public int TickCount//定义属性！！
        {
            get
            {
                return tickCount;
            }
        }

    }
    public delegate void TimerEvent(object sender,ClockTimerArgs e);
    class ClockTimer
    {
        //定义Timer事件
        public event TimerEvent Timer;
        public void Start()
        {
            for (int i = 0; i < 5; i++)
            {
                Timer(this,new ClockTimerArgs(i+1));
                Thread.Sleep(1000);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClockTimer clocktimer = new ClockTimer();
            //向Timer中添加方法
            clocktimer.Timer += new TimerEvent(OnClockTick);
            //clocktimer.Timer += new TimerEvent(OnClockTick2);//多重事件处理！！！
            clocktimer.Start();
        }
        public static void OnClockTick(object sender, ClockTimerArgs e)
        {
            Console.WriteLine("收到yige时钟事件！！！这是第{0}个计时事件！！！",e.TickCount);
        }
        //public static void OnClockTick2(object sender, EventArgs e)
        //{
        //    Console.WriteLine("收到时钟事件222。。打杂的");
        //}
    }
}
