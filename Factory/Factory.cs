using System;

// Product
public abstract class Car
{
    public abstract void Drive();
}

// Concrete Products
public class Sedan : Car
{
    public override void Drive()
    {
        Console.WriteLine("Driving a Sedan");
    }
}

public class SUV : Car
{
    public override void Drive()
    {
        Console.WriteLine("Driving an SUV");
    }
}

// Factory
public class CarFactory
{
    public Car CreateCar(string carType)
    {
        if (carType == "sedan")
        {
            return new Sedan();
        }
        else if (carType == "suv")
        {
            return new SUV();
        }
        else
        {
            throw new ArgumentException("Invalid car type");
        }
    }
}

// Usage
class Factory
{
    static void Main(string[] args)
    {
        CarFactory carFactory = new CarFactory();

        Car sedan = carFactory.CreateCar("sedan");
        sedan.Drive();  // Output: Driving a Sedan

        Car suv = carFactory.CreateCar("suv");
        suv.Drive();  // Output: Driving an SUV
    }
}
