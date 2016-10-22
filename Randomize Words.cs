using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Randomize_Words
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int first = 0; first < words.Length; first++)
            {
                var second=rnd.Next(0,words.Length);
                var old=words[first];
                words[first]=words[second];
                words[second]=old;
            }
            Console.WriteLine(string.Join("\r\n",words));
        }
    }
}
