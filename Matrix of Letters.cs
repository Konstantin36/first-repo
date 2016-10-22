using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_of_Letters
{
    class Lists     
    {
        static void Main()
        {
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

           char[][] matrix = new char[rows][];

            for (int currentRow = 0; currentRow < rows; currentRow++)
            {
                matrix[currentRow] = new char[cols];
            }
            char filler = 'A';

            for (int currentRow = 0; currentRow < matrix.Length; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrix[currentRow].Length; currentCol++)
                {
                    matrix[currentRow][currentCol] = filler;
                    filler++;
                }
            }
            foreach (var row in matrix)
            {
                foreach (var col in row)
                {
                    Console.Write("{0} ",col);
                }
                Console.WriteLine();
            }

        }
    }
}
