using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int people = numberOfPeople / capacity;
            if (numberOfPeople%capacity!=0)
            {
                people++;
            }
            Console.WriteLine(people);
        }
    }
}
