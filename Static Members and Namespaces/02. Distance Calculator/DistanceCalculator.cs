﻿using System;
using _01.Point3D;

namespace _02.Distance_Calculator
{
    static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D p1, Point3D p2)
        {
            double deltaX = p2.X - p1.X;
            double deltaY = p2.Y - p1.Y;
            double deltaZ = p2.Z - p1.Z;

            double distance = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2) + Math.Pow(deltaZ, 2));

            return distance;
        }
    }
}
