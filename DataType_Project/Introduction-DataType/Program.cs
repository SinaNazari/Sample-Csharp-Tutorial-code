using System;
using System.Threading;

namespace Introduction_DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            int userId = 0;
            string firstName = string.Empty;
            string lastName = string.Empty;
            decimal userSalary = decimal.Zero;
            bool Sex = false;


            Console.WriteLine("Please Enter UserId:");
            userId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter FirstName:");
            firstName = Console.ReadLine();

            Console.WriteLine("Please Enter LastName:");
            lastName = Console.ReadLine();

            Console.WriteLine("Please Enter UserSalary:");
            userSalary = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please Enter Sex:(is Man=true | is Woman=false)");
            Sex = Convert.ToBoolean(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"UserId ={userId} FirstName = {firstName}  LastName = {lastName}" + " " +
                $"UserSalary = {userSalary} Sex = {Sex}");
            Console.ResetColor();

            Thread.Sleep(3000);
            Console.WriteLine("Good By..." + " " + "Com Back Later!!!");

            Thread.Sleep(2000);
            Console.Clear();

            Thread.Sleep(1000);
            Environment.Exit(0);

            Console.ReadKey();

        }

    }
}
