using System;
using System.Linq;

namespace Introduction_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 89, 34, 234, 100, 78, 99 };


            int[] resulat = (from n in number select n).ToArray();


            int[] resulat2 = (from n in number orderby n descending select n).ToArray();


        }
    }
}
