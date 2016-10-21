using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Airline
{
    static void Main()
    {

        int flightCount = int.Parse(Console.ReadLine());
        decimal totalProfit = 0;

        for (int i = 0; i < flightCount; i++)
        {
            int adultCount = int.Parse(Console.ReadLine());
            decimal adultPrice = decimal.Parse(Console.ReadLine());
            int youthCount = int.Parse(Console.ReadLine());
            decimal youthPrice = decimal.Parse(Console.ReadLine());
            decimal fuelPrice = decimal.Parse(Console.ReadLine());
            decimal fuelConsumption = decimal.Parse(Console.ReadLine());
            int flightDuration = int.Parse(Console.ReadLine());

            var income = (adultCount * adultPrice) + (youthCount * youthPrice);
            var expenses = fuelPrice * fuelConsumption * flightDuration;
            var profit = income - expenses;
            totalProfit += profit;

            if (profit >= 0)
            {
                Console.WriteLine("You are ahead with {0:F3}$.", profit);
            Console.WriteLine("Overall profit -> {0:F3}$.", totalProfit);
            Console.WriteLine("Average profit -> {0:F3}$.", totalProfit / flightCount);
            }
            else
            {
                Console.WriteLine("We've got to sell more tickets! We've lost -{0:F3}$.", Math.Abs(profit));
            }
            
        }
    }
}

