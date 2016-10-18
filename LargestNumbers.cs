using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5, 6 };
   nums=nums
       .Where(num=>num%2==0)
       .ToArray();
            Console.WriteLine(string.Join(" ",nums));
    }
}

