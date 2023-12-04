using System;

class Figure
{
    public virtual double CalculateArea()
    {
        return 0;
    }

    public virtual double CalculatePerimeter()
    {
        return 0;
    }
}

class Circle : Figure
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }

    public override double CalculatePerimeter()
    {
        return 2 * (Width + Height);
    }
}
      //      Console.WriteLine("Завдання2");
public class Fruit
{
    public string Name { get; set; }
}

public class Apple : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

public class Pear : Fruit
{
    public string Variety { get; set; }
    public string Color { get; set; }
}

