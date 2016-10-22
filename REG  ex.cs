using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class REGex
{
    static void Main(string[] args)
    {
        string value = "cat\r\ndog\r\nanimal\r\nperson";
        // Split the string on line breaks.
        // ... The return value from Split is a string array.
        string[] lines = Regex.Split(value, "\r\n");

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

