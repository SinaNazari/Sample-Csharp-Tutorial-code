using System;

namespace Introduction_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //string[] names = { "Sina", "Ali", "Mina", "Reza", "Sara" };

            //for (int i = 0; i <= names.Length; i++)
            //{
            //    Console.WriteLine($"Name is:{names[i]}");
            //}


            try
            {
                while (true)
                {

                    int employes;
                    char ch;
                    string employeesName;

                    Console.WriteLine("Please Enter Your Employees Count:");
                    employes = Convert.ToInt32(Console.ReadLine());
                    string[] names = new string[employes];

                    for (int i = 0; i < employes; i++)
                    {
                        Console.WriteLine($"Please Enter Name Employees:" + (i + 1));
                        names[i] = Console.ReadLine();
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                    Console.ResetColor();
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Your Employees:{names[i] + 1}");
                        Console.WriteLine("*******************************");
                        Console.ResetColor();
                    }
                    Console.WriteLine("You Are Continue:(y/n)");
                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'n')
                    {
                        Environment.Exit(0);
                    }
                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Locate Your input!!!!");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
