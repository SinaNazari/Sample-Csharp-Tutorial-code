using System;

namespace Introduction_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPublicClass myclass = new MyPublicClass();
            myclass.name = "Sina";
            myclass.family = "Nazari";

            Console.WriteLine($"name: {myclass.name} family: {myclass.family} website: {MyPublicClass.website="www.sina.com"}");

            Console.WriteLine(MyPublicClass.website);
            Console.ReadKey();

        }
    }
}
