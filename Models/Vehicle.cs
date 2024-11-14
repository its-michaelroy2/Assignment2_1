using System;
namespace Assignment2_1.Models;

public class Vehicle
{
    public string VehicleType { get; set; }
    public int NumberOfWheels { get; set; }

    public Vehicle(string vehicleType, int numberOfWheels)
    {
        VehicleType = vehicleType;
        NumberOfWheels = numberOfWheels;
    }
}