using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class SplitingString
{
    static void Main(string[] args)
    {
        string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
        string[] beers = listOfBeers.Split(' ',',','.');
        Console.WriteLine("Avable beers are:");
        foreach (string beer in beers)
        {
            Console.WriteLine(beer);
        }
    }
}

