using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        var p1 = ReadPoint();
        var p2 = ReadPoint();
        Console.WriteLine("{0:F3}",CalcDistance(p1,p2));
    }
    static Point ReadPoint()
    {
        var coords = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var p = new Point() { X = coords[0], Y = coords[1] };
        return p;
    }

    private static double CalcDistance(Point p1, Point p2)
    {
        var a = p1.X - p2.X;
        var b = p1.Y - p2.Y;    
               
        return Math.Sqrt(a * a + b * b);
    }
}

