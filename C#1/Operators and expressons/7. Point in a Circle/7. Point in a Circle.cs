using System;

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

class PointInACircle
{
    static void Main()
    {
        Console.Write("Enter value for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter value for y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInside = (x * x) + (y * y) <= (2 * 2);

        Console.Write("Point with cordinates ("+ x );
        Console.Write(" / " + y);
        Console.WriteLine(") is inside the circle = " + isInside);
    }
}