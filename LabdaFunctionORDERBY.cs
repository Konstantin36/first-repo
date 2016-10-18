using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 11, 99, 33, 55, 77, 44, 66, 22, 88 };
        int[] newEditednums = nums
                              .OrderBy(x => x)
                              .Take(5)
                              .ToArray();
        Console.WriteLine(String.Join(" ",newEditednums));
    }
}

