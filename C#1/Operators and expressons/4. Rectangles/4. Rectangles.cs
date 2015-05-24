using System;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter the weight of the rectangle:");
        double RecWeight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the rectangle:");
        double RecHeight = double.Parse(Console.ReadLine());
        double RecPerim = (double)((RecHeight + RecWeight) * 2);
        double RecArea = (double)(RecHeight * RecWeight);
        Console.WriteLine(RecPerim + " " + "is the perimeter of the rectangle.");
        Console.WriteLine(RecArea + " " + "is the area of the rectangle.");
    }
}
