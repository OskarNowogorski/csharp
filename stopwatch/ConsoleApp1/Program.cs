using System;
using StopWatch;

namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            var StopWatch = new StopWatch();
            while (true)
            {
                Console.WriteLine("Enter a command start|stop|reset):");
                string command = Console.ReadLine();

                if (command == "start")
                {
                    StopWatch.Start();
                } else if (command == "stop")
                {
                    StopWatch.Stop();                }
                  else if (command == "reset")

                {
                    StopWatch.Reset();
                }
                else
                {
                    break;
                }
            }
        }
    }
}


                
