using System;
namespace Assignment2_1.Models;

public class Model : Make
{
    public string ModelName { get; set; }
    public int Year { get; set; }

    public Model(string modelName, int year, string brandName, string fuelType)
        : base(brandName, fuelType)
    {
        ModelName = modelName;
        Year = year;
    }
}