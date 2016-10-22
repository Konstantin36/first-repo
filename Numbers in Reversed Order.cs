using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInRevOrder_16._05._2016
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] number = Console.ReadLine().ToArray();
            int l = number.Length;
            ReversingNumber(number, l);

        }

        static void ReversingNumber(char[] number, int l)
        {
            int i = l - 1;
            char[] revNumber = new char[l];

            while (i >= 0)
            {
                revNumber[l - 1 - i] = number[i];
                i--;
            }

            foreach (char revnumber in revNumber)
            {
                Console.Write(revnumber);
            }
            Console.WriteLine();
        }
    }
}