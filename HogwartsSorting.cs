using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HogwartsSorting
{
    class Program
    {
        static void Main()
        {
            int griffindorf = 0;
            int slitherin = 0;
            int ravenclaw = 0;
            int hufflepull = 0;
            int numberOfStudentsToEnter = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfStudentsToEnter; i++)
            {
                int sumOfAscii = 0;
                string[] names = Console.ReadLine().Split(' ');
                string firstName = names[0];
                string lastName = names[1];

                for (int letter = 0; letter < firstName.Length; letter++)
                {
                    sumOfAscii += firstName[letter];
                }
                for (int letter = 0; letter < lastName.Length; letter++)
                {
                    sumOfAscii += lastName[letter];
                }

                string facultyNumber = string.Format("{0}{1}{2}", sumOfAscii, firstName[0],lastName[0]);
                int reminde = sumOfAscii % 4;
                switch (reminde)
                {
                    case 0:
                        griffindorf++;
                        Console.WriteLine("Gryffindor {0}",facultyNumber);
                        break;
                    case 1:
                        slitherin++;
                        Console.WriteLine("Slytherin {0}",facultyNumber);
                        break;
                    case 2:
                        ravenclaw++;
                        Console.WriteLine("Ravenclaw {0}",facultyNumber);
                        break;
                    case 3:
                        hufflepull++;
                        Console.WriteLine("Hufflepuff {0}",facultyNumber);
                        break;

                }
            }
            Console.WriteLine();
            Console.WriteLine("Gryffindor: {0}",griffindorf);
            Console.WriteLine("Slytherin: {0}",slitherin);
            Console.WriteLine("Ravenclaw: {0}",ravenclaw);
            Console.WriteLine("Hufflepuff: {0}",hufflepull);            
        }
    }
}
