using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < nums.Length / 2; i++)
                SwapElement(nums, i, nums.Length - 1 - i);
            Console.WriteLine(string.Join(" ",nums));
        }

        private static void SwapElement(string[] arr, int i, int j)
        {
            var oldElement = arr[i];
            arr[i] = arr[j];
            arr[j] = oldElement;
        }
    }
}
