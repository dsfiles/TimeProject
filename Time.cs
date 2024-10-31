using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeProject
{
    internal class Time
    {
        public int Hour, Minute;
        public double Second;
        public Time() { 
            Hour = 0; 
            Minute = 0; 
            Second = 0.0;
        }
        public Time(int hour, int minute) {
            this.Hour = hour;
            this.Minute = minute;
            this.Second = 0.0;
        }
        public Time(int hour, int minute, double second) { 
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }
        
        public void DisplayTime() {
            Console.WriteLine($"{this.Hour}:{this.Minute}:{this.Second}");
        }
        public void DisplayTime2(Time t) {
            Console.WriteLine($"{t.Hour}:{t.Minute}:{t.Second}");
        }
        public static void DisplayTime3(Time t)
        {
            Console.WriteLine($"{t.Hour}:{t.Minute}:{t.Second}");
        }


    }
}
