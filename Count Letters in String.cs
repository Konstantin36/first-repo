using System;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Count_Letters_in_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxValue = name.Max();
            int[] charCounter = new int[maxValue + 1];
            for (int i = 0; i < name.Length; i++)
            {
                charCounter[name[i]]++;
            }
            for (int i = 0; i < charCounter.Length; i++)
            {
                if (charCounter[i]!=0)
	            {
            		Console.WriteLine("{0} - {1}",(char)i,charCounter[i]); 
	            }
            }                
        }
    }
}
