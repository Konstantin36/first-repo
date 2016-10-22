using System;

namespace Print_a_Receipt
{
    class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse);

            Console.WriteLine(@"/----------------------\");

            foreach (var num in nums)
                Console.WriteLine("|{0, 20:F2}|",num);
            Console.WriteLine(@"|----------------------|");
            Console.WriteLine(@"\----------------------/");


        }
    }
}
