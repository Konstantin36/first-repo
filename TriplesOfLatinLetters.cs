using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i1 = 0; i1 < n; i1++)
                for (int r2 = 0; r2 < n; r2++)
                    for (int r3 = 0; r3 < n; r3++)
                    {
                        char letters1=(char)('a'+i1);
                        char letters2=(char)('a'+r2);
                        char letters3=(char)('a'+r3);
                            Console.WriteLine("{0}{1}{2}",
                            letters1, letters2, letters3);
                    }
        }
    }
}
