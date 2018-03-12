﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        var carInfo = Console.ReadLine()
            .Split(' ');
        Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

        var truckInfo = Console.ReadLine()
            .Split(' ');
        Vehicle truck = new Car(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

        var commandsNum = int.Parse(Console.ReadLine());

        for (int i = 0; i < commandsNum; i++)
        {
            var commandTokens = Console.ReadLine()
                .Split(' ');
            var vehicleType = commandTokens[1];

            if (vehicleType == "Car")
            {
                ExecuteAction(car, commandTokens[0], double.Parse(commandTokens[2]));
            }
            else
            {
                ExecuteAction(truck, commandTokens[0], double.Parse(commandTokens[2]));
            }
        }

        Console.WriteLine(car);
        Console.WriteLine(truck);
    }

    private static void ExecuteAction(Vehicle vehicle, string command, double parameter)
    {
        switch (command)
        {
            case "Drive":
                var result = vehicle.TryTravellDistance(parameter);
                Console.WriteLine(result);
                break;
            case "Refuel":
                vehicle.Refuel(parameter);
                break;               
        }
    }
}
