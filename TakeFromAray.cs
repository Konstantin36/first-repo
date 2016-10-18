using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TakeandSkip
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 2, 3, 4, 5, 6 };
           var  numsAfterSkip = nums
                .Skip(3)
                .ToArray();
            Console.WriteLine(string.Join(" ",numsAfterSkip));
        }
    }
}
