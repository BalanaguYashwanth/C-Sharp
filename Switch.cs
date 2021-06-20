using System;
using ControlFlow;

namespace Operations
{
    public enum Season //keep another file this enum with namesapce
    {
        Winter,
        Summer,
        Antum,
        Spring
    }
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Summer;
            switch(season)
            {
                case Season.Antum:
                    Console.WriteLine("go to work");
                    break;
                case Season.Spring:
                    Console.WriteLine("spring is came");
                    break;
                default:
                    Console.WriteLine("No to work");
                    break;
            }
        }
    }
}
