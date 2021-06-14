using System;

namespace Arrays
{
    class Numbers
    {
       static void Main(string[] args)
        {
            var name = new string[3] { "yash","bash","gash"};
            var fullname = String.Format("My name is {0} {1} {2}", name[0],name[1],name[2]);
            Console.WriteLine(fullname);
            var text = 
 @"hi john
jelo
good is see
c:\file\folder
";
            Console.WriteLine(text);
        }        
    }
}
