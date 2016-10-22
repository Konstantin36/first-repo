using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class REGex
{
    static void Main(string[] args)
    {
        string[] w = SplitWords("That is a cute cat, man");
        foreach (string s in w)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }    
    static string[] SplitWords(string s)
    {       
        return Regex.Split(s, @"\W+");  
    }
}

