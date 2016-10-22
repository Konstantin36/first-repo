using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class_Select
{
    class Program
    {
        static void Main()
        {
            var[] nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        }
    }
}
