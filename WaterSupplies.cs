using System;
using System.Collections.Generic;
using System.Linq;
class WaterSupplies
{
static void Main()
{
    double water = double.Parse(Console.ReadLine());
    double[] bottles = Console.ReadLine().Split()
        .Select(double.Parse).ToArray();
    double bottleCapacity = double.Parse(Console.ReadLine());
int breakIndex = -1;
    if (water%2==0)
    {
  // от ляво на дясно
        
        for (int i = 0; i < bottles.Length; i++)
        {
            double requiredWater = bottleCapacity - bottles[i]; //допълваме бутилките
            if (water>=requiredWater)
            {
            bottles[i] += requiredWater; // прибавяме необходимото количество и от общото кол. изваждаме

            water -= requiredWater;
            }
            else
            {
                breakIndex = i;
   ///ако е -1 няма прекъсване и всички бутилки са напълнени
                bottles[i] = water;
                break;
            }
    
         }
                
    }

    else
    {
        // от дясно на ляво
        
        for (int i = bottles.Length-1; i > 0; i--)
        {
                        double requiredWater = bottleCapacity - bottles[i]; //допълваме бутилките
            if (water>=requiredWater)
            {
            bottles[i] += requiredWater; // прибавяме необходимото количество и от общото кол. изваждаме

            water -= requiredWater;
            }
            else
            {
                breakIndex = i;
   ///ако е -1 няма прекъсване и всички бутилки са напълнени
                bottles[i] = water;
                break;
            }
    
         }
 
        }
           if (breakIndex==-1)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine("Water left: {0}l.",Math.Abs(water-bottles.Sum()));
            }
            else
            {
                int bottlesCount = bottles.Where(b=>b<bottleCapacity).Count();
                List<int> indexes = new List<int>();
                double waterShortage = 0;   // water to the end
                for (int i = breakIndex; i < bottles.Length; i++)
                {
                    indexes.Add(i);
                    waterShortage += bottleCapacity - bottles[i];
                }
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}",bottlesCount);
                Console.WriteLine("With indexes: {0}",string.Join(", ",indexes));
                Console.WriteLine("We need {0} more liters!",waterShortage);
            }    
    }    
}
}   
