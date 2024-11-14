using System;
namespace Assignment2_1.Models;

public class Make : Car
{
    public string BrandName { get; set; }

    public Make(string brandName, string fuelType) : base(fuelType)
    {
        BrandName = brandName;
    }
}