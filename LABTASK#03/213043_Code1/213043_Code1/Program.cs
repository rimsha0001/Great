// See https://aka.ms/new-console-template for more information
using System;
namespace basic
{
    class program
    {
        static void Main(string[] args)
        {
            WriteStatement();
        }
        private static void WriteStatement()
        {
            var FirstName = "Rimsha";
            var LastName = "ALi";
            var FullName =FirstName +"  "+ LastName;
            Console.WriteLine("My Name is " + FullName);
        }
    }
}

