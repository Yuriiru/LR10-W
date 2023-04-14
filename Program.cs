using System;
using System.Collections.Generic;

public class Car
{
    public string CarName { get; set; }

}
public class Garage
{
    public List<Car> garage = new List<Car>();

}
public class Washer
{
    public delegate void WashCars(Car car);

    public WashCars washCars = new WashCars(wash);
    public static void wash(Car car)
    {
        Console.WriteLine($" Моем ваш {car.CarName}");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Car porshe = new Car();
        Car mercedes = new Car();
        Car bmv = new Car();

        porshe.CarName = "Porshe";
        mercedes.CarName = "Mercedes";
        bmv.CarName = "BMV";

        Garage garag = new Garage();
        garag.garage.Add(porshe);
        garag.garage.Add(mercedes);
        garag.garage.Add(bmv);

        Washer washer = new Washer();

        foreach (var car in garag.garage)
        {
            washer.washCars(car);
        }

        Console.ReadLine();
    }
}
