using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
                if (arr[i] < min)
                    min = arr[i];
                max = Math.Max(max, arr[i]);

            }
        
            Console.WriteLine("Average = " + arr.Average());
        }
    }
}
