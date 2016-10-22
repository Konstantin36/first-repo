using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Extract_MiddleElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();
            var result = ExtractMiddleElements(nums);
            Console.WriteLine("{"+string.Join(", ",result)+"}");
        }

        private static int[] ExtractMiddleElements(int[] nums)
        {
            int len=nums.Length;
            if (len== 1)
                return nums;
            if (len % 2 == 0)
            return new int[] { nums[len / 2 - 1], nums[len / 2] };
            return new int[] { nums[len / 2 - 1], nums[len / 2], nums[len / 2+1] };


        }
    }
}
