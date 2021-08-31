using System;

namespace Tow_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter First Name:");

            var name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Hello {name}");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
