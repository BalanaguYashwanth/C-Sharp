using System;

namespace Operation
{
    public class Sub
    {
        public int a;
        public int b;
        public int c;

        public int subtraction()
        {
            c = a - b;
            Console.WriteLine(c);
            return 0;
        }
    }
    class Programs
    {
        static void Main(string[] args)
        {
            var access = new Sub();
            access.a = 10;
            access.b = 5;
            access.subtraction();
        }
    }
}
