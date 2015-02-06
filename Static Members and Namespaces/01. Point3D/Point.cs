using System;

namespace _01.Point3D
{
    public class Point
    {
        static void Main()
        {
            Point3D point = new Point3D(5.24, 1.01, 6.3);
            Console.WriteLine(point);

            Point3D startingPoint = Point3D.StartingPoint;
            Console.WriteLine(startingPoint);
        }
    }
}
