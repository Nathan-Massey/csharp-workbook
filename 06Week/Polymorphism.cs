using System;

public class Program
{
    public static void Main()
    {
        Shape r = new Rectangle(34, 12); // Upcasting

        Shape t = new Triangle(12, 45, 67);

        ShowPerimeter(t);
        ShowPerimeter(r);

        Console.ReadLine();

    }

    public static void ShowPerimeter(Shape s)
    {
        Console.WriteLine(s.Perimeter());
    }
}

public abstract class Shape
{
    // Properties
    public int Height { get; set; }
    public int Width { get; set; }

    // Constructor
    public Shape(int h, int w)
    {
        Height = h;
        Width = w;
    }

    // Method

    public abstract int Area();

    public abstract int Perimeter();
}

// Rectangle
public class Rectangle : Shape
{
    // Properties that are inherited
    // Height
    // Width

    public Rectangle(int h, int w) : base(h, w)
    {
        // Will run after the Shape() constructor
    }

    public int Angles() => 4;

    public override int Area() => Height * Width;

    public override int Perimeter() => (Height + Width) * 2;
}


// Triangle
public class Triangle : Shape
{
    // Height
    // Width
    public int Diagonal { get; set; }

    public Triangle(int h, int w, int d) : base(h, w)
    {
        // Height
        // Width
        Diagonal = d;
    }

    public int Angles() => 3;

    public override int Area()
    {
        // Heron's formula

        var s = Perimeter() / 2;

        var result = Math.Sqrt(s* (s - Height) * (s - Diagonal) * (s - Width));

        return Convert.ToInt32(Math.Floor(result));

        // Floor - 2.74 = 2

        // Ceiling - 2.74 = 3
    }

    public override int Perimeter() => Height + Diagonal + Width;
}
