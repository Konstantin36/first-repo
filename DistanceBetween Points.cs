
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(x1-x2);
            double b = Math.Abs(y1-y2);
            double c = a * a + b * b;
            var result = Math.Sqrt(c);
            Console.WriteLine(result);
        }
    }
}
