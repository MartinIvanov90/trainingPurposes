using System;


namespace OopPartTwo
{
    public static class CalculateDistance
    {
        static double DistanceCalculator(Point3D pointA, Point3D pointB)
        {

            return Math.Sqrt(
                    (pointA.X - pointB.X) * (pointA.X - pointB.X) +
                    (pointA.Y - pointB.Y) * (pointA.Y - pointB.Y) +
                    (pointA.Z - pointB.Z) * (pointA.Z - pointB.Z)
                    );
        }
    }
}
