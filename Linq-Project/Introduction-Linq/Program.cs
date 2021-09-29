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

            var lambda = number.ToArray();


            int[] resulat2 = (from n in number orderby n descending select n).ToArray();

            var lambda2 = number.OrderByDescending(n => n).ToArray();


            int[] resulat3 = (from n in number
                              where n > 80
                              orderby n descending
                              select n).ToArray();

            var lambda3 = number.Where(n => n > 80).OrderByDescending(n => n).ToArray();


            int[] resulat4 = (from n in number
                              where n > 40 && n < 80
                              orderby n ascending
                              select n).ToArray();

            var lambda4 = number.Where(n => n > 40 && n < 80).OrderBy(n => n).ToArray();

            var resulat5 = (from n in number
                            where n == 8
                            select n).Any();

            var lambda05 = number.Any(n => n == 8);

            var resulat6 = (from n in number
                            select n).Max();

            var lambda6 = number.Max(n => n);

            var resulat7 = (from n in number
                            select n).Min();

            var lambda7 = number.Min(n => n);


            var resulat8 = (from n in number
                            select n).Count();

            var lambda8 = number.Count();

            var resulat9 = (from n in number
                            select n).Contains(4);

            var lambda9 = number.Contains(4);

            var resulat14 = (from n in number
                             select n).Take(9).Skip(4).ToList();

            var lambda10 = number.Take(9).Skip(4).ToList();


            var resulat17 = (from n in number
                             where n == 8
                             select n).First();

            var lambda17 = number.Where(n => n == 8).First();

            var resulat18 = (from n in number
                             where n == 8
                             select n).FirstOrDefault();

            var lambda18 = number.Where(n => n == 8).FirstOrDefault();

            var resulat19 = (from n in number
                             where n == 59
                             select n).Single();

            var lambda19 = number.Where(n => n == 59).Single();

            var resulat20 = (from n in number
                             where n == 59
                             select n).SingleOrDefault();

            var lambda20 = number.Where(n => n == 59).SingleOrDefault();

            var resulat10 = (from n in names
                             select n).ToList();

            var lambda010 = names;

            var resulat11 = (from n in names
                             orderby n descending
                             select n).ToList();

            var lambda011 = names.OrderByDescending(n => n);

            var resulat12 = (from n in names
                             where n == "Sina"
                             select n).Any();

            var lambda012 = names.Where(n => n == "Sina").Any();

            var resulat13 = (from n in names
                             select n.Contains("i").ToString()).ToList();

            var lambda013 = names.Contains("i").ToString();

            var resulat21 = (from n in names
                             select n.ToLower().StartsWith("s")).ToList();

            var lambda021 = names.Select(n => n.ToLower().StartsWith("s"));

            var resulat22 = (from n in names
                             select n.ToLower().EndsWith("d")).ToList();

            var lambda022 = names.Select(n => n.ToLower().EndsWith("d"));
        }
    }
}
