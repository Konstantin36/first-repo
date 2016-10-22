using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNames
{
    class Program
    {
        static void Main(string[] args)
        {


            int p = int.Parse(Console.ReadLine());
            int MaxPoints = int.MinValue;
            string winner = "";

            for (int i = 0; i < p; i++)
            {

                string PlayerName = Console.ReadLine();
                int InitialScores = int.Parse(Console.ReadLine());
                int sum = InitialScores;
                for (int j = 0; j < PlayerName.Length; j++)
                {
                    if (PlayerName[j] % 2 == 0)
                    {
                        sum += PlayerName[j];
                    }
                    else
                    {
                        sum -= PlayerName[j];
                    }
                    if (sum > MaxPoints)
                    {
                        MaxPoints = sum;
                        winner = PlayerName;

                    }
                    Console.Write("The winner is {0} - {1} points", winner, MaxPoints);

                }




            }


        }
    }
}
