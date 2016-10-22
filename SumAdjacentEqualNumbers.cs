using System;
using System.Linq;

namespace _12.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] == input[i - 1])
                {
                    input[i] = input[i] + input[i - 1];
                    input.Remove(input[i - 1]);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}