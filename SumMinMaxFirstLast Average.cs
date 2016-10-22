using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumMinMaxFirstLast_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var arr=new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
            } 
            int sum = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            double average = sum / n;
            for (int i = 0; i < n; i++)
            {
                sum=sum+arr[i];
                if (arr[i]<min)
                    min=arr[i];
                max = Math.Max(max,arr[i]);
            }
            Console.WriteLine("Sum =  "+sum);
            Console.WriteLine("Min =  "+min);
            Console.WriteLine("Max =  "+max);
            Console.WriteLine("First =  "+arr[0]);
            Console.WriteLine("Last =  " +arr[n-1]);
            Console.WriteLine("Average =  " +average);

        }
    }
}
