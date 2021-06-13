using System;

namespace Addition
{
    public class Add
    {
        public int a;
        public int b;
        
        public int Addition()
        {
            var c = a + b;
            Console.WriteLine(c);
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var operators = new Add();
            operators.a = 1;
            operators.b = 2;
            operators.Addition();
        }
    }
}
