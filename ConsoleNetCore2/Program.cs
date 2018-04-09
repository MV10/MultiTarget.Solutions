using System;
using Library;

namespace ConsoleNetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            IHello hi = HelloFactory.GetThisPartyStarted();
            Console.WriteLine(hi.SayHello());
            Console.ReadKey();
        }
    }
}
