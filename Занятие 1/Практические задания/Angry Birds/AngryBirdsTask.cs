using System;

namespace AngryBirds;

public static class AngryBirdsTask
{
    public static double FindSightAngle(double v, double distance)
    {
        return Math.PI / 4;
        double g = 9.8;
        return 0.5 * Math.Asin(distance * g / Math.Pow(v, 2));
    }
}