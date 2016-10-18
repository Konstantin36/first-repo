using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        var num = 5;
        var d = DateTime.Now;

        System.Threading.Thread.CurrentThread.CurrentCulture =
            new System.Globalization.CultureInfo("bg-Bg");
        Console.WriteLine("{0:MMM}",d);
    }
}

