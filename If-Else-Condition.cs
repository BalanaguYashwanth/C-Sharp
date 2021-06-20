using System;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 1;
            if (hour > 0 && hour < 10)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour > 10 && hour < 20)
            {
                Console.WriteLine("It's Noon");
            }
            else
            {
                Console.WriteLine("It's Night");
            }
        }
    }
}
