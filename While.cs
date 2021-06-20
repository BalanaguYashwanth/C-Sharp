using System;
using ControlFlow;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 0;
            while(true)
            {
                Console.WriteLine("Type your name here....");
                var input = Console.ReadLine();

                if(!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("echo " + input);
                    continue;
                }
                
                break;
            }
        }
    }
}
