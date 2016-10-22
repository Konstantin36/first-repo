using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
    string inputString = Console.ReadLine();

    string resultString=string.Join(" ",inputString
    .Split()
    .Select(x=>new String(x.Reverse().ToArray())));
    Console.WriteLine(resultString);
    }    
}

