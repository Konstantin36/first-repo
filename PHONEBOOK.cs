using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        var phonebook = new Dictionary<string, string>();
        string commandLine = Console.ReadLine();
        while (!commandLine.Equals("END"))
        {
            string[] commandArgs = commandLine.Split(' ');
            string command = commandArgs[0];
            if (command.Equals("A"))
            {
                AddNewEntry(phonebook, commandArgs);
            }
            else if (command.Equals("S"))
            {
                PrintEntry(phonebook, commandArgs);
            }
            else if (command.Equals("ListAll"))
                PrintAllEntries(phonebook);
            commandLine = Console.ReadLine();
        }
    }

    private static void PrintAllEntries(Dictionary<string, string> phonebook)
    {
        foreach (var entry in phonebook.OrderBy(x=>x.Key))
        {
            Console.WriteLine("{0} -> {1}",entry.Key,entry.Value);
        }
    }

    private static void PrintEntry(Dictionary<string, string> phonebook, string[] commandArgs)
    {
        string contact = commandArgs[1];
        if (phonebook.ContainsKey(contact))
        {
            Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);
        }
        else
        {
            Console.WriteLine("Contact {0} does not exist.", contact);
        }
    }

    private static void AddNewEntry(Dictionary<string, string> phonebook, string[] commandArgs)
    {
        //add
        string contact = commandArgs[1];
        string number = commandArgs[2];
        //   phonebook.Add(contact,number); добавя стойности без да ги заменя
        phonebook[contact] = number;      // заменя стойности
    }
}

