using System;
using System.Linq;


namespace RoundedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            foreach (var num in nums)
            {
                var rounded = Math.Round(num,MidpointRounding.AwayFromZero);
                Console.WriteLine(num+"=>"+rounded);
            }
        }
    }
}
