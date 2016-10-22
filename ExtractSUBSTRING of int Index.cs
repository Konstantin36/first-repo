using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class ExtractSUBSTRINGofintIndex
{
    static void Main(string[] args)
    {
        string filename = "C:\\Pics\\Rila2005.jpg";
        string name=filename.Substring(8);
            Console.WriteLine(name);
    }
}

