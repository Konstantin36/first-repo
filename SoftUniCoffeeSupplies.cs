using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimiters = Console.ReadLine().Split(' ');
            string input = Console.ReadLine();
            var personCoffee=new Dictionary<string,string>();
            var coffeeQuantity=new Dictionary<string,int>();
            var personQuantity = new Dictionary<string, int>();
            var coffeDrank = new Dictionary<string, int>();
            var coffeeLeft = new Dictionary<string, int>();

            //First loop for input
            while (input != "end of info")
            {
                int personSplitIndex=input.IndexOf(delimiters[0]);
                if (personSplitIndex != -1)
                {
                    //PersonName[firstDelimiter]CoffeeType
                    string person = input.Substring(0, personSplitIndex);
                    string coffee = input.Remove(0, personSplitIndex + delimiters[0].Length);
                    personCoffee[person] = coffee;
                }
                else
                {
                    //CoffeeType[secondDelimiter]Quantity
                    int coffeSplitIndex = input.IndexOf(delimiters[1]);
                    string coffee= input.Substring(0, coffeSplitIndex);
                    int quantity = int.Parse(input.Remove(0, coffeSplitIndex + delimiters[1].Length));
                    if (coffeeQuantity.Keys.Contains(coffee))
                    {
                        coffeeQuantity[coffee] += quantity;
                    }
                    else
                    {
                        coffeeQuantity[coffee] = quantity;
                    }
                }
                input = Console.ReadLine();
            }
            
            //Second loop for input
            input = Console.ReadLine();
            while (input != "end of week")
            {
                string[] elements = input.Split(' ');
                string name = elements[0];
                int quantity = int.Parse(elements[1]);

                if (personQuantity.ContainsKey(name))
                {
                    personQuantity[name] += quantity;
                }
                else
                {
                    personQuantity[name] = quantity;
                }
                input = Console.ReadLine();
            }

            
            //Calculate how much coffee is drank from each type
            foreach (var pair in personCoffee)
            {
                string coffee = pair.Value;
                string name = pair.Key;
                if (personQuantity.Keys.Contains(name))
                {
                    int drank = personQuantity[name];
                    if (coffeDrank.ContainsKey(coffee))
                    {
                        coffeDrank[coffee] += drank;
                    }
                    else
                    {
                        coffeDrank[coffee] = drank;
                    }

                }
            }

            
            //Check if out of [x type of cofee] or add to dictionary with left types
            foreach (var i in personCoffee)
            {
                string coffee = i.Value;
                int quantity;
                int drank;

                if (coffeeQuantity.Keys.Contains(coffee))
                {
                    quantity = coffeeQuantity[coffee];
                }
                else
                {
                    quantity = 0;
                }

                if (coffeDrank.Keys.Contains(coffee))
                {
                    drank = coffeDrank[coffee];
                }
                else
                {
                    drank = 0;
                }

                if (drank < quantity)
                {
                    int left = quantity - drank;
                    coffeeLeft[coffee] = left;
                }
                else
                {
                    Console.Out.WriteLine("Out of {0}",coffee);
                }
            }


            //Print coffee types that are left sorted by amount
            Console.Out.WriteLine("Coffee Left:");
            foreach (var i in coffeeLeft.OrderBy(x => -x.Value))
            {
                string coffee = i.Key;
                int left = i.Value;
                Console.Out.WriteLine("{0} {1}",coffee,left);
            }

            //Print people and the type of coffee they drink(if it is left). Ordered by coffee name, then by person name
            Console.Out.WriteLine("For:");
            foreach (var i in coffeeLeft.OrderBy(x => x.Key))
            {
                string coffee = i.Key;
                foreach (var person in personCoffee.OrderByDescending(x => x.Key))
                {
                    string coffee2 = person.Value;
                    if (coffee == coffee2)
                    {
                        Console.Out.WriteLine("{0} {1}",person.Key,coffee);
                    }
                }
            }
        }
    }
}