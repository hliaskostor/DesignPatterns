using System;
using System.Collections.Generic;

// Shape abstract class
public abstract class Shape
{
    public abstract double Area();
}

// Rectangle class
public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }
}

// Circle class
public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return 3.14 * radius * radius;
    }
}

public class OCP
{
    public static double CalculateTotalArea(List<Shape> shapes)
    {
        double totalArea = 0;
        foreach (Shape shape in shapes)
        {
            totalArea += shape.Area();
        }
        return totalArea;
    }

    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 3);
        Circle circle = new Circle(2);

        List<Shape> shapes = new List<Shape> { rectangle, circle };
        double totalArea = CalculateTotalArea(shapes);
        Console.WriteLine("Total Area: " + totalArea);
    }
}
