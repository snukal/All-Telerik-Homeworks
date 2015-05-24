using System;

//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

class GravitationOnTheMoon
{
    static void Main()
    {
        double MoonGraviti = 0.17;
        Console.WriteLine("Please enter your weight on Earth :");
        double WeightEarth = double.Parse(Console.ReadLine());
        double WeightMoon = (WeightEarth * (double)MoonGraviti);
        Console.WriteLine("Yor weight on the moon is :" + (double)WeightMoon);
     }
}
