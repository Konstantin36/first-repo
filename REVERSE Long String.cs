﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine().ToUpper();
        string rgx = "(\\D+)(\\d+)"; //http://regexr.com/
        Regex regex = new Regex(rgx);
        int count = 0; //броя на уникалните символи
        StringBuilder elements = new StringBuilder();
        StringBuilder output = new StringBuilder();
        // всички символи които се повтарят

        MatchCollection collection = regex.Matches(input);

        foreach (Match match in collection)
        {
 //Console.WriteLine(match);показва отделните лементи на стринга input с главни букви
            elements.Append(match.Groups[1]);
            for (int i = 0; i < int.Parse(match.Groups[2].ToString()); i++)
            {
                output.Append(match.Groups[2]);
//взема символите без цифрите
            }
        }
        count = elements.ToString().Distinct().Count();
        Console.WriteLine("Unique symbols used: {0}",count);
        Console.WriteLine("{0}",output);
    }    
}

