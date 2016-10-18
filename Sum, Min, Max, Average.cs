using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
       var nums=Console.ReadLine()
           .Split()
           .Select(number=>double.Parse(number))
           .ToArray();
       foreach (var number in nums)
       {
           Console.WriteLine(number);
       }
    }
}


