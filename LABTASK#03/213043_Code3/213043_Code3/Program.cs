
using System;
using Person;

namespace Person
{
    public class Female
    {
        public string Name { get; set; }
    }
}

namespace Basic
{
    class program
    {
        static void Main(string[] args)
        {
            Female female = new Female();
            female.Name = "Rimsha";
            Console.WriteLine($"Her name is {female.Name}");
        }


    }
}