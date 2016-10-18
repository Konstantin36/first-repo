using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
    IList<int> largest3Nums=Console.ReadLine()
                            .Split(' ')
                            .Select(int.Parse)
                            .OrderByDescending(x=>x)
                            .Take(3)
                            .ToList();
            Console.WriteLine(string.Join(" ",largest3Nums));
    }
}

