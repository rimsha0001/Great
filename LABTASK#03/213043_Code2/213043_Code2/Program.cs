using System;


namespace Basic
{
    class program
    {
        static void Main(string[] args)
        {
            SaySomething("Rey");
        }

        static void SaySomething()
        {
            System.Console.WriteLine("i don't know your name.");
        }
        static void SaySomething(string first)
        {
            Console.WriteLine($"cheers,{first}");
        }
        private static void SaySomething(string first, string Last)
        {
            Console.WriteLine($"cheers,{first}{Last}");
        }
    }
}