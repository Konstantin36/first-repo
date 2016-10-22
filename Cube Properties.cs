using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{

    static void Main(string[] args)
    {

        var side = double.Parse(Console.ReadLine());
        var parameters = Console.ReadLine();

        var diagonalFace = Math.Sqrt(2*side*side);
        var diagonalCube = Math.Sqrt(side * side + diagonalFace * diagonalFace);
        var volume = side * side * side;
        var area = 6 * side * side;
        if (parameters == "face")
        {

            Console.WriteLine("{0:F2}",diagonalFace);

        }
        if (parameters == "volume")
        {

            Console.Write("{0:F2}", volume);
        }
        if (parameters=="space")
        {
            Console.WriteLine("{0:F2}", diagonalCube);
        }
        else if (parameters=="area")
        {
            Console.WriteLine("{0:F2}",area);
        }

        Console.WriteLine();
    }

}