using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input=Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] command=Console.ReadLine().Split();
            int start=0;
            int count=0;
            List<string> currList=new List<string>();
            while (!command[0].Equals("end"))
	        {
	         switch (command[0])
	            {                        
                     case "rollRight":
                     count = int.Parse(command[1]);

                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            break;
                        }

                        for (int i = 0; i < (count % input.Count); i++)
                        {
                            string element = input[input.Count - 1];

                            input.RemoveAt(input.Count - 1);
                            input.Insert(0, element);
                        }
                     break;
		            default:
                break;
	            }



                command = Console.ReadLine().Split();
	        }
            string output = string.Join(", ",input);
            Console.WriteLine("[{0}]",output);
        }
    }
}
