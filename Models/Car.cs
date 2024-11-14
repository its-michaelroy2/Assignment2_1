using System;
namespace Assignment2_1.Models;

public class Car : Vehicle
{
    public string FuelType { get; set; }

    public Car(string fuelType) : base("Car", 4)
    {
        FuelType = fuelType;
    }
}
