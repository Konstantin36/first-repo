using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Diagnostics;
using System.Net;
using System.Text;

namespace DayOfWeekObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateAsText = Console.ReadLine();
            var date = DateTime.ParseExact(dateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
