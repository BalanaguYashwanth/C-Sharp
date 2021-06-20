using System;
using ControlFlow;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "balanaguyas";
           for(var i=1;i<=10;i++)
           {
                Console.WriteLine(name[i]);
           }

           foreach(var nm in name)
           {
                Console.WriteLine(nm);
           }
        }
    }
}
