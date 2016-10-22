using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            List<double> nums = new List<double>();
            foreach (var num in input)
            {
                nums.Add(double.Parse(num));
            }
            nums.Sort();
            Console.WriteLine(string.Join(" <= ",nums));
        }
    }
}
