using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserName = Console.ReadLine();
            //Console.WriteLine("Hello, " + UserName + "!");

            //string interpolation
            Console.WriteLine($"Hello, {UserName}!");

            Console.Read();
        }
    }
}
