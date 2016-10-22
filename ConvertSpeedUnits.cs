using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float timeInSeconds = hours * 3600f + minutes * 60f + seconds;
            float timeInHours = hours + minutes / 60f + seconds / 3600f;
            float distanceInMiles = distanceInMeters / 1609f;
            float distanceInKolometers = distanceInMeters / 1000f;
            Console.WriteLine(distanceInMeters/timeInSeconds);
            Console.WriteLine(distanceInKolometers/timeInHours);
            Console.WriteLine(distanceInMiles/timeInHours);
        }
    }
}
