using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssembly
{
    public static class ExtentionMethod
    {
        public static string PersianTime(this DateTime value)
        {
            PersianCalendar persian = new PersianCalendar();
            string pc = persian.GetYear(value) + "/" + persian.GetMonth(value) + "/" +
            persian.GetDayOfMonth(value) + " " + persian.GetHour(value) + ":" + persian.GetMinute(value) +
            ":" + persian.GetSecond(value);
            return pc;
        }
    }
}
