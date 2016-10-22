using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n =long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            var nums = new ulong[n];
            nums[0] = 1;
            for (long i = 1; i < n; i++)
            {
                var sum = 0;
                for (long prev = i - k; prev <= i - 1; prev++)
                    if (prev >= 0)
                        sum += nums[prev];
                nums[i] = sum;
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(nums[i]);
        }
    }
}
