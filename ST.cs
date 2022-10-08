using System;
using System.Diagnostics;

namespace StopWatch
{
    internal class ST
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Press Any Key To Start Stopwatch");
            Console.ReadKey();
            stopwatch.Start();

            Console.WriteLine("Press Any Key To Stop Stopwatch");
            Console.ReadKey();
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            string elapseTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            Console.WriteLine("Elpased Time in (hour:minutes:seconds:Milliseconds) format is : " + elapseTime);
        }
    }
}
