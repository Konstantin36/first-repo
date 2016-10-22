using System;
using System.Collections.Generic;
using System.Globalization;


namespace DayOF_Week
{
    class Program
    {
        static void Main()
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine(firstDate.DayOfWeek);

        }
    }
}
