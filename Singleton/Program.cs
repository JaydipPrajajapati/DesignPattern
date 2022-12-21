using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = new Singleton();
            s1.PrintDetails("This is first message");

            Singleton s2 = new Singleton();
            s1.PrintDetails("This is second message");
            Console.ReadLine();
        }
    }
}
