using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Equal_Sums
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool IsIndexFound = false;
            for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
            {
                int sumLeft = 0;
                int sumRight = 0;
                for (int i = currentElement+1; i < numbers.Length; i++)
                {
                    sumRight += numbers[i];
                }
                for (int i = 0; i < currentElement; i++)
                {
                    sumLeft += numbers[i];
                }
                if (sumRight==sumLeft)
                {
                    Console.WriteLine(currentElement);
                    IsIndexFound = true;
                    break;
                }
            }
            if (!IsIndexFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
