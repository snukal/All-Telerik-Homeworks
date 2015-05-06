using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TriangleSurface
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double angle = Convert.ToDouble((Math.PI * 90) / 180);
        SurfaceBySideAndAttitude(a, h);
        SurfaceByThreeSides(a, b, c);
        SurfaceByTwoSidesAndAngleBetweenThem(a, b, angle);
    }
    static void SurfaceBySideAndAttitude(double side, double att)
    {
        double surface = (side * att) / 2;
        Console.WriteLine("Surface of the triangle by given side and attitude to it: {0}sm", surface);
    }
    static void SurfaceByThreeSides(double s1, double s2, double s3)
    {
        double p = (s1 + s2 + s3) / 2;
        double surface = Convert.ToDouble(Math.Sqrt(p * (p - s1) * (p - s2) * (p - s3)));
        Console.WriteLine("Surface of the triangle by given all its sides: {0}sm", surface);
    }
    static void SurfaceByTwoSidesAndAngleBetweenThem(double s1, double s2, double ang)
    {
        double surface = Convert.ToDouble((s1 * s2 * Math.Sin(ang)) / 2);
        Console.WriteLine("Surface of the triangle by given two sides and angle between them: {0}sm", surface);
    }
}