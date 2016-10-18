using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        var events = new Dictionary<DateTime, string>();
        events[new DateTime(1998,9,4)] = "Doogle's birth date";
        events[new DateTime(2013,11,5)] = "Doogle's birth date";
        events[new DateTime(1975,4,4)] = "Microsoft's birth date";
        events[new DateTime(2004,2,4)] = "Facebook's birth date";
        events[new DateTime(2013,11,5)] = "SoftUni was foundet";

        foreach (var entry in events.OrderBy(i => i.Key))
        {
            Console.WriteLine("{0:dd-MMM-yyyy}: {1}",entry.Key,entry.Value);
        }
    }
}

