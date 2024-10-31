namespace TimeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Time t1 = new Time(10, 47, 56);
            Time t2 = new Time();

            t1.DisplayTime();
            t1.DisplayTime2(t1);
            t2.DisplayTime2(t1);
            TimeProject.Time.DisplayTime3(t1);
        }
    }
}
