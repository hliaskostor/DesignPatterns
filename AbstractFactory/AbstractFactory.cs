using System;


public abstract class Engine
{
    public abstract void Start();
}

public abstract class Tires
{
    public abstract void Rotate();
}


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


public abstract class CarFactory
{
    public abstract Engine CreateEngine();
    public abstract Tires CreateTires();
}

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

class AbstractFactory
{
    static void Main(string[] args)
    {
        CarFactory sedanFactory = new SedanFactory();
        Engine sedanEngine = sedanFactory.CreateEngine();
        Tires sedanTires = sedanFactory.CreateTires();

        sedanEngine.Start();  
        sedanTires.Rotate();  

        CarFactory suvFactory = new SUVFactory();
        Engine suvEngine = suvFactory.CreateEngine();
        Tires suvTires = suvFactory.CreateTires();

        suvEngine.Start(); 
        suvTires.Rotate();  
    }
}
