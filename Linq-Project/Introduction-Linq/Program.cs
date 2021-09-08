using System;
using System.Collections.Generic;
using System.Linq;

namespace Introduction_Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 42, 46, 67, 59, 64, 89, 34, 234, 100, 78, 99 };

            List<string> names = new List<string>();
            names.Add("Sina");
            names.Add("Ali");
            names.Add("Reza");
            names.Add("Sara");
            names.Add("Mina");
            names.Add("mammad");


            int[] resulat = (from n in number select n).ToArray();


            int[] resulat2 = (from n in number orderby n descending select n).ToArray();

            int[] resulat3 = (from n in number
                              where n > 80
                              orderby n descending
                              select n).ToArray();

            int[] resulat4 = (from n in number
                              where n > 40 && n < 80
                              orderby n ascending
                              select n).ToArray();

            var resulat5 = (from n in number
                            where n == 8
                            select n).Any();

            var resulat6 = (from n in number
                            select n).Max();

            var resulat7 = (from n in number
                            select n).Min();

            var resulat8 = (from n in number
                            select n).Count();

            var resulat9 = (from n in number
                            select n).Contains(4);

            var resulat14 = (from n in number
                             select n).Take(9).Skip(4).ToList();

            var resulat17 = (from n in number
                             where n == 8
                             select n).First();


            var resulat18 = (from n in number
                             where n == 8
                             select n).FirstOrDefault();

            var resulat19 = (from n in number
                             where n == 59
                             select n).Single();


            var resulat20 = (from n in number
                             where n == 59
                             select n).SingleOrDefault();


            var resulat10 = (from n in names
                             select n).ToList();

            var resulat11 = (from n in names
                             orderby n descending
                             select n).ToList();

            var resulat12 = (from n in names
                             where n == "Sina"
                             select n).Any();

            var resulat13 = (from n in names
                             select n.Contains("i").ToString()).ToList();

            var resulat21 = (from n in names
                             select n.ToLower().StartsWith("s")).ToList();

            var resulat22 = (from n in names
                             select n.ToLower().EndsWith("d")).ToList();
        }
    }
}
