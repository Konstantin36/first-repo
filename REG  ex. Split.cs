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

    /// <summary>
    /// Take all the words in the input string and separate them.
    /// </summary>
    static string[] SplitWords(string s)
    {
        //
        // Split on all non-word characters.
        // ... Returns an array of all the words.
        //
        return Regex.Split(s, @"\W+");
        // @      special verbatim string syntax
        // \W+    one or more non-word characters together
    }
}

