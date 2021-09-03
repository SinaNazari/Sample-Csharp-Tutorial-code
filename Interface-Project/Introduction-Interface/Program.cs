using System;
using System.Collections.Generic;

namespace Introduction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Person> people = new List<Person>() {
            new Person{Name="Sina",Family="Nazari",UniqceKey="2434535",AccessLevel="Admin"},
            new Person{Name="Reza",Family="kazime",UniqceKey="9580335",AccessLevel="User"},
            new Person{Name="Sara",Family="Rezaie",UniqceKey="2434535",AccessLevel="Deputy"}
            };



            foreach (var item in people)
            {
                Console.WriteLine($"Name:{item.Name} Famly:{item.Family} UniqceKey:{item.UniqceKey} AccessLevel:{item.AccessLevel}");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ResetColor();
            }

            
            Console.ReadKey();
        }
    }
}
