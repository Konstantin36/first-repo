using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Globalization;

class CoffeeOrders
{
static void Main(string[] args)
{
    long inputNum = long.Parse(Console.ReadLine());
    decimal allSum = 0;
    for (long i = 0; i < inputNum; i++)
    {
        decimal capsulePrice = decimal.Parse(Console.ReadLine());
        DateTime date = 
DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
long count = long.Parse(Console.ReadLine());

decimal price = DateTime.DaysInMonth(date.Year, date.Month) * count*capsulePrice;
allSum += price;
Console.WriteLine("The price for the coffee is: ${0:F2}",price);
    }
    Console.WriteLine("Total: ${0:F2}",allSum);
}
}

