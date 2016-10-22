using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometry_Calculator
{
    class Program
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            int side = int.Parse(Console.ReadLine());

            int height = int.Parse(Console.ReadLine());
            if (figure=="triangle")
            {
                var area = side * height / 2;
                Console.WriteLine("{0:F2}",area);
            }
            if (figure=="square")
            {
                var area = side * side;
                Console.WriteLine("{0:F2}", area);
            }
            else if (figure == "rectangle")
            {
                var area = side * height;
                Console.WriteLine("{0:F2}", area);
            }

        }
    }
}
