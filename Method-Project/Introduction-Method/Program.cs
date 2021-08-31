using System;
using System.Threading;

namespace Introduction_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string family;

            Console.WriteLine("Please Enter Name:");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter Family:");
            family = Console.ReadLine();

            if (name == "Sina" && family == "Nazari")
            {
                HelloAdmin();
                Console.WriteLine("********************");
                Console.WriteLine("Welcome Admin..");
            }
            else
            {
                HelloUser();
                Console.WriteLine("********************");
                Console.WriteLine("Welcome User...");
            }

            Thread.Sleep(2000);
            Console.Clear();
            
            Environment.Exit(0);
            Console.ReadKey();
        }

        static void HelloAdmin()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello Admin...");
            Console.ResetColor();
        }

        static void HelloUser()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello User...");
            Console.ResetColor();
        }
    }
}
