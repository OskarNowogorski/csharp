using System;

namespace StopWatch
{
    public class Stopwatch
    {
        public bool isRunning;
        public TimeSpan Elapsed { get; set; }
        public DateTime StartTime { get; set; }
        public void Start()
        {
            if (isRunning == true)
            {
                throw new NotSupportedException("StopwatchAlreadyStartedException");
            } else           
            {
                StartTime = System.DateTime.Now - Elapsed;
                isRunning = true;
            }
        }
        public void Stop()
        {
            if (isRunning == false)
            {
                Console.WriteLine("The stopwatch is not running.");
            } else           
            {
                Elapsed = System.DateTime.Now - StartTime;
                isRunning = false;
                Console.WriteLine($"Time elapsed: {Elapsed}");
            }
        }   
        
        public void Reset()
        {
            Elapsed = TimeSpan.Zero;
            StartTime = System.DateTime.Now;           
        }
    }
}
        
