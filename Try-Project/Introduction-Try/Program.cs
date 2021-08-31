using System;

namespace Introduction_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    int number1, number2;
                    char ch;
                    Console.WriteLine("Please Enter Number:");
                    number1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please Enter Number:");
                    number2 = Convert.ToInt32(Console.ReadLine());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Sum Number Is: {number1 + number2}");
                    Console.ResetColor();

                    Console.WriteLine("****************************");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You Are Continue:(y/n)");
                    Console.ResetColor();

                    ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'n')
                    {
                        Environment.Exit(0);
                    }

                }
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please Enter Just Number>>>>(1.2.3.4.5.6.7)!!!!!");
                Console.ResetColor();
            }


        }
    }
}
