using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Distance_between_Points
{
    class Program
    {
        public static void Main()
        {
            string firstPointInfo=Console.ReadLine().Split();
            string secondPointInfo=Console.ReadLine().Split();
            int firstPointX = int.Parse(firstPointInfo[0]);
            int firstPointY = int.Parse(firstPointInfo[1]);
            int secondPointX = int.Parse(firstPointInfo[0]);
            int secondPointY = int.Parse(firstPointInfo[1]);
            Point firstPoint = new Point()
            {x = firstPointX,y = firstPointY};            
            Point secondPoint = new Point()
            {x=secondPointX,y=secondPointY };

            Console.WriteLine(CalculateDistanceBetweenPoint(firstPoint,secondPoint));
        }
        public static double CalculateDistanceBetweenPoint(Point firstPoint, Point secondPoint)
        {
            double firstDiff = (firstPoint.x - secondPoint.x) *(firstPoint.x - secondPoint.x);
            double secondDiff = (firstPoint.y - secondPoint.y) * (firstPoint.y - secondPoint.y);
            double sqrt = Math.Sqrt(firstDiff);
            return sqrt;
        }
        public class Point
        {
            public int x { get; set; }
            public int y { get; set; }
        }

    }
}
          
            

