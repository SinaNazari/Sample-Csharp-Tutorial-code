using System;
using System.Threading;

namespace Introduction_If_Switch
{
    class Program
    {

        static void Main(string[] args)
        {
            //int a, b, c;

            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Please Enter Number One:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.ResetColor();

            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("Please Enter Number Tow:");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.ResetColor();

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Please Enter Number Three:");
            //c = Convert.ToInt32(Console.ReadLine());
            //Console.ResetColor();


            //if (a < b)
            //{
            //    Console.WriteLine($"Number One is Small!:{a}");
            //}
            //else if (b < c)
            //{
            //    Console.WriteLine($"Number Tow is Small!:{b}");
            //}
            //else if (c < b && c < a)
            //{
            //    Console.WriteLine($"Number Three is Small!{c}");
            //}

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("********************************");
            //Console.ResetColor();

            //Thread.Sleep(3000);
            //Console.Clear();
            //Thread.Sleep(2000);
            //Environment.Exit(0);


            //Switch

            int number1, number2;
            char ch, bh;

            while (true)
            {   
                try
                {
                    while (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Please Enter Number One:");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();

                        Console.WriteLine("Please Enter Sample Between Number:");
                        ch = Convert.ToChar(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Please Enter Number Tow:");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Console.ResetColor();

                        switch (ch)
                        {
                            case '*':
                                Console.WriteLine($"Verb Tow Number is: {number1 * number2}");
                                break;
                            case '+':
                                Console.WriteLine($"Sum Number To Number is: {number1 + number2}");
                                break;
                            case '-':
                                Console.WriteLine($"Min Number To Number is: {number1 - number2}");
                                break;
                            case '/':
                                Console.WriteLine($"Average Number To Number is: {number1 / number2}");
                                break;
                            default:
                                Console.WriteLine("Your Sample is Not True!!!!");
                                break;
                        }
                        Console.WriteLine("You Are Continue?(y/n)");
                        bh = Convert.ToChar(Console.ReadLine());
                        Thread.Sleep(3000);
                        Console.Clear();
                        if (bh == 'n')
                        {
                            Environment.Exit(0);
                        }
                    }
                }
                catch (Exception)
                {
                    int n = 6;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please locate your Input is Not true!!!!!");
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine("");
                    }
                    Console.ResetColor();
                }
            }

        }
    }
}
