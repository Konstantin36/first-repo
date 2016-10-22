using System;


namespace Largest_Common_End
{
    class Program
    {
        static void Main( )
        {
            string[] firstArray=Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            int smallerArrayLenght = Math.Min(firstArray.Length, secondArray.Length);
            int leftCounter = 0;
            int rightCounter = 0;

            leftCounter = CheckArray(firstArray, secondArray, smallerArrayLenght);
                Array.Reverse(firstArray);
                Array.Reverse(secondArray);
                rightCounter = CheckArray(firstArray, secondArray, smallerArrayLenght);
                Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }

        private static int CheckArray(string[] firstArray, string[] secondArray, int smallerArrayLenght)
        {
            int leftCounter = 0;
            for (int i = 0; i < smallerArrayLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftCounter++;
                }
                else
                {
                    break;
                }
            }
            return leftCounter;
        }
    }
}
