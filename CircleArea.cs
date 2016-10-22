using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            float floatPI=(float)3.141592653589793238f;
            double doublePI = 3.141592653589793238d;

            Console.WriteLine("{0:F12}",Math.PI*r*r);

        }
    }
}
