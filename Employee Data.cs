using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            double personalID = double.Parse(Console.ReadLine());
            int uniqueEmploye = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}", secondName);
            Console.WriteLine("Age: 27", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}", uniqueEmploye);
        }
    }
}
