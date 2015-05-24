using System;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("Enter value for x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter value for y: ");
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5); // check if the point is in the circle

        bool isOutsideRectangle = x > 1 || x < 6 && y > -1 || y < 2; // check if the point is in the rectangle

        if (x == 0 || y == 0)
        {
            Console.WriteLine("The point is not inside the circle or not outside the rectangle");
        }
        else if (isInCircle == true && isOutsideRectangle == true)
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle");
        }
        else
        {
            Console.WriteLine("The point is not inside the circle or not outside the rectangle");
        }
    }
}