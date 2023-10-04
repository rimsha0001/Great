using System;


namespace Basic
{
    class program
    {
        static void Main(string[] args)
        {
            displayout();
        }
        static void displayout()
        {
            var population = 220000000;
            var weight = 1.89;
            var price = 100;
            var fruit = "Apple";
            Console.WriteLine($"The pakistan population is {population}.");
            Console.WriteLine($"The pakistan population is {population:No}.");
            Console.WriteLine($"{weight} Kg of {fruit} costs {price:C}");
        }


    }
}