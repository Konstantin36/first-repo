using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class Program
{
    static void Main(string[] args)
    {
        var text = Console.ReadLine();
        var words = Console.ReadLine().Split(' ');
        foreach (var w in words)
        {
            var stars = new string(' ',w.Length);
            text = Regex.Replace(text,w,stars,RegexOptions.IgnoreCase);
        }
        Console.WriteLine(text);
    }
}

//string text = Console.ReadLine();
//string[] words = Console.ReadLine().Split(' ');
//foreach (var w in words)
//	{
//		text=text.Replace(w, new string('*', w.Lenght)) 
//	}
// Console.WriteLine(text);
