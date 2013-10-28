using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


static class DistanceBetweenPoints
{
    public static point3D GetDistance(point3D pointOne, point3D pointTwo)
    {
        point3D distance = new point3D(0, 0, 0);
        distance.X = Math.Abs(pointOne.X - pointTwo.X);
        distance.Y = Math.Abs(pointOne.Y - pointTwo.Y);
        distance.Z = Math.Abs(pointOne.Z - pointTwo.Z);
        return distance;
    }

}

