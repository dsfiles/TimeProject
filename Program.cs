namespace TimeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time t1 = new Time(10, 16);
            // change second to 25
            //t1.Second = 25;
            t1.SetSecond(26);
            Console.WriteLine(t1.GetSecond());

            t1.DisplayTime();
            t1.DisplayTime2(t1);
            Time.DisplayTime3(t1);
            /*
                public static void DisplayTime3(Time t)
                {
                    Console.WriteLine($"{t.Hour}:{t.Minute}:{t.Second}");
                }
            
            public void DisplayTime2(Time t) {
                Console.WriteLine($"{t.Hour}:{t.Minute}:{t.Second}");
            }

            public void DisplayTime() {
                Console.WriteLine($"{this.Hour}:{this.Minute}:{this.Second}");
            }
             
             * 
            public Time(int hour, int minute) {
                this.Hour = hour;
                this.Minute = minute;
                this.Second = 0.0;
            }
             * 
             */
        }
    }
}
