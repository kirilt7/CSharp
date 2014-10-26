using System;

class Point3DTest
{
    static void Main()
    {
        Path newPath = new Path();
        string path = "(1 2 3), (3 4 5), (8 9 10)";
        newPath.AddPoints(path);
        point3D newPoint = new point3D(13, 22, 4);
        newPath.AddPoint(newPoint);
        PointsStorage.SavePath(newPath);
        Path loadedPath = PointsStorage.LoadPath();
        foreach (var item in loadedPath.Points)
        {
            Console.WriteLine(item);
        }
    }
}
