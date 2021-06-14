using System;

namespace types
{
    class reftype
    {
        static void Main()
        {
            var a = 1;
            var b = a + 1;
            Console.WriteLine(String.Format("hello all {0} {1}", a, b));
            var a1 = new int[3] { 3, 4, 5 };
            var b1 = a1;
            b1[0] = 1;
            Console.WriteLine(String.Format("hello all {0} {1}",a1[0],b1[0]));
        }
    }
}
