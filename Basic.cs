using System;

namespace Operations 
{
    class Program
    {
        static void Main()
        {
            var a = 3;
            var b = 2;
            var c = ((float)a / (float)b);
            Console.WriteLine(c>b && c<a);
        }
    }
}
