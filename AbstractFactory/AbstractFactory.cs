using System;

// Abstract Products
public abstract class Engine
{
    public abstract void Start();
}

public abstract class Tires
{
    public abstract void Rotate();
}

// Concrete Products
public class V6Engine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Starting V6 Engine");
    }
}

public class V8Engine : Engine
{
    public override void Start()
    {
        Console.WriteLine("Starting V8 Engine");
    }
}

public class SummerTires : Tires
{
    public override void Rotate()
    {
        Console.WriteLine("Rotating Summer Tires");
    }
}

public class WinterTires : Tires
{
    public override void Rotate()
    {
        Console.WriteLine("Rotating Winter Tires");
    }
}

// Abstract Factory
public abstract class CarFactory
{
    public abstract Engine CreateEngine();
    public abstract Tires CreateTires();
}

// Concrete Factories
public class SedanFactory : CarFactory
{
    public override Engine CreateEngine()
    {
        return new V6Engine();
    }

    public override Tires CreateTires()
    {
        return new SummerTires();
    }
}

public class SUVFactory : CarFactory
{
    public override Engine CreateEngine()
    {
        return new V8Engine();
    }

    public override Tires CreateTires()
    {
        return new WinterTires();
    }
}

// Usage
class AbstractFactory
{
    static void Main(string[] args)
    {
        CarFactory sedanFactory = new SedanFactory();
        Engine sedanEngine = sedanFactory.CreateEngine();
        Tires sedanTires = sedanFactory.CreateTires();

        sedanEngine.Start();  // Output: Starting V6 Engine
        sedanTires.Rotate();  // Output: Rotating Summer Tires

        CarFactory suvFactory = new SUVFactory();
        Engine suvEngine = suvFactory.CreateEngine();
        Tires suvTires = suvFactory.CreateTires();

        suvEngine.Start();  // Output: Starting V8 Engine
        suvTires.Rotate();  // Output: Rotating Winter Tires
    }
}
