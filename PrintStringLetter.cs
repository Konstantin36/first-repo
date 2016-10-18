using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        var str = Console.ReadLine();
        var counts=new int[str.Max()+1];
        for (int i = 0; i < str.Length; i++)
        {
            counts[str[i]]++;
        }
        for (int i = 0; i < counts.Length; i++)
        {
            if (counts[i]>0)
                Console.WriteLine("{0} -> {1}",(char)i,counts[i] );
        }
    }
}

