using System;

namespace Chap2Studio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius: ");

            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;

            Console.WriteLine("The area of a circle with a radius of " + radius + " is: " + area);
            Console.WriteLine("The circumference of a circle with a radius of " + radius + " is: " + circumference + "\nThe diameter of a circle with a radius of " + radius + " is: " + diameter);

            Console.WriteLine("How many miles per gallon does your car get?");
            double mpg = double.Parse(Console.ReadLine());
            double galPerCircle = circumference / mpg;
            Console.WriteLine("Your car will use " + galPerCircle + " gallons to travel around a circle with a radius of " + radius + " miles.");

        }
    }
}
