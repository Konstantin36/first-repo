using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VehiclePark
{
    static void Main()
    {
        List<string> vehicles = Console.ReadLine().Split(' ').ToList();
        string salesVehicle = Console.ReadLine().ToLower();
        int count = 0;
        while (salesVehicle != "end of customers!")
        {
            string[] salesSplit = salesVehicle.Split(' ');
            char vehicle = salesSplit[0][0];
            int seats = int.Parse(salesSplit[2]);


            if (vehicles.Contains(vehicle + seats.ToString()))
            {
                Console.WriteLine("Yes, sold for {0}$", vehicle * seats);
                vehicles.Remove(vehicle + seats.ToString());
                count++;
            }
            else
            {
                Console.WriteLine("No");
            }

            salesVehicle = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Vehicles left: " + string.Join(", ", vehicles));
        Console.WriteLine("Vehicles sold: {0}", count);

    }
}


