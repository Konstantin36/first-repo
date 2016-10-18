using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        int[] nums = {11, 99, 33, 55, 77, 44, 66, 22, 88 };
        nums.Where(x => x<50).Take(3);
       
     
            Console.WriteLine(string.Join(" ",nums));
    }
}

