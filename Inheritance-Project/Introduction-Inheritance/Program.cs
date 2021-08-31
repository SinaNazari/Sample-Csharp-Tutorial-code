using System;

namespace Introduction_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number:");
            Console.WriteLine(ChildClass.mins(3, 5));
            Console.WriteLine(ChildClass.sum(3, 5));
            Console.WriteLine(ChildClass.Multiply(3, 5));
            Console.ReadKey();
        }
    }
}
