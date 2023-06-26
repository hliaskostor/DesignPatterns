using System;


public abstract class Car
{
    public abstract void Drive();
}


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

class Factory
{
    static void Main(string[] args)
    {
        CarFactory carFactory = new CarFactory();

        Car sedan = carFactory.CreateCar("sedan");
        sedan.Drive();  

        Car suv = carFactory.CreateCar("suv");
        suv.Drive(); 
    }
}
