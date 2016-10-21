using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

class CommandInterpreter
{
    static void Main(string[] args)
    {
        List<string> input=Console.ReadLine()
            .Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string[] command = Console.ReadLine().Split();
        while (!command[0].Equals("End"))
        {

            switch (command[0])
            {

                case  "reverse":
                    break;
                    int start = int.Parse(command[2]);
                    int count = int.Parse(command[4]);
                    // take part from List
                    List<string> currList = input
                                    .Skip(start)
                                    .Take(count)
                                    .Reverse()
                                    .ToList();
                    //изтриване
                    input.RemoveRange(start,count);

                    input.InsertRange(start, currList);//добавяне на новата част
                case "sort":
                    break;

                case "rollLeft":

                    break;
                case "rollRight":

                    break;

                default:
                    break;
            }

          command = Console.ReadLine().Split();             
        }

        string output = string.Join(", ",input) ;
        Console.WriteLine("[{0}]",output);
    }
}

