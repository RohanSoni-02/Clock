using System;

namespace ClockTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock time = new Clock();
            while (true)
            {
                time.ClockTick();
                Console.WriteLine(time.PrintTime);
            }
            
        }
    }
}

