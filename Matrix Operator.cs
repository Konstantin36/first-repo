using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            List<List<int>> matrix= new List<List<int>>();
            for (int currentRow = 0; currentRow < rows; currentRow++)
			{
			 matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());
			}
            CommandEngine(matrix);
        }

        private static void CommandEngine(List<List<int>> matrix)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="end")
                {
                    break;
                }
                string[] commandArgs = command.Split();
                string commandName = commandArgs[0];
                string firstParameter = commandArgs[1];
                string secondtParameter = commandArgs[2];

                switch (commandName)
                {
                    case "swap":
                        Swap(matrix,firstParameter,secondtParameter);
                        break ;
                    case "insert":
                        Insert(matrix, firstParameter, secondtParameter);
                        break;
                    case "remove":
                        Remove(matrix, firstParameter, secondtParameter,int.Parse(commandArgs[3]));
                        break;
                }
            }
            PrintMatrix(matrix);
        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }

        private static void Remove(List<List<int>> matrix, string type, string position, int index)
        {
            if (position=="row")
            {
                switch (type)
                {
                    case"positive":
                        matrix[index] = matrix[index].Where(number => number < 0).ToList();
                        break;
                    case "negative":
                        matrix[index] = matrix[index].Where(number => number > 0).ToList();
                        break;
                    case "odd":
                        matrix[index] = matrix[index].Where(number=>number%2==0).ToList();
                        break;
                    case "even":
                        matrix[index] = matrix[index].Where(number => number % 2 != 0).ToList();
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "positive":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index]>=0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }
                        }
                        break;
                    case "negative":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] < 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                    case "odd":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] % 2 != 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                    case "even":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] % 2 == 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                }
               
            }
        }

        private static void Insert(List<List<int>> matrix, string firstParameter, string secondtParameter)
        {
            int rowIndex = int.Parse(firstParameter);
            int number=int.Parse(secondtParameter);
                matrix[rowIndex].Insert(0,number);
        }

        private static void Swap(List<List<int>> matrix, string firstParameter, string secondtParameter)
        {
            int firstRow=int.Parse(firstParameter);
            int secondRow=int.Parse(secondtParameter);

            List<int> temporery = matrix[firstRow];
            matrix[firstRow] = matrix[secondRow];
            matrix[secondRow] = temporery;
        }
    }
}
