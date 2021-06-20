using System;
using ControlFlow;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            var random =new Random();

            for (i= 0;i<10;i++)
            Console.WriteLine(random.Next());

        }
    }
}
