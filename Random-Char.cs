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
                Console.Write((char)random.Next(97,122));
            Console.WriteLine();
        }
    }
}


namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            var name=new char[10];
            var random =new Random();
            for (i = 0; i < 10; i++)
                name[i]= (char)random.Next(97, 122);
                //Console.Write((char)random.Next(97,122));
            Console.WriteLine(new String(name));
        }
    }
}
