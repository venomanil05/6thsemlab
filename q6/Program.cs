using System;

// Abstract class
abstract class Shape
{
    // Abstract method
    public abstract void CalculateArea();

    // Normal method
    public void Display()
    {
        Console.WriteLine("This is a shape.");
    }
}

// Interface
interface IPrintable
{
    void Print();
}

// Child class
class Circle : Shape, IPrintable
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Implement abstract method
    public override void CalculateArea()
    {
        double area = Math.PI * radius * radius;

        Console.WriteLine("Area of Circle: " + area);
    }

    // Implement interface method
    public void Print()
    {
        Console.WriteLine("Circle information printed.");
    }
}

class Program
{
    static void Main()
    {
        // Create Circle object
        Circle circle = new Circle(5);

        // Call abstract class method
        circle.Display();

        // Calculate area
        circle.CalculateArea();

        // Call interface method
        circle.Print();
    }
}
