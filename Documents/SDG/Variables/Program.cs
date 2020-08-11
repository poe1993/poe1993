using System;

namespace OurDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Program!");

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n");

            Console.Write("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"It is a pleasure to meet you, {name}");

            var score = 98;

            Console.WriteLine($"Your score is {2 * score - 5}");



        }
    }
}
