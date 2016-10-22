using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
    string[] file = File.ReadAllLines"test.txt");

    for (int i = 0; i < file.Length; i++)
	{
	if (i%2!=0)
	{
		File.AppendAllText("output.txt",file[i]+"\r\n");
	}
	}
    }
}

