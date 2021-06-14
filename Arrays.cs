using System;

namespace Arrays
{
    class Numbers
    {
       static void Main(string[] args)
        {
            var name = new string[3] { "yash","bash","dash"};
            Console.WriteLine(name[0]);
            Console.WriteLine(name[1]);
            Console.WriteLine(name[2]);
            var fullname = String.Format("My name is {0} {1} {2}", name[0],name[1],name[2]);
        }        
    }
}
