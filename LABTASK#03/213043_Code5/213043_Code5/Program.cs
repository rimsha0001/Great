using System;

namespace Basic
{
    class program
    {
        static void Main(string[] args)
        {
            GetInput();
        }
        private static void GetInput()
        {
            Console.WriteLine("Enter your Name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Type Page number: ");
            string pg = Console.ReadLine();
            Console.WriteLine($"Hello {Name} your page number is {pg}");

        }


    }
}