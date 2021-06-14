using System;

namespace Enums
{
    public enum ShippingMethod
    {
        item=1,
        letter=3,
        mails=5,
    }

    class operations
    {
        static void Main()
        {
            var method = ShippingMethod.item;
            Console.WriteLine(method);
            Console.WriteLine(method.ToString());
            Console.WriteLine((int)method);
        }
    }
}
