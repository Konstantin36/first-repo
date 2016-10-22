using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double perimeter = 2 * (a + b);
            double area = a * b;
            double diagonal = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("{0}", perimeter);
            Console.WriteLine("{0}", area);
            Console.WriteLine("{0}", diagonal);
        }
    }
}
