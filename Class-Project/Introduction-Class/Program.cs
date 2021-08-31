using System;
using System.Collections.Generic;
using System.Threading;

namespace Introduction_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Count Employees:");
            int number = Convert.ToInt32(Console.ReadLine());
            Person[] people = new Person[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Please Enter Person[{i + 1}] Name:");
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("************************************");
                Console.ResetColor();

                Console.WriteLine($"Please Enter Person[{i + 1}] Family:");
                string family = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("************************************");
                Console.ResetColor();

                Console.WriteLine($"Please Enter Person[{i + 1}] WebSite:");
                string webSite = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("************************************");
                Console.ResetColor();

                Person p = new Person(name, family, webSite);
                people[i] = p;

            }

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            foreach (var person in people)
            {
                Console.WriteLine($"Name: {person.name} Family: {person.family} WebSite: {person.website}");
                ColorMethod();
            }


            static void ColorMethod()
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("**********************************************");
                Console.ResetColor();
            }

            Thread.Sleep(2000);
            Environment.Exit(0);

            Console.ReadKey();
        }
    }
}
