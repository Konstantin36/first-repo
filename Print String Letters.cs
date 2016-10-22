using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Print_String_Letters
{
    class Program
    {
        static void Main()
        {
            var str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("str[{0}] -> '{1}'",i,str[i]);

            }
        }
    }
}
