using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string[] word = text
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }
                , StringSplitOptions.RemoveEmptyEntries).Where(w => w.Length < 5).OrderBy(x => x).Distinct()
                .ToArray();

            Console.WriteLine(string.Join(", ",word));
        }
    }
}
