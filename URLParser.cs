using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.URL_Parser
    {
    class URLParser
        {
        static void Main(string[] args)
            {
            char[] separators = { ':', '/' };
            string inputStr = Console.ReadLine();
            string[] fullPath = inputStr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string protocol = "";
            string server = "";
            int pathPOS = 2;
            List<string> resource = new List<string>();

            if (inputStr.Contains("://"))
                {
                protocol = fullPath[0];
                Console.WriteLine($"[protocol] = \"{protocol}\"");
                server = fullPath[1];
                }
            else
                {
                Console.WriteLine($"[protocol] = \"{protocol}\"");
                server = fullPath[0];
                pathPOS = 1;
                }

            Console.WriteLine($"[server] = \"{server}\"");
            Console.Write($"[resource] = \"");

            // With LIST solution
            for (int i = pathPOS; i < fullPath.Length; i++)
                {
                resource.Add(fullPath[i]);
                }
            Console.Write(string.Join("/", resource));

            ////Without LIST solution
            //for (int i = pathPOS; i < fullPath.Length; i++)
            //    {
            //    Console.Write(fullPath[i]);
            //    if (i < fullPath.Length - 1)
            //        {
            //        Console.Write("/");
            //        }
            //    }

            Console.WriteLine("\"");

            }
        }
    }