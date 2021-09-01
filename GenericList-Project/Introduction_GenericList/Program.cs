using System;
using System.Collections.Generic;

namespace Introduction_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {

            //List

            //int[] number = { 1, 2, 3, 4, 5 };

            //string[] names = { "Sina", "Ali", "Reza", "Mina" };

            //List<int> number = new List<int>();


            //GenericList

            List<string> names = new List<string>();
            names.Add("Sina");
            names.Add("Sara");
            names.Add("Mina");
            names.Add("Ali");

            names.Remove("Sara");
            names.RemoveAt(3);



            foreach (var item in names)
            {
                Console.WriteLine($"\n {item}");
            }

            Console.ReadKey();

        }
    }
}
