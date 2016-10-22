using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr= new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arr.Length-1; i >=0; i--)
            {
                Console.Write(arr[i]);
                if (i > 0) Console.Write(' ');
                else Console.WriteLine();
            }
        }
    }
}
