using System;
using System.Diagnostics;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Press Enter to start the Stopwatch");
            Console.ReadLine();

            stopwatch.Start();

            Console.WriteLine("Stopwatch is running. Please ENTER to stop.");
            Console.ReadLine();

            stopwatch.Stop();

            TimeSpan elapsed = stopwatch.Elapsed;
            Console.WriteLine("Elapsed time : " + elapsed);

            Console.WriteLine("Press ENTER to Exit.");
            Console.ReadLine();
        }
    }
}
