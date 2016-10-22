using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
        static bool IsPrime(long number)
        {
            if (number<=1)
            {
                return false;
            }
            int maxDivider = (int)Math.Sqrt(number);
            for (long divider = 2; divider <= maxDivider; divider++)
            {
                if (number%divider==0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
