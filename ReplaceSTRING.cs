using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Remove
{
    static void Main(string[] args)
    {
        string price = "$ 1234567";
        string lowPrice = price.Remove(2,3);
            Console.WriteLine(lowPrice);
    }
}

