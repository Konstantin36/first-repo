using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexVarible = Console.ReadLine();
            int hexConverted = Convert.ToInt32(hexVarible,16);
            Console.WriteLine(hexConverted);
        }
    }
}
