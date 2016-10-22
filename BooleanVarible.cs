using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooleanVarible
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if (text=="True")
            {
                Console.WriteLine("Yes");
            }
            else if (text=="False")
            {
                Console.WriteLine("No");                
            }
        }
    }
}
