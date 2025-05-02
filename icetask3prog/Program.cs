namespace icetask3prog;
using System;
interface ICalculateArea
{
    double CalculateArea();
}

// Abstract Shape class
abstract class Shape
{
    public string Name { get; set; }

    public Shape(string name)
    {
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Shape: {Name}");
    }
}

// Rectangle class
class Rectangle : Shape, ICalculateArea
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(string name, double length, double width) : base(name)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Length: {Length}, Width: {Width}, Area: {CalculateArea()}");
    }
}

// Circle class
class Circle : Shape, ICalculateArea
{
    public double Radius { get; set; }

    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea():F2}");
    }
}

// Program Entry Point
class Program
{
    static void Main()
    {
        Shape rect = new Rectangle("My Rectangle", 10, 5);
        Shape circle = new Circle("My Circle", 4);

        Console.WriteLine("== Rectangle ==");
        rect.Display();

        Console.WriteLine("\n== Circle ==");
        circle.Display();
    }
}
