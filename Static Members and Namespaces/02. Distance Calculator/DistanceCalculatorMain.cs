using System;
using _01.Point3D;

namespace _02.Distance_Calculator
{
    class DistanceCalculatorMain
    {
        static void Main()
        {
            Point3D point = new Point3D(3.4, 7, 4.8);
            Point3D point2 = new Point3D(12, 1.5, 8);

            Console.WriteLine("Distance: " + DistanceCalculator.CalculateDistance(point, point2));
        }
    }
}
