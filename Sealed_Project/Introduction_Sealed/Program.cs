using System;

namespace Introduction_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            SealedCalss sealedCalss = new SealedCalss();
            int Total = sealedCalss.Add(5, 9);
            Console.WriteLine("Total is:" + Total.ToString());
            Console.ReadKey();
        }
    }

    sealed class SealedCalss
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
